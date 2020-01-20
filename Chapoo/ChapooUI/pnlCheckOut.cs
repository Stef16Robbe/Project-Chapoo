using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapooLogic;
using ChapooModel;

namespace ChapooUI
{
    public partial class pnlCheckOut : UserControl
    {
        CheckOutLogic CheckOutLogic = new CheckOutLogic();
        pnlRegisterOrder pnlRegisterOrder;
        Table table;
        List<OrderItem> orderItems;
        Employee employee;
        Button button;
        float orderCost = 0;
        float tipAmount;
        float totalCost;

        public pnlCheckOut(Table table, Button button, pnlRegisterOrder pnlRegisterOrder, Employee employee)
        {
            this.employee = employee;
            this.table = table;
            InitializeComponent();
            lbl_Table.Text = "Order table " + table.TableId;
            GetOrderData(table);
            this.button = button;
            this.pnlRegisterOrder = pnlRegisterOrder;
        }

        private void GetOrderData(Table table)
        {
            orderItems = CheckOutLogic.GetOrderItemsByOrderID(table);
            FillListView(orderItems);
            orderCost = 0;
            foreach (var item in orderItems)
            {
                orderCost += (float)item.Price * item.Quantity;
            }
            totalCost = orderCost;
            lbl_BillInvullen.Text = orderCost.ToString("c");
            lbl_TotalInvullen.Text = orderCost.ToString("c");
            lbl_VATinvullen.Text = (orderCost * 0.06).ToString("c");
        }

        private void FillListView(List<OrderItem> items)
        {
            // clear the listview before filling it again
            listViewOrder.Items.Clear();

            foreach (OrderItem o in items)
            {
                string[] orderItemData = new string[]{
                        o.Quantity.ToString(),
                        o.Name,
                        o.Price.ToString("c"),
                        (o.Price * o.Quantity).ToString("c")
                    };
                ListViewItem li = new ListViewItem(orderItemData);
                listViewOrder.Items.Add(li);
            }
        }

        private void Order()
        {
            Paycheck paycheck = new Paycheck();
            paycheck.table = table;
            paycheck.totalCost = totalCost;
            paycheck.orderCost = orderCost;
            paycheck.tipAmount = tipAmount;

            //run querry to update the order value
            CheckOutLogic.UpdateOrder(paycheck);
            Hide();
        }

        private void bttn_Cash_Click(object sender, EventArgs e)
        {
            Pay();
        }

        private void bttn_Pin_Click(object sender, EventArgs e)
        {
            Pay();
        }

        private void Pay()
        {
            if (listViewOrder.Items.Count > 0)
            {
                Order();
                ChangeState();
                MessageBox.Show("Payment successful", "Succesful", MessageBoxButtons.OK);
                table.Free = true;
                pnlRegisterOrder.Hide();
            }
            else
            {
                MessageBox.Show("Table does not have unpaid orders", "Warning", MessageBoxButtons.OK);
            }
        }

        private void btnBackToOrders_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void ChangeState()
        {
            TableLogic tableLogic = new TableLogic();
            tableLogic.ChangeState(table, true);
            button.Image = Image.FromFile(@"..\..\Tables\table" + table.TableId.ToString() + "free.png");
        }

        private void txtbox_Tip_TextChanged(object sender, EventArgs e)
        {
            if (txtbox_Tip.Text != "")
            {
                tipAmount = float.Parse(txtbox_Tip.Text);
                totalCost = orderCost + tipAmount;
                lbl_TotalInvullen.Text = (orderCost + tipAmount).ToString("c");
            }
            else
            {
                lbl_TotalInvullen.Text = orderCost.ToString("c");
            }
        }
    }
}

