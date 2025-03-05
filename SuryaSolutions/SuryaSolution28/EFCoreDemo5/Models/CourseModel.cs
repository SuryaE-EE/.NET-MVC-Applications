using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreDemo5.Models
{
    [Table("courses")]
    public class CourseModel
    {
        [Key]
        public int Id { get; set; }
        public string CName { get; set; }
        public string CType { get; set; }

        public int Fee { get; set; }
    }
}
