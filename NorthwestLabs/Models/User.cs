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
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [ForeignKey("Customer")]
        public virtual int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }

        [ForeignKey("Employee")]
        public virtual int EmpID { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
