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
        public int TestID;

        [Display(Name = "Test name")]
        public string TestName;

        [Display(Name = "Conditional Test")]
        public bool Conditional;

        [Display(Name = "Base Price")]
        public decimal BasePrice;

        [Display(Name = "Test Duration")]
        public decimal TestDuration;
    }
}