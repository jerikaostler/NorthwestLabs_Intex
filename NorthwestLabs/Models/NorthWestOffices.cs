﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("NorthWestOffices")]
    public class NorthWestOffices
    {
        [Key]
        [Display(Name = "OfficeID")]
        public int OfficeID { get; set; }

        [Display(Name = "Office Description")]
        public string Description { get; set; }

        [Display(Name = "Office Location")]
        public string Location { get; set; } 

    }
}