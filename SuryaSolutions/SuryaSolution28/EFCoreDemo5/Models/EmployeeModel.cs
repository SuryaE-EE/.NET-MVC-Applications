using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EfCoreDemo05
{
    [Table("tblPeople")]
    public class EmployeeModel
    {
        [Key]
        public int Id { get; set; }
        public string EName { get; set; }
        public string Gender { get; set; }
       
        public int Age { get; set; }
    }
}
