using SimpleStore.Infrastructure.Entities;
using System.Collections.Generic;

namespace SimpleStore.Models
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
