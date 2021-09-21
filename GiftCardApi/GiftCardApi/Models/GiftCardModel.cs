using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GiftCardApi.Models
{
    public class GiftCardModel
    {
        [Key]
        [Required]
        public int GiftCardId { get; set; }
        [Required]
        public string BuyerName { get; set; }
        [Required]
        public string RecipientName { get; set; }
        [Required]
        public string ShippingAddress { get; set; }
        [Required]
        public string StreetAddress { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string PinCode { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Occasion { get; set; }
        [Required]
        public double Amount { get; set; }
        [Required]
        public string Phone { get; set; }
    }
}
