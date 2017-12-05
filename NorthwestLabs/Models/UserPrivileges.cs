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
        [ForeignKey("User")]
        [Display(Name = "UserName")]
        [Required]
        public string UserName;

        [ForeignKey("Privilege")]
        [Display(Name = "PrivilegeID")]
        [Required]
        public int PrivilegeID;

        [Key]
        public int UserPrivilegesID;
    }
}