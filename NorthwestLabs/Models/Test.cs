using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{   
    [Table("Test")]
    public class Test
    {
        [Key]
        public int TestID { get; set; }

        [Display(Name = "Test name")]
        public string TestName { get; set; }

        [Display(Name = "Conditional Test")]
        public bool Conditional { get; set; }

        [Display(Name = "Base Price")]
        public decimal BasePrice { get; set; }

        [Display(Name = "Test Duration")]
        public decimal TestDuration { get; set; }
    }
}