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
using Microsoft.VisualBasic;
using ChapooLogic;

namespace ChapooUI
{
    public partial class pnlRegisterOrder : UserControl
    {
        RestaurantMenuOrder menuOrder = new RestaurantMenuOrder();
        RegisterOrder registerOrder = new RegisterOrder();
        TableLogic tableService = new TableLogic();
        OrderLogic logic = new OrderLogic();
        Table currentTable;
        Employee currentEmployee;
        Button button;

        ListViewItem selectedItemMenuList;
        ListViewItem cloneItem;
        string comment = "";

        public pnlRegisterOrder(Table table, Employee employee, Button button)
        {
            InitializeComponent();
            ShowDishes();
            tabControlDiner.Hide();
            tabControlDrinks.Hide();
            currentTable = table;
            currentEmployee = employee;
            if (currentTable.Free)
                btnRegisterChangeState.Text = "Set occu";
            else
                btnRegisterChangeState.Text = "Set free";
            this.button = button;
        }

        private void btnRegisterChangeState_Click(object sender, EventArgs e)
        {
            List<Table> tableList = tableService.GetTables();

            try
            {
                if (currentTable.Free)
                {
                    currentTable.Free = false;
                    tableService.ChangeState(currentTable, false);
                    btnRegisterChangeState.Text = "Set free";
                    button.Image = Image.FromFile(@"..\..\Tables\table" + currentTable.TableId.ToString() + "occupied.png");
                    Show();
                    menuOrder.OrderId++;
                }
                else if (!currentTable.Free)
                {
                    currentTable.Free = true;
                    tableService.ChangeState(currentTable, true);
                    btnRegisterChangeState.Text = "Set occu";
                    button.Image = Image.FromFile(@"..\..\Tables\table" + currentTable.TableId.ToString() + "free.png");
                    Show();
                }
            }
            catch
            {
                MessageBox.Show("Table not found", "Error");
            }
        }

        private void ShowDishes()
        {
            // Fill list with all Menu Items in database
            List<RestaurantMenuItem> allMenuItems = logic.GetItems();

            //Remove Diner and Drinks form LunchList and add them to according lists
            foreach (RestaurantMenuItem menuItem in allMenuItems)
            {
                if (menuItem.Category == "Lunch")
                {
                    registerOrder.listLunch.Add(menuItem);
                }
                else if (menuItem.Category == "Diner")
                {
                    registerOrder.listDiner.Add(menuItem);
                }
                else if (menuItem.Category == "Drink")
                {
                    registerOrder.listDrinks.Add(menuItem);
                }
            }
            PrintItems();
        }
        
        private void PrintItems()
        {
            // Display dishes on Listviews in Lunch tab
            foreach (RestaurantMenuItem item in registerOrder.listLunch)
            {
                switch (item.SubCategory)
                {
                    case "Starters":
                        AddItems(listViewLunchStarters, item);
                        break;
                    case "Main dishes":
                        AddItems(listViewLunchDishes, item);
                        break;
                    case "Dessert":
                        AddItems(listViewLunchDessert, item);
                        break;
                }
            }
            // Display dishes on Listviews in Dish tab
            foreach (RestaurantMenuItem item in registerOrder.listDiner)
            {
                switch (item.SubCategory)
                {
                    case "Starters":
                        AddItems(listViewDinerStarters, item);
                        break;
                    case "Second courses":
                        AddItems(listViewDinerSecondCourse, item);
                        break;
                    case "Main dishes":
                        AddItems(listViewDinerDishes, item);
                        break;
                    case "Desserts":
                        AddItems(listViewDinerDessert, item);
                        break;
                }
            }
            // Display dishes on Listviews in Drinks tab
            foreach (RestaurantMenuItem item in registerOrder.listDrinks)
            {
                switch (item.SubCategory)
                {
                    case "Soda":
                        AddItems(listViewDrinksSoda, item);
                        break;
                    case "Beers on tap":
                        AddItems(listViewDrinksBeers, item);
                        break;
                    case "Wines":
                        AddItems(listViewDrinksWines, item);
                        break;
                    case "Spirits":
                        AddItems(listViewDrinksSpirits, item);
                        break;
                    case "Coffee / tea":
                        AddItems(listViewDrinksCoffeeTea, item);
                        break;
                }
            }
        }

        private void AddItems(ListView listView, RestaurantMenuItem item)
        {
            ListViewItem liStarters = new ListViewItem(item.Name);
            liStarters.SubItems.Add(item.Price.ToString("c"));
            listView.Items.Add(liStarters);
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            // hide and show according panels
            tabControlDiner.Hide();
            tabControlDrinks.Hide();
            tabControlLunch.Show();
        }

        private void btnDiner_Click(object sender, EventArgs e)
        {
            // hide and show according panels
            tabControlLunch.Hide();
            tabControlDrinks.Hide();
            tabControlDiner.Show();
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            // hide and show according panels
            tabControlLunch.Hide();
            tabControlDiner.Hide();
            tabControlDrinks.Show();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            //Hide();
            pnlCheckOut pnlCheckout = new pnlCheckOut(currentTable, button, this, currentEmployee);
            Controls.Add(pnlCheckout);
            pnlCheckout.BringToFront();
            pnlCheckout.Show();
        }

        private void btnTables_Click(object sender, EventArgs e)
        {
            // hide current registerOrder panel and show tables panel
            Hide();
            pnlTables pnlTable = new pnlTables(currentEmployee);
            pnlTable.Show();
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewCurrentOrder.Items)
            {
                // add remaning RestaurantMenuOrder data in order to upload
                menuOrder.Name = item.Text;
                // get Id from item name
                RestaurantMenuItem currentItem = logic.GetInfo(menuOrder.Name);
                menuOrder.Id = currentItem.MenuItemId;
                menuOrder.ActiveUser = currentEmployee.employeeId;
                menuOrder.TimeOfOrder = DateTime.Now;
                menuOrder.Count = int.Parse(item.SubItems[2].Text);
                menuOrder.TableId = currentTable.TableId;
                menuOrder.OrderId = currentTable.OrderId;

                // write current order to order table
                logic.InsertOrder(menuOrder);
            }

