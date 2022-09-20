using NF.Infra.Data.Repositories;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace NF.Domain.Entities
{
    [Table("EmployeeDepartmentHistory", Schema = "HumanResources")]
    public class EmployeeDepartmentHistory
    {

        public int BusinessEntityId { get; set; }
        public virtual Department Department { get; set; }
        public int DepartmentId { get; set; }
        public byte ShiftId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
