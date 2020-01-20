using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class RegisterOrder
    {
        public List<RestaurantMenuItem> listLunch;
        public List<RestaurantMenuItem> listDiner;
        public List<RestaurantMenuItem> listDrinks;

        private int orderId;
        private bool available;
        private string comment;
        private DateTime timeOfOrder;

        public RegisterOrder()
        {
            listLunch = new List<RestaurantMenuItem>();
            listDiner = new List<RestaurantMenuItem>();
            listDrinks = new List<RestaurantMenuItem>();
        }

        public RegisterOrder(int orderId)
        {
            listLunch = new List<RestaurantMenuItem>();
            listDiner = new List<RestaurantMenuItem>();
            listDrinks = new List<RestaurantMenuItem>();
            this.orderId = orderId;
            timeOfOrder = DateTime.Now;
        }
    }
}