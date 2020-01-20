using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapooModel;
using ChapooLogic;

namespace ChapooUI
{
    public partial class pnlBarKitchenControl : UserControl
    {
        OrderLogic orderLogic;
        int currentPageNumber;
        int pageCount;
        Employee employee;
        List<int> TicketsForCurrentPage = new List<int>();

        public pnlBarKitchenControl(Employee employee)
        {
            // employee object for checking if the employee is a bar or kitchen employee
            InitializeComponent();
            orderLogic = new OrderLogic();
            this.employee = employee;
            currentPageNumber = 0;
            LoadMenuOrders();
        }
        private void LoadMenuOrders()
        {
            //filters all the menuorders up to six menuorder lists per page, so loads one page.
            List<RestaurantMenuOrderItem> menuOrders = new List<RestaurantMenuOrderItem>();
            ClearAllListviews();
            try
            {
                if (employee.role == 1)
                {
                    menuOrders = orderLogic.GetDishes();
                }
                else if (employee.role == 2)
                {
                    menuOrders = orderLogic.GetDrinks();
                }
            }
            catch
            {
                MessageBox.Show("Can't load open orders.");
            }
            int nextPageCount = 0;
            int orderIdCounter = 0;
            int previousOrderId = 0;
            foreach (RestaurantMenuOrderItem restaurantMenuOrderItem in menuOrders)
            {
                if (orderIdCounter % 6 == 0 && orderIdCounter != 0 && orderIdCounter != 7)
                {
                    nextPageCount++;
                }
                if (previousOrderId != restaurantMenuOrderItem.orderId)
                {
                    orderIdCounter++;
                    previousOrderId = restaurantMenuOrderItem.orderId;
                }
            }
            pageCount = (int)Math.Ceiling(orderIdCounter / 6.0);
            List<Page> pages = new List<Page>();
            //make a Page object to make a list of a list of RestaurantMenuOrderItems for separating the list in lists with the same orderId.
            for (int i = 0; i < pageCount + 1; i++)
            {
                Page page = new Page();
                pages.Add(page);
            }
            nextPageCount = 0;
            orderIdCounter = 0;
            previousOrderId = 0;
            foreach (RestaurantMenuOrderItem restaurantMenuOrderItem in menuOrders)
            {
                pages[nextPageCount].pageItems.Add(restaurantMenuOrderItem);
                if (orderIdCounter % 5 == 0 && orderIdCounter != 0)//or if the seventh order contains more menuitems, than the orderidcounter stays on 6, so it can't add a nextPageCount.
                {
                    nextPageCount++;
                }
                if (previousOrderId != restaurantMenuOrderItem.orderId || orderIdCounter == 5 || orderIdCounter == 11 || orderIdCounter == 17)
                {
                    orderIdCounter++;
                }
                previousOrderId = restaurantMenuOrderItem.orderId;
            }
            //check how many unique orderId's the list contains
            TicketsForCurrentPage.Clear();
            try
            {
                foreach (RestaurantMenuOrderItem restaurantMenuOrder in pages[currentPageNumber].pageItems)
                {
                    if (!TicketsForCurrentPage.Contains(restaurantMenuOrder.orderId))
                    {
                        TicketsForCurrentPage.Add(restaurantMenuOrder.orderId);
                    }
                }
                LoadMenuOrdersForOnePage(pages[currentPageNumber].pageItems);
            }
            catch
            {
                MessageBox.Show("there are no open orders!");
            }
        }
        private void ClearAllListviews()
        {
            var listviews = new[] { ListK1, ListK2, ListK3, ListK4, ListK5, ListK6 };
            foreach (ListView listview in listviews)
            {
                listview.Items.Clear();
                listview.Columns[0].Text = "";
                listview.Columns[1].Text = "";
                listview.Columns[2].Text = "";
            }
        }
        private void LoadMenuOrdersForOnePage(List<RestaurantMenuOrderItem> allOrders)
        {
            //so minimal 1 list of orders, maximum 6 bundled in one, extracting here by orderId!
            //making a variable listviews for easy calling to the number of listview on a page.
            //here sorting the Id for one listview, it is sorted in the query by date!
            var listviews = new[] { ListK1, ListK2, ListK3, ListK4, ListK5, ListK6 };

            //fill another list with only the RestaurantMenuOrders for this particular listview.
            //it is sorted by the query on orderId and then timeOfOrder, now I need to split the list in menuitems of one orderId for all menuitems of one table.
            List<int> existingNumbers = new List<int>();
            int counter = 0;
            try
            {
                existingNumbers.Add(allOrders[0].orderId);
            }
            catch
            {
                try
                {
                    currentPageNumber--;
                }
                catch
                {
                    MessageBox.Show("no open orders.");
                }
            }
            foreach (RestaurantMenuOrderItem menuOrder in allOrders)
            {
                if (existingNumbers.Contains(menuOrder.orderId))
                {
                    FillListItemForOneListview(menuOrder, listviews[counter]);
                }
                else
                {
                    existingNumbers.Add(menuOrder.orderId);
                    counter++;
                    FillListItemForOneListview(menuOrder, listviews[counter]);
                }
            }
        }
        private void FillListItemForOneListview(RestaurantMenuOrderItem menuOrder, ListView listview)
        {
            //TicketsForCurrentPage.Add(menuOrder.orderId);
            listview.Columns[0].Text = $"Ticket #{menuOrder.orderId}";
            listview.Columns[1].Text = menuOrder.dateOfOrder.ToString("HH:mm");
            listview.Columns[2].Text = $"t {menuOrder.Table.ToString()}";
            //fill the rest of a listview with all the menuitems of a menuorder.
            ListViewItem item = new ListViewItem(menuOrder.Name);
            item.SubItems.Add($"{menuOrder.Count.ToString()}x");
            listview.Items.Add(item);
        }
        private void BumpItem(int orderId)
        {
            try
            {
                if (employee.role == 1)
                {
                    orderLogic.SetOrderReady(orderId, true);
                }
                else
                {
                    orderLogic.SetOrderReady(orderId, false);
                }
            }
            catch
            {
                MessageBox.Show("Item can't be bumped right now. Maybe it is already bumped?");
            }
            LoadMenuOrders();
        }
        private void NextPage()
        {
            //if the currentpagenumber is at the last page, go to the next page
            if (currentPageNumber == pageCount - 1)
            {
                currentPageNumber = 0;
            }
            else
            {
                currentPageNumber++;
            }
            LoadMenuOrders();
        }
        private void PreviousPage()
        {
            //if the currentpagenumber is at the first page, go to the first page
            if (currentPageNumber == 0)
            {
                currentPageNumber = pageCount - 1;
            }
            else
            {
                currentPageNumber--;
            }
            LoadMenuOrders();
        }
        private void btnKRefresh_Click(object sender, EventArgs e)
        {
            LoadMenuOrders();
        }
        private void btnKPrevious_Click(object sender, EventArgs e)
        {
            PreviousPage();
        }
        private void btnKNext_Click(object sender, EventArgs e)
        {
            NextPage();
        }
        private void KBump1_Click(object sender, EventArgs e)
        {
            //for each Bump button get the text from first columnheader, get the digits from that and bump the item via the Logic layer.
            try
            {
                BumpItem(TicketsForCurrentPage[0]);
            }
            catch
            {
                MessageBox.Show("Can't bump an empty item.");
            }
            LoadMenuOrders();
        }
        private void KBump2_Click(object sender, EventArgs e)
        {
            try
            {
                BumpItem(TicketsForCurrentPage[1]);
            }
            catch
            {
                MessageBox.Show("Can't bump an empty item.");
            }
            LoadMenuOrders();
        }

        private void KBump3_Click(object sender, EventArgs e)
        {
            try
            {
                BumpItem(TicketsForCurrentPage[2]);
            }
            catch
            {
                MessageBox.Show("Can't bump an empty item.");
            }
            LoadMenuOrders();
        }

        private void KBump4_Click(object sender, EventArgs e)
        {
            try
            {
                BumpItem(TicketsForCurrentPage[3]);
            }
            catch
            {
                MessageBox.Show("Can't bump an empty item.");
            }
            LoadMenuOrders();
        }

        private void KBump5_Click(object sender, EventArgs e)
        {
            try
            {
                BumpItem(TicketsForCurrentPage[4]);
            }
            catch
            {
                MessageBox.Show("Can't bump an empty item.");
            }
            LoadMenuOrders();
        }

        private void KBump6_Click(object sender, EventArgs e)
        {
            try
            {
                BumpItem(TicketsForCurrentPage[5]);
            }
            catch
            {
                MessageBox.Show("Can't bump an empty item.");
            }
            LoadMenuOrders();
        }
    }
}
