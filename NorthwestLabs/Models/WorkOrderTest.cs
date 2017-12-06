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
        public virtual int WorkOrderAssayID { get; set; }
        public virtual WorkOrderAssay WorkOrderAssay { get; set; }

        [ForeignKey("Test")]
        public virtual int TestID { get; set; }
        public virtual Test Test { get; set; }

        [ForeignKey("Status")]
        public virtual int StatusID { get; set; }
        public virtual Status Status { get; set; }

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