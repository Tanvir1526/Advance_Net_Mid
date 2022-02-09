using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab_Product.Models
{
    public class Student
    {
        [Required(ErrorMessage ="please Fill your name")]
        [StringLength(50,ErrorMessage ="string must not be 50")]
        public string Name { get; set; }
        [Required]
       
        public int  Id { get; set; }
        [Required]
        public string Dob { get; set; }
        [Required]
        public string Email { get; set; }
    }
}