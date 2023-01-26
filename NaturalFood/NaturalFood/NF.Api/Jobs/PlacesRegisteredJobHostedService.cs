using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using NF.Application.ApplicationServices;
using NF.Application.ApplicationServices.Interfaces;
using NF.Domain.Interfaces.Repositories;
using RabbitMQ.Client;
using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NF.Api.Jobs
{
    public class PlacesRegisteredJobHostedService : IHostedService, IDisposable
    {

        private readonly ConnectionFactory _connectionFactory;
        private const string queueName = "places";
        private Timer _timer;

        public IServiceProvider ServiceProvider { get; set; }

        public PlacesRegisteredJobHostedService(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
            _connectionFactory = new ConnectionFactory
            {
                HostName = "localhost"
            };
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {

            //_timer = new Timer(PostRegisteredPlaces, null, TimeSpan.Zero, TimeSpan.FromSeconds(5));

            return Task.CompletedTask;

        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _timer?.Change(Timeout.Infinite, 0);
            return Task.CompletedTask;
        }

        private void PostRegisteredPlaces(object state)
        {
            using (var scope = ServiceProvider.CreateScope())
            {
                using (var connection = _connectionFactory.CreateConnection())
                {
                    using (var channel = connection.CreateModel())
                    {
                        //channel.QueueDeclare(
                        //    queue: queueName,
                        //    durable: false,
                        //    exclusive: false,
                        //    autoDelete: false,
                        //    arguments: null);

                        var placeRepository = scope.ServiceProvider.GetRequiredService<IPlaceRepository>();

                        var places = placeRepository.GetAll();
                        foreach (var place in places)
                        {
                            var stringfiedMessage = JsonConvert.SerializeObject(place);
                            var bytesMessage = Encoding.UTF8.GetBytes(stringfiedMessage);

                            channel.BasicPublish(exchange: "", routingKey: queueName,
                                basicProperties: null, body: bytesMessage);
                        }
                    }
                }
            }
        }
    }
}
