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
        public int EmpID;

        [Display(Name = "Last Name")]
        public string EmpFirstName;

        [Display(Name = "First Name")]
        public string EmpLastName;

        [Display(Name = "Hourly Wage")]
        public decimal HourlyWage;

        [Display(Name = "Employee Type")]
        public string Type;

        [Display(Name = "OfficeID")]
        [ForeignKey("NorthWestOffices")]
        public int OfficeID;

    }
}