using System.ComponentModel.DataAnnotations;

namespace WomenEmpowerment.Models
{
    public class Step_Registration
    {
        [Key]
        public int Step_Id { get; set; }
        public int User_Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public string Is_Married { get; set; }
        public string Spouse_Name { get; set; }
        public string Fathername { get; set; }
        public string Mothername { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }
        public string User_Photo { get; set; }
        public string Identity_Proof { get; set; }
        public string Identity_Proof_Image { get; set; }
        public int Is_Approoved { get; set; }
    }
}
