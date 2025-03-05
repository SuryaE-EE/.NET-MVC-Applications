using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeApi
{

    [Table("tblEmployees")]
        public class EmployeeModel
        {
            [Key]
            public int Id { get; set; }
            public string SName { get; set; }
            public string Course { get; set; }
            public int Fee { get; set; }
        }
    
}
