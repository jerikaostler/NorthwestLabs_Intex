using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Payment")]
    public class Payment
    {
        [Key]
        public int PaymentID { get; set; }

        [Display(Name = "Payment Type")]
        [Required]
        public string PaymentType { get; set; }

        [Display(Name = "Bank Account Number")]
        public string BankAcctNum { get; set; }

        [Display(Name = "Routing Number")]
        public string RoutingNumber { get; set; }

        [Display(Name = "Credit Card Number")]
        public string CardNumber { get; set; }

        [Display(Name = "NameOnCard")]
        public string NameOnCard { get; set; }


        [ForeignKey("Customer")]
        public virtual int CustomerID { get; set; }
        public virtual Customer customer { get; set; }

    }
}