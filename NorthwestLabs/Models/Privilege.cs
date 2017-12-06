using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Privilege")]
    public class Privilege
    {
        [Key]
        [Display(Name = "PrivilegeID")]
        public int PrivilegeID { get; set; }

        [Display(Name = "Privilege Description")]
        public string Description { get; set; }

    }
}