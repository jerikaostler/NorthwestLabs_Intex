using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Assay")]
    public class Assay
    {
        [Key]
        [Display(Name = "AssayID")]
        public int AssayID { get; set; }

        [Display(Name = "AssayName")]
        [Required(ErrorMessage = "This field is required")]
        public string AssayName { get; set; }

        [Display(Name = "EstimatedDaysToComplete")]
        [Required(ErrorMessage = "This field is required")]
        public int EstimatedDaysToComplete { get; set; }

        [Display(Name = "DetailedDescription")]
        [Required(ErrorMessage = "This field is required")]
        public string DetailedDescription { get; set; }

        [Display(Name = "StartDate")]
        [Required(ErrorMessage = "This field is required")]
        public string StartDate { get; set; }

        [Display(Name = "NoOfTests")]
        [Required(ErrorMessage = "This field is required")]
        public int NoOfTests { get; set; }

        [Display(Name = "AbbreviationCode")]
        [Required(ErrorMessage = "This field is required")]
        public string AbbreviationCode { get; set; }
    }
}