using System.ComponentModel.DataAnnotations;

namespace StudentMS.Models
{
    public class Student
    {
        public int StudentID { get; set; }

        [Required, StringLength(50), Display(Name = "Student Name")]
        public string Name { get; set; }

        [Required, Display(Name = "Age")]
        public int Age { get; set; }

        public string Degree { get; set; }

        [Display(Name = "Student Status")]
        public string Status { get; set; }
    }
}
