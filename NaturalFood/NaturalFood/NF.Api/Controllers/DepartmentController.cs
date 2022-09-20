using Microsoft.AspNetCore.Mvc;
using NF.Api.Controllers.Base;
using NF.Domain.Entities;
using NF.Domain.Interfaces.Repositories;
using System.Collections.Generic;

namespace NF.Api.Controllers
{
    [Route("/departments")]
    public class DepartmentController : BaseController
    {

        private readonly IDepartmentRepository departmentRepository;

        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            this.departmentRepository = departmentRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<EmployeeDepartmentHistory>> GetAll()
        {
            return Ok(departmentRepository.GetDepartments()) ;
        }

    }
}
