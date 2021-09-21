using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GiftCardApi.Models.Dtos
{
    public class GiftCardReadDto
    {
        [Key]
        [Required]
        public int GiftCardId { get; set; }
        [Required]
        public string BuyerName { get; set; }
        [Required]
        public string ShippingAddress { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public double Amount { get; set; }
        [Required]
        public string Phone { get; set; }
    }
}
