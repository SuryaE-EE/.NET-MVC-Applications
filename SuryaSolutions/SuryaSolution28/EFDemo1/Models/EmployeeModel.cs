using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDemo1
{
    [Table("tblEmployees")]
    public class EmployeeModel
    {
        [Key]
        public int Id { get; set; }
        public string EName { get; set; }
        public string Job { get; set; }
        public int Salary { get; set; }
    }
}