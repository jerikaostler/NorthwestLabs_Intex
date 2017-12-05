using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("WorkOrder")]
    public class WorkOrder
    {
        [Key]
        [Display(Name ="WorkOrderID")]
        public int WorkOrderID { get; set; }

        [ForeignKey("Customer")]
        [Display(Name ="CustomerID")]
        public int CustomerID { get; set; }

        [Display(Name = "Comments")]
        public string Comments { get; set; }

        [Display(Name = "DueDate")]
        [Required(ErrorMessage = "This field is required")]
        public string DueDate { get; set; }

        [Display(Name = "Priority")]
        [Required(ErrorMessage = "This field is required")]
        public string Priority { get; set; }

        [Display(Name = "SummaryReport")]
        public Byte[] SummaryReport { get; set; }




    }
}