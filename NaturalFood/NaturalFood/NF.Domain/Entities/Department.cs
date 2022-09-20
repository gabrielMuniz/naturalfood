using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace NF.Infra.Data.Repositories
{
    [Table("Department", Schema = "HumanResources")]
    public class Department
    {

        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string GroupName { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}
