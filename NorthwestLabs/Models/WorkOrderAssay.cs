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
        public virtual Compound Compound { get; set; }

        [Display(Name = "AssayReport")]
        public Byte[] AssayReport { get; set; }

        [Display(Name = "QuantityInMilligrams")]
        [Required(ErrorMessage = "This field is required")]
        public decimal QuantityInMilligrams { get; set; }

        [Display(Name = "Weight")]
        [Required(ErrorMessage = "This field is required")]
        public decimal Weight { get; set; }

        [Display(Name = "DateArrived")]
        [Required(ErrorMessage = "This field is required")]
        public string DateArrived { get; set; }

        [Display(Name = "ReceivedBy")]
        [Required(ErrorMessage = "This field is required")]
        public string ReceivedBy { get; set; }

        [Display(Name = "Appearance")]
        [Required(ErrorMessage = "This field is required")]
        public Byte[] Appearance { get; set; }

        [Display(Name = "MolecularMass")]
        [Required(ErrorMessage = "This field is required")]
        public int MolecularMass { get; set; }
    }
}