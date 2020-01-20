using ChapooDAL;
using ChapooModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapooLogic
{
    public class OrderLogic
    {
        OrderDAO orderDao = new OrderDAO();

        public List<RestaurantMenuItem> GetItems()
        {
            return orderDao.Db_Get_All_RestaurantMenuItems();
        }

        public RestaurantMenuItem GetInfo(string name)
        {
            return orderDao.Db_Get_All_Info(name);
        }

        public void InsertOrder(RestaurantMenuOrder menuOrder)
        {
            orderDao.InsertOrder(menuOrder);
        }

        public List<RestaurantMenuOrder> GetOrdersFromTable(Table table)
        {
            return orderDao.GetOrdersFromTable(table);
        }

        public void ChangeToDone(Table table)
        {
            orderDao.ChangeToDone(table);
        }

        public List<RestaurantMenuOrderItem> GetDishes()
        {
            List<RestaurantMenuOrderItem> dishes;
            dishes = orderDao.GetDishes();
            return dishes;
        }

        public List<RestaurantMenuOrderItem> GetDrinks()
        {
            List<RestaurantMenuOrderItem> drinks;
            drinks = orderDao.GetDrinks();
            return drinks;
        }

        public bool SetOrderReady(int orderId, bool employee)
        {
            if (orderDao.SetMenuorderReady(orderId, employee))
                return true;
            return false;
        }
    }
}