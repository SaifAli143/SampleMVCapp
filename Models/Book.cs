using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SampleMVCapp.Models
{
    public class Book
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [Display(Name="Book NAME")]
        [Required(ErrorMessage ="Book Name is required")]
        public string Name { get; set; }
       
        [Required(ErrorMessage = "Author Name is required")]
        [MaxLength(20)]
        public string Author_Name { get; set; }
        
        [Required(ErrorMessage = "Publisher Name is required")]
        [MaxLength(40)]
        public string Publisher_Name { get; set; }
        [Required(ErrorMessage = "Published Date is required")]
        [DataType(DataType.Date)]

        public DateTime Published_Date { get; set; }
        [Required(ErrorMessage = "Price is required")]
        [Range(minimum:100,maximum:1000,ErrorMessage ="Price Should be between 100-1000")]
        public double Price { get; set; }

    }
}