using NF.Domain.Entities;
using NF.Infra.Data.Repositories;
using System.Collections.Generic;

namespace NF.Domain.Interfaces.Repositories
{
    public interface IDepartmentRepository : IRepositoryBase<Department>
    {

        public IEnumerable<EmployeeDepartmentHistory> GetDepartments();

    }
}
