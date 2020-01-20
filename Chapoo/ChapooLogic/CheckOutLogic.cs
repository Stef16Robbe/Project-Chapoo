using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooDAL;
using ChapooModel;

namespace ChapooLogic
{
    public class CheckOutLogic
    {
        OrderDAO order_db = new OrderDAO();

        public List<OrderItem> GetOrderItemsByOrderID(Table table)
        {
            return order_db.GetOrders(table);
        }

        public void UpdateOrder(Paycheck paycheck)
        {
            order_db.UpdateOrder(paycheck);
        }
    }
}
