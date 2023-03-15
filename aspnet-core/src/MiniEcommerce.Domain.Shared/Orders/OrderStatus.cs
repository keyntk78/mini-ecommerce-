using System;
using System.Collections.Generic;
using System.Text;

namespace MiniEcommerce.Orders
{
    public enum OrderStatus
    {
        New,
        Confirmed,
        Processing,
        Shipping,
        Finished,
        Canceled
    }
}
