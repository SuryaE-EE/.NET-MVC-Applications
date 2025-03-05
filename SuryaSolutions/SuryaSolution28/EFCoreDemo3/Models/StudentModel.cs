using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFCoreDemo3.Models
{
    [Table("tblStudents")]
    public class StudentModel
    {
        [Key]
        public int Id { get; set; }
        public string SName { get; set; }
        public string Course { get; set; }
        public int Fees { get; set; }
    }

}
