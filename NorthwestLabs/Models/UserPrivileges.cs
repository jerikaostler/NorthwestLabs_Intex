using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("UserPrivileges")]
    public class UserPrivileges
    {
        [Key]
        public int UserPrivilegesID { get; set; }

        [ForeignKey("User")]
        [Display(Name = "UserName")]
        [Required]
        public string UserName { get; set; }

        [ForeignKey("Privilege")]
        [Display(Name = "PrivilegeID")]
        [Required]
        public virtual int PrivilegeID { get; set; }
        public virtual Privilege privilege { get; set; }
    }
}