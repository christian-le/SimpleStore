﻿using SimpleStore.Infrastructure.Models;

namespace SimpleStore.Models
{
    public class CartIndexViewModel
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}
