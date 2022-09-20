using Microsoft.EntityFrameworkCore;
using NF.Domain.Entities;
using NF.Domain.Interfaces.Repositories;
using NF.Infra.Data.Contexts;
using NF.Infra.Data.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NF.Infra.Data.Repositories
{
    public class DepartmentRepository : BaseRepository<Department>, IDepartmentRepository
    {

        private readonly DefaultContext context;

        public DepartmentRepository(DefaultContext context) : base(context)
        {
            this.context = context;
        }

        public IEnumerable<EmployeeDepartmentHistory> GetDepartments()
        {
            return context.EmployeeDepartmentHistories
                .Where(edh => edh.Department.Name != "Engineering").Include(d => d.Department);
        } 
    }
}
