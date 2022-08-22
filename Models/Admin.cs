using System.ComponentModel.DataAnnotations;

namespace WomenEmpowerment.Models
{
    public class Admin
    {

        [Key]
        public int Admin_Id { get; set; }
        public string Admin_Password { get; set; }
    }
}
