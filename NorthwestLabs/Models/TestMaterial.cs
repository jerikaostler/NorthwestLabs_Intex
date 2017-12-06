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
        public virtual int TestID { get; set; }
        public virtual Test Test { get; set; }


        [ForeignKey("Material")]
        public virtual int MaterialID { get; set; }
        public virtual Material Material { get; set; }


        [Key]
        public int TestMaterialID { get; set; }
    }
}