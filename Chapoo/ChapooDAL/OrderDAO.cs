using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using System.Configuration;
using ChapooModel;

namespace ChapooDAL
{
    public class OrderDAO : Base
    {
        public List<RestaurantMenuItem> Db_Get_All_RestaurantMenuItems()
        {
            string query = "SELECT menuItemId, price, name, category, vat, subCategory FROM MenuItems";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadItems(ExecuteSelectQuery(query));
        }

        private List<RestaurantMenuItem> ReadItems(DataTable dataTable)
        {
            List<RestaurantMenuItem> items = new List<RestaurantMenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                RestaurantMenuItem item = new RestaurantMenuItem()
                {
                    MenuItemId = (int)dr["menuItemId"],
                    Price = (double)dr["price"],
                    Name = (string)dr["name"],
                    Category = (string)dr["category"],
                    Vat = (bool)dr["vat"],
                    SubCategory = (string)dr["subCategory"]
                };
                items.Add(item);
            }
            return items;
        }

        public RestaurantMenuItem Db_Get_All_Info(string name)
        {
            string query = "SELECT menuItemId FROM MenuItems WHERE [name] LIKE '" + name + "'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadInfo(ExecuteSelectQuery(query));
        }

        private RestaurantMenuItem ReadInfo(DataTable dataTable)
        {
            RestaurantMenuItem item = new RestaurantMenuItem();

            foreach (DataRow dr in dataTable.Rows)
            {
                item.MenuItemId = (int)dr["menuItemId"];
            }
            return item;
        }

        public void InsertOrder(RestaurantMenuOrder menuOrder)
        {
            string query = "INSERT INTO MenuOrders([menuItemId], [orderId], [count], [commentary], [timeOfOrder], [employeeId], [menuOrderServed], [readyForServe], [tableId]) VALUES ('@menuItemId', '@orderId', '@count', '@commentary', '@timeOfOrder', '@employeeId', '@menuOrderServed', '@readyForServe', '@tableId')";
            query = query.Replace("@menuItemId", menuOrder.Id.ToString());
            query = query.Replace("@orderId", menuOrder.OrderId.ToString());
            query = query.Replace("@count", menuOrder.Count.ToString());
            query = query.Replace("@commentary", menuOrder.Comment);
            query = query.Replace("@timeOfOrder", menuOrder.TimeOfOrder.ToString());
            query = query.Replace("@employeeId", menuOrder.ActiveUser.ToString());
            query = query.Replace("@menuOrderServed", 0.ToString());
            query = query.Replace("@readyForServe", 0.ToString());
            query = query.Replace("@tableId", menuOrder.TableId.ToString());
            ExecuteEditQuery(query);
        }

        public List<OrderItem> GetOrders(Table table)
        {
            string query = "SELECT MO.[count], MI.[name], MI.[price] FROM MenuOrders AS MO INNER JOIN MenuItems AS MI ON MI.menuItemId = MO.menuItemId INNER JOIN Orders AS O ON O.orderId = MO.orderId WHERE MO.tableId = @tableId AND O.paymentStatus = 0";
            query = query.Replace("@tableId", table.TableId.ToString());
            List<OrderItem> orderItems = new List<OrderItem>();
            DataTable r = ExecuteSelectQuery(query);
            foreach (DataRow dr in r.Rows)
            {
                orderItems.Add(new OrderItem
                {
                    Quantity = (int)dr["count"],
                    Name = (string)dr["name"],
                    Price = (double)dr["price"],
                }
                );
            }
            return orderItems;
        }

        public void UpdateOrder(Paycheck paycheck)
        {
            string query = "UPDATE Orders SET tip = @tip, bill = @bill, totalPrice = @totalPrice, paymentStatus = 1  WHERE orderId = @OrderId";
            SqlParameter[] sqlParameters = new SqlParameter[]{
                new SqlParameter("tip", paycheck.tipAmount),
                new SqlParameter("bill", paycheck.orderCost),
                new SqlParameter("totalPrice", paycheck.totalCost),
                new SqlParameter("OrderId", paycheck.table.OrderId)
                };
            ExecuteEditQuery(query, sqlParameters);
        }

