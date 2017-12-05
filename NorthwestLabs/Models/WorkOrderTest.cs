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
        public int WorkOrderTestID;

        [ForeignKey("WorkOrderAssay")]
        public int WorkOrderAssayID;

        [ForeignKey("Test")]
        public int TestID;

        [ForeignKey("Status")]
        public int StatusID;

        [Display(Name = "Test Result")]
        public string TestResult;

        [Display(Name = "Sample Concentration")]
        public decimal SampleConcentration;

        [Display(Name = "Customer Approval")]
        public bool CustomerApproval;

        [Display(Name = "Raw Data")]
        public Byte[] RawDataResult;
    }
}