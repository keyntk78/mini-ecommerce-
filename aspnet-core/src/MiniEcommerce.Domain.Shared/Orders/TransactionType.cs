using System;
using System.Collections.Generic;
using System.Text;

namespace MiniEcommerce.Orders
{
    public enum TransactionType
    {
        ConfirmOrder,
        StartProcessing,
        FinishOrder,
        CancelOrder
    }
}