        public List<RestaurantMenuOrder> GetOrdersFromTable(Table table)
        {
            List<RestaurantMenuOrder> list = new List<RestaurantMenuOrder>();
            string query = "SELECT menuOrderId, menuItemId, orderId, [count], ISNULL(commentary, 'NO COMMENT') AS commentary, timeOfOrder, employeeId, menuOrderServed, readyForServe, tableId FROM MenuOrders WHERE tableId = @tableId";
            query = query.Replace("@tableId", table.TableId.ToString());
            DataTable r = ExecuteSelectQuery(query);
            foreach (DataRow dr in r.Rows)
            {
                RestaurantMenuOrder o = new RestaurantMenuOrder();
                o.Id = (int)dr["menuOrderId"];
                o.OrderId = (int)dr["orderId"];
                o.Comment = (string)dr["commentary"];
                o.Count = (int)dr["count"];
                o.ReadyForServe = (bool)dr["readyForServe"];
                o.MenuOrderServed = (bool)dr["menuOrderServed"];
                o.TimeOfOrder = (DateTime)dr["timeOfOrder"];
                o.ActiveUser = (int)dr["employeeId"];
                o.TableId = (int)dr["tableId"];
                list.Add(o);
            }
            return list;
        }

        public void ChangeToDone(Table table)
        {
            string query = "UPDATE MenuOrders SET menuOrderServed = 1 WHERE tableId = @tableId";
            query = query.Replace("@tableId", table.TableId.ToString());
            ExecuteEditQuery(query);
        }

        public List<RestaurantMenuOrderItem> GetDishes()
        {
            //get the Dish ID's by sorting the rows NOT on 'Drink'
            string query = "SELECT O.tableId, O.count, I.name, I.menuItemId, O.timeOfOrder, O.orderId FROM MenuOrders AS O JOIN MenuItems AS I ON O.menuItemId = I.menuItemId WHERE I.category NOT LIKE 'Drink' AND readyForServe = 0 ORDER BY O.orderId ASC";
            List<RestaurantMenuOrderItem> menuOrders = new List<RestaurantMenuOrderItem>();
            return ReadMenuOrder(ExecuteSelectQuery(query));
        }

        public List<RestaurantMenuOrderItem> GetDrinks()
        {
            //get the Drink ID's by sorting the rows on 'Drink'
            string query = "SELECT O.tableId, O.count, I.name, I.menuItemId, O.timeOfOrder, O.orderId FROM MenuOrders AS O JOIN MenuItems AS I ON O.menuItemId = I.menuItemId WHERE I.category LIKE 'Drink' AND readyForServe = 0 ORDER BY O.orderId ASC";
            List<RestaurantMenuOrderItem> ids = new List<RestaurantMenuOrderItem>();
            return ReadMenuOrder(ExecuteSelectQuery(query));
        }

        private List<RestaurantMenuOrderItem> ReadMenuOrder(DataTable dataTable)
        {
            //this method is needed by DbGetMenuOrderFromId for filling a list of restaurantmenuorder.
            List<RestaurantMenuOrderItem> RestaurantMenuOrders = new List<RestaurantMenuOrderItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                RestaurantMenuOrderItem RestaurantMenuOrder = new RestaurantMenuOrderItem()
                {
                    Table = (int)dr["tableId"],
                    Count = (int)dr["count"],
                    Name = (string)dr["name"],
                    dateOfOrder = (DateTime)dr["timeOfOrder"],
                    orderId = (int)dr["orderId"],
                };
                RestaurantMenuOrders.Add(RestaurantMenuOrder);
            }
            return RestaurantMenuOrders;
        }

        public bool SetMenuorderReady(int orderId, bool employee)
        {
            //if boolean is true, bump the dishes, if false bump the drinks.
            string query;
            if (employee)
            {
                //sorting the orderId by dishes: NOT LIKE 'Drink'
                query = "UPDATE O SET O.readyForServe = 1 FROM MenuOrders AS O  JOIN MenuItems AS I ON O.menuItemId = I.menuItemId WHERE I.category NOT LIKE 'Drink' AND orderId = @orderId";
            }
            else
            {
                //sorting the orderId by drinks: LIKE 'Drink'
                query = "UPDATE O SET O.readyForServe = 1 FROM MenuOrders AS O  JOIN MenuItems AS I ON O.menuItemId = I.menuItemId WHERE I.category LIKE 'Drink' AND orderId = @orderId";
            }
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@orderId", SqlDbType.Int) {Value = orderId},
            };
            try
            {
                ExecuteEditQuery(query, sqlParameters);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
