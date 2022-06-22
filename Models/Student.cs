using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SampleMVCapp.Models
{
    public class Student
    {    [Key]
         [ScaffoldColumn(false)]
        public int Rollno { get; set; }
        [Display(Name="Student Name")]
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Age is required")]
        [Range(minimum:18,maximum:60,ErrorMessage ="Age Should be between 18-60")]
        public int Age { get; set; }
        [Required(ErrorMessage = "EmailId is required")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Email Id is not in proper Fromat")]
        public string EmailId { get; set; }
        [Required(ErrorMessage = "City is required")]
        [MaxLength(20)]
        public string City { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]

        public string Password { get; set; }

    }
}