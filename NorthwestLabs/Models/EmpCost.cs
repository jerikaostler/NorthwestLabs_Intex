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
        public virtual int EmpID { get; set; }
        public virtual Employee Employee { get; set; }


        [ForeignKey("WorkOrderTest")]
        [Display(Name = "WorkOrderTestID")]
        public virtual int WorkOrderTestID { get; set; }
        public virtual WorkOrderTest WorkOrderTest { get; set; }

        [Display(Name = "HoursWorked")]
        [Required(ErrorMessage = "This field is required")]
        public decimal HoursWorked { get; set; }

    }
}