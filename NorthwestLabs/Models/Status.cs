using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Status")]
    public class Status
    {
        [Key]
        public int StatusID { get; set; }

        [Display(Name = "Status Description")]
        public string StatusDescription { get; set; }
    }
}