using NorthwestLabs.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Web;

namespace NorthwestLabs.DAL
{
    public class NorthWestLabsProductionContext : DbContext
    {
        public NorthWestLabsProductionContext() : base("NorthWestLabsProductionContext")
        {
        }

        public DbSet<Assay> assay { get; set; }
        public DbSet<Compound> compound { get; set; }
        public DbSet<Customer> customer { get; set; }
        public DbSet<EmpCost> empcost { get; set; }
        public DbSet<Employee> employee { get; set; }
        public DbSet<Equipment> equipment { get; set; }
        public DbSet<Material> material { get; set; }
        public DbSet<NorthWestOffices> northwestoffices { get; set; }
        public DbSet<Payment> payment { get; set; }
        public DbSet<Privilege> privilege { get; set; }
        public DbSet<ReceiptofCompound> receiptofcompound { get; set; }
        public DbSet<Status> status { get; set; }
        public DbSet<Test> test { get; set; }
        public DbSet<TestEquipment> testequipment { get; set; }
        public DbSet<TestMaterial> testmaterial { get; set; }
        public DbSet<User> user { get; set; }
        public DbSet<UserPrivileges> userprivileges { get; set; }
        public DbSet<WorkOrder> workorder { get; set; }
        public DbSet<WorkOrderAssay> workorderassay { get; set; }
        public DbSet<WorkOrderTest> workordertest { get; set; }



    }
}