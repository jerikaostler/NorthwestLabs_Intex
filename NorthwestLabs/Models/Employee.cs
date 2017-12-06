using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        [Display(Name = "EmpID")]
        public int EmpID { get; set; }

        [Display(Name = "Last Name")]
        public string EmpFirstName { get; set; }

        [Display(Name = "First Name")]
        public string EmpLastName { get; set; }

        [Display(Name = "Hourly Wage")]
        public decimal HourlyWage { get; set; }

        [Display(Name = "Employee Type")]
        public string Type { get; set; }

        [ForeignKey("NorthWestOffices")]
        [Display(Name = "OfficeID")]
        public virtual int OfficeID { get; set; }
        public virtual NorthWestOffices NorthWestOffices { get; set; }

    }
}