using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Material")]
    public class Material
    {
        [Key]
        public int MaterialID;

        [Display(Name = "Material Description")]
        public string Description;

        [Display(Name = "Material Cost")]
        public decimal MaterialCost;

    }
}