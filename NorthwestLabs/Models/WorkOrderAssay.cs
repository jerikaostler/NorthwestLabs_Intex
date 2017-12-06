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
        [Display(Name = "WorkOrderAssayID")]
        public int WorkOrderAssayID { get; set; }

        [Display(Name = "AssayReport")]
        public Byte[] AssayReport { get; set; }

        [ForeignKey("WorkOrder")]
        [Display(Name = "WorkOrderID")]
        public virtual int WorkOrderID { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }

        [ForeignKey("Assay")]
        [Display(Name = "AssayID")]
        public virtual int AssayID { get; set; }
        public virtual Assay Assay { get; set; }

        [ForeignKey("Compound")]
        [Display(Name = "LT")]
        public virtual int LT { get; set; }

        [ForeignKey("Compound")]
        [Display(Name = "SequenceCode")]
        public virtual int SequenceCode { get; set; }

        public virtual Compound Compound { get; set; }
    }
}