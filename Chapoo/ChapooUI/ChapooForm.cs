using ChapooModel;
using ChapooLogic;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Data;

namespace ChapooUI
{
    public partial class ChapooForm : Form
    {
        pnlTables tablePanel;
        ManagementPanel managementPanel;
        pnlBarKitchenControl pnlBarKitchenControl;
        public int currentTable = 0;

        public ChapooForm(Employee employee)
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            msTime.Text = DateTime.Now.ToString();
            msName.Text = employee.username;
            string role = "";

            switch (employee.role)
            {
                case 0:
                    tablePanel = new pnlTables(employee);
                    Controls.Add(tablePanel);
                    tablePanel.Show();
                    role = "Service";
                    break;
                case 1:
                    pnlBarKitchenControl = new pnlBarKitchenControl(employee);
                    Controls.Add(pnlBarKitchenControl);
                    pnlBarKitchenControl.Show();
                    role = "Kitchen";
                    break;
                case 2:
                    pnlBarKitchenControl = new pnlBarKitchenControl(employee);
                    Controls.Add(pnlBarKitchenControl);
                    pnlBarKitchenControl.Show();
                    role = "Bar";
                    break;
                case 3:
                    role = "Check Out";
                    tablePanel = new pnlTables(employee);
                    Controls.Add(tablePanel);
                    tablePanel.Show();
                    break;
                case 4:
                    managementPanel = new ManagementPanel();
                    Controls.Add(managementPanel);
                    managementPanel.Show();
                    role = "Management";
                    break;
                default:
                    break;
            }
            msName.Text += " " + role;
        }    

        //Logout
        private void msLogout_Click(object sender, EventArgs e)
        {
            if (msName.Text == "Logged out")
            {
                MessageBox.Show("Already logged out!", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    LoginUI loginUi = new LoginUI();
                    loginUi.Show();
                    this.Hide();
                }
            }
        }

        //Exit
        private void msExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Clock fix
        private void timer1_Tick(object sender, EventArgs e)
        {
            msTime.Text = DateTime.Now.ToString();
        }
    }
}
