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
        public int TestID;

        [ForeignKey("Equipment")]
        public int EquipmentID;

        [Key]
        public int TestEquipmentID;


    }
}