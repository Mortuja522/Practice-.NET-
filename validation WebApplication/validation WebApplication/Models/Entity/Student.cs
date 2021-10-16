using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace validation_WebApplication.Models.Entity
{
    public class Student
    {

        public string id { set; get; }

        [Required]
        public string name { set; get; }

        [Required (ErrorMessage ="please provide dob")]
        public string dob { set; get; }
        [Required]
        public string gender { set; get; }

        public float cgpa { set; get; }

      
    }
}