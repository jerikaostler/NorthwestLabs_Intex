using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Equipment")]
    public class Equipment
    {
        [Key]
        public int EquipmentID;

        [Display(Name = "Equipment Description")]
        public string Description;
    }
}