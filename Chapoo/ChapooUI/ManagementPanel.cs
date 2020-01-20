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
    public partial class ManagementPanel : UserControl
    {
        public string digits = "0123456789";

        public ManagementPanel()
        {
            InitializeComponent();
            tbRegisterKey.UseSystemPasswordChar = true;
            tbRegisterPassword.UseSystemPasswordChar = true;
            pnlRegister.Hide();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            pnlRegister.Show();
        }

        //Show password
        private void btnRegisterShowPassword_Click(object sender, EventArgs e)
        {
            if (tbRegisterPassword.UseSystemPasswordChar)
            {
                tbRegisterPassword.UseSystemPasswordChar = false;
                btnRegisterShowPassword.Text = "Hide password";
            }
            else
            {
                tbRegisterPassword.UseSystemPasswordChar = true;
                btnRegisterShowPassword.Text = "Show password";
            }
        }

        //Check password
        private bool CheckPassword(string pw)
        {
            //Check if password is right
            bool isRight = true;
            if (pw.Length != 4)
                isRight = false;
            foreach (char c in pw)
                if (!digits.Contains(c))
                    isRight = false;
            return isRight;
        }

        private void btnMakeAccount_Click_1(object sender, EventArgs e)
        {
            if (tbRegisterPassword.Text != "" && tbRegisterUsername.Text != "")
            {
                string filledUsername = tbRegisterUsername.Text;
                string filledPassword = tbRegisterPassword.Text;
                int filledRole = cbRegisterType.SelectedIndex;

                bool doesExist = false;
                const string licenseKey = "key";
                EmployeeLogic employeeLogic = new EmployeeLogic();
                employeeLogic.RegisterAccount(filledUsername, filledPassword, filledRole);
                doesExist = employeeLogic.CheckUsername(filledUsername);

                if (tbRegisterKey.Text == licenseKey)
                {
                    if (cbRegisterType.Text != "*Choose*")
                    {
                        if (tbRegisterPassword.Text.Length > 7 && CheckPassword(tbRegisterPassword.Text))
                        {
                            if (!doesExist)
                            {
                                try
                                {
                                    employeeLogic.RegisterAccount(filledUsername, filledPassword, filledRole);
                                    MessageBox.Show("Register successful", "Success", MessageBoxButtons.OK);
                                    tbRegisterKey.Text = "";
                                    tbRegisterPassword.Text = "";
                                    tbRegisterUsername.Text = "";
                                    cbRegisterType.Text = "*Choose*";
                                }
                                catch
                                {
                                    MessageBox.Show("Unsuccessful register", "Error", MessageBoxButtons.RetryCancel);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Username already exists", "Warning", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password is not valid\r\nMust only contain four digits!", "Warning", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Choose a role", "Warning", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("License key not valid", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Username, password or e-mail is empty", "Warning", MessageBoxButtons.OK);
            }
        }
    }
}
