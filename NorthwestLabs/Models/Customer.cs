using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        [Display(Name = "customerID")]
        public int customerID { get; set; }

        [Display(Name = "CompanyName")]
        [Required(ErrorMessage = "This field is required")]
        public string CompanyName { get; set; }

        [Display(Name = "ContactFirstName")]
        [Required(ErrorMessage = "This field is required")]
        public string ContactFirstName { get; set; }

        [Display(Name = "ContactLastName")]
        [Required(ErrorMessage = "This field is required")]
        public string ContactLastName { get; set; }

        [Display(Name = "CustAddress")]
        [Required(ErrorMessage = "This field is required")]
        public string CustAddress { get; set; }

        [Display(Name = "CustCity")]
        [Required(ErrorMessage = "This field is required")]
        public string CustCity { get; set; }

        [Display(Name = "CustState")]
        [Required(ErrorMessage = "This field is required")]
        public string CustState { get; set; }

        [Display(Name = "CustCountry")]
        [Required(ErrorMessage = "This field is required")]
        public string CustCountry { get; set; }

        [Display(Name = "CustPhone")]
        [Required(ErrorMessage = "This field is required")]
        public string CustPhone { get; set; }

        [Display(Name = "CustEmail")]
        [Required(ErrorMessage = "This field is required")]
        public string CustEmail { get; set; }

        [Display(Name = "DiscountInfo")]
        [Required(ErrorMessage = "This field is required")]
        public string DiscountInfo { get; set; }

    }
}