            // because an order has been placed, set availability to occupied
            tableService.ChangeState(currentTable, false);
            button.Image = Image.FromFile(@"..\..\Tables\table" + currentTable.TableId.ToString() + "occupied.png");
            Show();

            MessageBox.Show("Order succesfully placed. Order: " + menuOrder.OrderId, "Success", MessageBoxButtons.OK);
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewCurrentOrder.Items)
            {
                listViewCurrentOrder.Items.Remove(item);
            }
            tbOrderComment.Clear();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            // add selected item into the order listview
            try
            {
                // clone selected item to use it
                cloneItem = (ListViewItem)selectedItemMenuList.Clone();

                // check if listView contains cloned item
                List<ListViewItem> itemList = new List<ListViewItem>();
                foreach (ListViewItem item in listViewCurrentOrder.Items)
                {
                    itemList.Add(item);
                }

                // if it contains the cloned item, change the text of third (count) column to the amount set (amount ups for each click)
                bool truefalse = false;
                foreach (ListViewItem item in itemList)
                {
                    if (item.Text == cloneItem.Text)
                    {
                        int nextValue = int.Parse(item.SubItems[2].Text) + 1;
                        item.SubItems[2].Text = nextValue.ToString();
                        truefalse = true;
                    }
                }

                if (!truefalse)
                {
                    ListViewItem clonedClonedItem = (ListViewItem)cloneItem.Clone();
                    clonedClonedItem.SubItems.Add(1.ToString());
                    listViewCurrentOrder.Items.Add(clonedClonedItem);
                }
            }
            catch
            {
                MessageBox.Show("No item selected", "Warning", MessageBoxButtons.OK);
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (listViewCurrentOrder.SelectedItems.Count == 0)
                return;

            ListViewItem selectedItemCompleteOrder = listViewCurrentOrder.SelectedItems[0];

            // remove 1 count from selected item
            int newNumber = int.Parse(selectedItemCompleteOrder.SubItems[2].Text) - 1;
            if (newNumber > 0)
            {
                selectedItemCompleteOrder.SubItems[2].Text = newNumber.ToString();
            }
            // if count now = 0, remove entire item
            else
            {
                listViewCurrentOrder.Items.Remove(selectedItemCompleteOrder);
            }
        }

        private void BtnComment_Click(object sender, EventArgs e)
        {
            // add comment to currently selected menuItem
            // C# doesn't have an input box function for MessageBox.Show, so I'm using a Visual basic reference and the Interaction.InputBox method
            comment += Interaction.InputBox("Add a comment to item: ", "Comment", "", -1, -1) + " - ";
            menuOrder.Comment = comment;
            tbOrderComment.Text = comment;
        }

        private void ListViewLunchStarters_MouseClick(object sender, MouseEventArgs e)
        {
            // make currently selected item the object in use
            selectedItemMenuList = listViewLunchStarters.SelectedItems[0];
        }

        private void ListViewLunchDishes_MouseClick(object sender, MouseEventArgs e)
        {
            // make currently selected item the object in use
            selectedItemMenuList = listViewLunchDishes.SelectedItems[0];
        }

        private void ListViewLunchDessert_MouseClick(object sender, MouseEventArgs e)
        {
            // make currently selected item the object in use
            selectedItemMenuList = listViewLunchDessert.SelectedItems[0];
        }

        private void ListViewDinerStarters_MouseClick(object sender, MouseEventArgs e)
        {
            // make currently selected item the object in use
            selectedItemMenuList = listViewDinerStarters.SelectedItems[0];
        }

        private void ListViewDinerSecondCourse_MouseClick(object sender, MouseEventArgs e)
        {
            // make currently selected item the object in use
            selectedItemMenuList = listViewDinerSecondCourse.SelectedItems[0];
        }

        private void ListViewDinerDishes_MouseClick(object sender, MouseEventArgs e)
        {
            // make currently selected item the object in use
            selectedItemMenuList = listViewDinerDishes.SelectedItems[0];
        }

        private void ListViewDinerDessert_MouseClick(object sender, MouseEventArgs e)
        {
            // make currently selected item the object in use
            selectedItemMenuList = listViewDinerDessert.SelectedItems[0];
        }

        private void listViewDrinksSoda_MouseClick(object sender, MouseEventArgs e)
        {
            // make currently selected item the object in use
            selectedItemMenuList = listViewDrinksSoda.SelectedItems[0];
        }

        private void ListViewDrinksBeers_MouseClick(object sender, MouseEventArgs e)
        {
            // make currently selected item the object in use
            selectedItemMenuList = listViewDrinksBeers.SelectedItems[0];
        }

        private void ListViewDrinksWines_MouseClick(object sender, MouseEventArgs e)
        {
            // make currently selected item the object in use
            selectedItemMenuList = listViewDrinksWines.SelectedItems[0];
        }

        private void ListViewDrinksSpirits_MouseClick(object sender, MouseEventArgs e)
        {
            // make currently selected item the object in use
            selectedItemMenuList = listViewDrinksSpirits.SelectedItems[0];
        }

        private void ListViewDrinksCoffeeTea_MouseClick(object sender, MouseEventArgs e)
        {
            // make currently selected item the object in use
            selectedItemMenuList = listViewDrinksCoffeeTea.SelectedItems[0];
        }
    }
}