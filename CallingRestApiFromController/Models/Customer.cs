using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CallingRestApiFromController.Models
{
    public class Customer
    {
        public int id { get; set; }
        [Display(Name = "Customer Name")]
        public string name { get; set; }
        [Display(Name = "Customer Father Name")]
        public string fathername { get; set; }
        [Display(Name = "Customer Mother Name")]
        public string mothername { get; set; }
        [Display(Name = "Contact No")]
        public string phone { get; set; }
    }
}