using SimpleStore.Infrastructure.Entities;
using System.Collections.Generic;

namespace SimpleStore.Infrastructure.Services
{
    public interface IOrderDetailService
    {
        void SaveOrderDetails(IEnumerable<OrderDetail> entities);
    }
}
