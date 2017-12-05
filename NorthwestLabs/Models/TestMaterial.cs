using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("TestMaterial")]
    public class TestMaterial
    {
        [ForeignKey("Test")]
        public int TestID;

        [ForeignKey("Material")]
        public int MaterialID;

        [Key]
        public int TestMaterialID;
    }
}