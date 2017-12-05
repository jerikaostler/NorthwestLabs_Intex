using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        [Display(Name = "UserName")]
        public string UserName;

        [Required]
        [Display(Name = "Password")]
        public string Password;

        [ForeignKey("Customer")]
        public int CustomerID;

        [ForeignKey("Employee")]
        public int EmpID;

    }
}