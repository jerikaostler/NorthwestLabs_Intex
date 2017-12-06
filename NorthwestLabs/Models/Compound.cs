using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Compound")]
    public class Compound
    {
        [Key]
        [Column(Order = 1)]
        [Display(Name ="LT")]
        public int LT { get; set; }

        [Display(Name ="CompoundName")]
        [Required(ErrorMessage = "This field is required")]
        public string CompoundName { get; set; }

        [Display(Name = "MTD")]
        [Required(ErrorMessage = "This field is required")]
        public int MTD { get; set; }


    }
}