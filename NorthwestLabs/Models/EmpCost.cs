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
        public virtual string EmployeeID { get; set; }
        public virtual Employee employee { get; set; }


        [ForeignKey("WorkOrderTest")]
        [Display(Name = "WorkOrderTestID")]
        public virtual string WorkOrderTestID { get; set; }
        public virtual WorkOrderTest workordertest { get; set; }

        [Display(Name = "HoursWorked")]
        [Required(ErrorMessage = "This field is required")]
        public string HoursWorked { get; set; }

    }
}