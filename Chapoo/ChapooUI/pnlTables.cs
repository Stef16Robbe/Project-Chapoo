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
    public partial class pnlTables : UserControl
    {
        Employee employee;
        OrderLogic orderLogic = new OrderLogic();
        TableLogic tableLogic = new TableLogic();

        public pnlTables(Employee employee)
        {
            InitializeComponent();
            ShowTables();
            this.employee = employee;
        }

        public void ShowTables()
        {
            Controls.Clear();
            listViewTables.Hide();
            List<Table> tableList = tableLogic.GetTables();

            int x = 40;
            int y = 70;
            int yReady = 40;

            int number = 1;
            foreach (Table t in tableList)
            {
                if (number % 6 == 0)
                {
                    x = 40;
                    y += 320;
                    yReady += 600;
                }

                //Determine what image the button should have
                string tableNumber = t.TableId.ToString();
                string occupied;
                if (t.Free)
                {
                    occupied = "free";
                }
                else
                {
                    occupied = "occupied";
                }
                string image = "table" + tableNumber + occupied;

                //Button making
                Button b = new Button
                {
                    TabStop = false,
                    Name = "btnTable" + t.TableId.ToString(),
                    FlatStyle = FlatStyle.Flat,
                    Margin = new Padding(0),
                    TabIndex = 0,
                    Location = new Point(x, y),
                    Size = new Size(215, 250),
                    Image = Image.FromFile(@"..\..\Tables\" + image + ".png")
                };
                b.FlatAppearance.BorderSize = 0;
                b.Click += (s, e) =>
                {
                    if (t.Free)
                    {
                        GiveNewOrderId(t);
                    }
                    pnlRegisterOrder pnlRegisterOrder = new pnlRegisterOrder(t, employee, b);
                    tableLogic.ChangeState(t, false);
                    Controls.Add(pnlRegisterOrder);
                    pnlRegisterOrder.BringToFront();
                    pnlRegisterOrder.Show();
                };
                if (number % 6 == 0)
                {
                    x = 40;
                }
                Controls.Add(b);

                //Get table order info
                List<RestaurantMenuOrder> orders = orderLogic.GetOrdersFromTable(t);

                //Button Ready making
                Button bReady = new Button
                {
                    TabStop = false,
                    Name = "btnReady" + t.TableId.ToString(),
                    FlatStyle = FlatStyle.Flat,
                    Margin = new Padding(0),
                    TabIndex = 1,
                    Location = new Point(x, yReady),
                    Size = new Size(215, 30),
                };
                bool done = false;
                for (int i = 0; i < orders.Count; i++)
                {
                    if (!done)
                    {
                        if (orders[i].MenuOrderServed)
                        {
                                bReady.BackColor = Color.Transparent;
                        }
                        else
                        {
                            done = true;
                            if (orders[i].ReadyForServe)
                            {
                                bReady.BackColor = Color.LimeGreen;
                            }
                            else
                            {
                                bReady.BackColor = Color.Yellow;
                            }
                        }
                    }
                }
                bReady.FlatAppearance.BorderSize = 0;
                bReady.Click += (s, e) =>
                {
                    ChangeReadyButton(t, bReady);
                };

                Controls.Add(bReady);
                x += 240;
                number++;
            }
            pnlTable.Hide();
        }

        private void ChangeReadyButton(Table table, Button button)
        {
            if (button.BackColor == Color.LimeGreen)
            {
                button.BackColor = Color.Transparent;
                orderLogic.ChangeToDone(table);
            }
        }

        private void GiveNewOrderId(Table table)
        {
            table.OrderId = tableLogic.GiveNewId(table, employee);
        }
    }
}
