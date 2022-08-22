using System.ComponentModel.DataAnnotations;

namespace WomenEmpowerment.Models
{
    public class Provide
    {
        [Key]
        public int Provide_Id { get; set; }
        public int Ngo_Id { get; set; }
        public int Course_Id { get; set; }
    }
}
