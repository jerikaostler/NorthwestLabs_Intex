using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("EmpCost")]
    public class EmpCost
    {
        [Key]
        [Display(Name ="EmpCostID")]
        public int EmpCostID { get; set; }

        [ForeignKey("Employee")]
        [Display(Name = "EmployeeID")]
        public string EmployeeID { get; set; }

        [ForeignKey("WorkOrderTest")]
        [Display(Name = "WorkOrderTestID")]
        public string WorkOrderTestID { get; set; }

        [Display(Name = "HoursWorked")]
        [Required(ErrorMessage = "This field is required")]
        public string HoursWorked { get; set; }

    }
}