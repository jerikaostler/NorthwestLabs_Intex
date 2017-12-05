using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("WorkOrderAssay")]
    public class WorkOrderAssay
    {
        [Key]
        [Display(Name ="WorkOrderAssayID")]
        public int WorkOrderAssayID { get; set; }

        [ForeignKey("WorkOrder")]
        [Display(Name = "WorkOrderID")]
        public int WorkOrderID { get; set; }

        [ForeignKey("Assay")]
        [Display(Name = "AssayID")]
        public int AssayID { get; set; }

        [ForeignKey("Compound")]
        [Display(Name = "LT")]
        public int LT { get; set; }

        [ForeignKey("Compound")]
        [Display(Name = "SequenceCode")]
        public int SequenceCode { get; set; }

        [Display(Name = "AssayReport")]
        public Byte[] AssayReport { get; set; }


    }
}