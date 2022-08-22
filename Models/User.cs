using System;
using System.ComponentModel.DataAnnotations;

namespace WomenEmpowerment.Models
{
    public class User
    {
        [Key]
        public int User_Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime Date_of_Birth { get; set; }
        public string Contact { get; set; }

    }
}
