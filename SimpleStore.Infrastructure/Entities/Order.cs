using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SimpleStore.Infrastructure.Entities
{
    public class Order : BaseEntity
    {
        public ICollection<OrderDetail> OrderDetails { get; set; }

        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the firt address line")]
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }

        [Required(ErrorMessage = "Please enter a city name")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please enter a state name")]
        public string State { get; set; }
        public string Zip { get; set; }
        [Required(ErrorMessage = "Please enter a country name")]
        public string Country { get; set; }
        public bool GiftWrap { get; set; }

        public string BuyerId { get; set; }
    }
}
