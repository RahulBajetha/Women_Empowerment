using System.ComponentModel.DataAnnotations;

namespace WomenEmpowerment.Models
{
    public class Take
    {
        [Key]
        public int TakeId { get; set; }
        public int Step_Id { get; set; }
        public int Course_Id { get; set; }
    }
}
