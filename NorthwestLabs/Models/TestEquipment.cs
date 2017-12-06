using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("TestEquipment")]
    public class TestEquipment
    {
        [ForeignKey("Test")]
        public virtual int TestID { get; set; }
        public virtual Test Test { get; set; }

        [ForeignKey("Equipment")]
        public virtual int EquipmentID { get; set; }
        public virtual Equipment Equipment { get; set; }

        [Key]
        public int TestEquipmentID { get; set; }


    }
}