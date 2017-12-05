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
        public int PaymentID;

        [Display(Name = "Payment Type")]
        [Required]
        public string PaymentType;

        [Display(Name = "Bank Account Number")]
        public string BankAcctNum;

        [Display(Name = "Routing Number")]
        public string RoutingNumber;

        [Display(Name = "Credit Card Number")]
        public string CardNumber;

        [Display(Name = "NameOnCard")]
        public string NameOnCard;


        [ForeignKey("Customer")]
        public int CustomerID;

    }
}