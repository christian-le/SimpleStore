using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleStore.Infrastructure.Entities
{
    public class OrderDetail : BaseEntity
    {
        public int ProductId { get; set; }
        public decimal Quantity { get; set; }

    }
}
