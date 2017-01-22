using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Procore.Models
{
    public class Number
    {
        [Required(ErrorMessage = "Please enter a number")]
        public int number { get; set; }
    }
}