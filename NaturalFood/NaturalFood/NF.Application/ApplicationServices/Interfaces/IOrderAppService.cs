using NF.Application.Commands;
using NF.Application.DTOs;

namespace NF.Application.ApplicationServices.Interfaces
{
    public interface IOrderAppService
    {

        public void Add(CreateOrderDTO createOrderDTO);

    }
}
