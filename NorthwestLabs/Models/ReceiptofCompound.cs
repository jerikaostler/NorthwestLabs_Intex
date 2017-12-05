using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("ReceiptofCompound")]
    public class ReceiptofCompound
    {
        [Key]
        [Display(Name ="ReceiptID")]
        public int ReceiptID { get; set; }

        [Display(Name ="DateArrived")]
        [Required(ErrorMessage ="This field is required")]
        public string DateArrived { get; set; }

        [Display(Name = "DateArrived")]
        [Required(ErrorMessage = "This field is required")]
        public string ReceivedBy { get; set; }

        [ForeignKey("Compound")]
        [Display(Name = "LT")]
        public int LT { get; set; }

        [ForeignKey("Compound")]
        [Display(Name = "SequenceCode")]
        public int SequenceCode { get; set; }
    }
}