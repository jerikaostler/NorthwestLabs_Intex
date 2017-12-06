using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("WorkOrderTest")]
    public class WorkOrderTest
    {
        [Key]
        public int WorkOrderTestID { get; set; }

        [ForeignKey("WorkOrderAssay")]
        public int WorkOrderAssayID { get; set; }

        [ForeignKey("Test")]
        public int TestID { get; set; }

        [ForeignKey("Status")]
        public int StatusID { get; set; }

        [Display(Name = "Test Result")]
        public string TestResult { get; set; }

        [Display(Name = "Sample Concentration")]
        public decimal SampleConcentration { get; set; }

        [Display(Name = "Customer Approval")]
        public bool CustomerApproval { get; set; }

        [Display(Name = "Raw Data")]
        public Byte[] RawDataResult { get; set; }
    }
}