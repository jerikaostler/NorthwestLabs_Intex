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
        [Key]
        [Column(Order =2)]
        [Display(Name ="SequenceCode")]
        [Required(ErrorMessage ="This field is required")]
        public int SequenceCode { get; set; }

        [Display(Name ="CompoundName")]
        [Required(ErrorMessage = "This field is required")]
        public string CompoundName { get; set; }

        [Display(Name = "QuantityInMilligrams")]
        [Required(ErrorMessage = "This field is required")]
        public decimal QuantityInMilligrams { get; set; }

        [Display(Name = "Appearance")]
        [Required(ErrorMessage = "This field is required")]
        public Byte[] Appearance { get; set; }

        [Display(Name = "Weight")]
        [Required(ErrorMessage = "This field is required")]
        public decimal Weight { get; set; }

        [Display(Name = "MolecularMass")]
        [Required(ErrorMessage = "This field is required")]
        public int MolecularMass { get; set; }

        [Display(Name = "MTD")]
        [Required(ErrorMessage = "This field is required")]
        public int MTD { get; set; }


    }
}