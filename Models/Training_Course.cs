using System;
using System.ComponentModel.DataAnnotations;

namespace WomenEmpowerment.Models
{
    public class Training_Course
    {
        [Key]
        public int Course_Id { get; set; }
        public string Sector { get; set; }
        public string Coursename { get; set; }
        public int Intake { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public int Is_Active { get; set; }
    }
}
