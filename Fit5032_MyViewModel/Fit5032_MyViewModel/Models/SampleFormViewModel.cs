using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Fit5032_MyViewModel.Models
{
    public class SampleFormViewModel
    {
    }
    public class FormOneViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}