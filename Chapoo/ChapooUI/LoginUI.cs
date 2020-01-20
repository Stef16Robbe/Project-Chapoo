using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using ChapooUI;
using ChapooModel;
using ChapooLogic;

namespace ChapooUI
{
    public partial class LoginUI : Form
    {
        public string digits = "0123456789";

        public LoginUI()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            pnlPassword.Hide();
            pnlLogin.Show();
            tbLoginPassword.UseSystemPasswordChar = true;
            tbWVnewPassword.UseSystemPasswordChar = true;
            tbWVkey.UseSystemPasswordChar = true;
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

        //Login
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (tbLoginPassword.Text != "" && tbLoginUsername.Text != "")
            {
                string username = tbLoginUsername.Text;
                string password = tbLoginPassword.Text;
                EmployeeLogic employeeLogic = new EmployeeLogic();
                Employee employee = employeeLogic.GetUser(username, password);
                if (employee.username != "")
                {
                    ChapooForm form = new ChapooForm(employee);
                    tbLoginPassword.Text = "";
                    tbLoginUsername.Text = "";
                    this.Hide();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("User does not exist or password is wrong", "Warning", MessageBoxButtons.OK);
                    tbLoginPassword.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Username or password is not filled in!", "Warning", MessageBoxButtons.OK);
            }
        }

        //Go to password forgotten
        private void lblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlPassword.Show();
            pnlLogin.Hide();
            tbLoginPassword.Text = "";
            tbLoginUsername.Text = "";
            btnNextStep1.Show();
            tbWVusername.Show();
            lblNewPassword.Hide();
            btnPasswordShowPassword.Hide();
            btnChangePassword.Hide();
            tbWVnewPassword.Hide();
            tbWVkey.Hide();
            lblkey.Hide();
        }

        //Register next step
        private void btnNextStep1_Click_1(object sender, EventArgs e)
        {
            if (tbWVusername.Text != "")
            {
                EmployeeLogic employeeLogic = new EmployeeLogic();
                if (employeeLogic.CheckUsername(tbWVusername.Text))
                {
                    btnChangePassword.Show();
                    tbWVnewPassword.Show();
                    lblNewPassword.Show();
                    btnPasswordShowPassword.Show();
                    lblkey.Show();
                    tbWVkey.Show();
                }
                else
                {
                    MessageBox.Show("Username does not exist", "Warning", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Username is empty!", "Warning", MessageBoxButtons.OK);
            }
        }

        //Edit password
        private void btnWijzigWachtwoord_Click_1(object sender, EventArgs e)
        {
            if (tbWVkey.Text == "key")
            {
                if (tbWVnewPassword.Text != "")
                {
                    if (CheckPassword(tbWVnewPassword.Text))
                    {
                        EmployeeLogic employeeLogic = new EmployeeLogic();
                        Employee employee = employeeLogic.GetUser(tbWVusername.Text, tbWVnewPassword.Text);
                        employeeLogic.ChangePassword(employee);
                        MessageBox.Show("Success");
                        tbWVnewPassword.Text = "";
                        tbWVusername.Text = "";
                        pnlPassword.Hide();
                        pnlLogin.Show();
                    }
                    else
                    {
                        MessageBox.Show("Password is not valid\r\rMust contain only four digits", "Warning", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("New password is empty", "Warning");
                }
            }
            else
            {
                MessageBox.Show("Key is not valid", "Warning");
            }
        }

        //Back to login from register
        private void lblBackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlPassword.Hide();
            pnlLogin.Show();
        }

        //Close application
        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Code to show password instead of bullets
        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (tbLoginPassword.UseSystemPasswordChar)
            {
                tbLoginPassword.UseSystemPasswordChar = false;
                btnLoginShowPassword.Text = "Hide password";
            }
            else
            {
                tbLoginPassword.UseSystemPasswordChar = true;
                btnLoginShowPassword.Text = "Show password";
            }
        }

        private void btnPasswordShowPassword_Click(object sender, EventArgs e)
        {
            if (tbWVnewPassword.UseSystemPasswordChar)
            {
                tbWVnewPassword.UseSystemPasswordChar = false;
                tbWVkey.UseSystemPasswordChar = false;
                btnPasswordShowPassword.Text = "Hide password and key";
            }
            else
            {
                tbWVnewPassword.UseSystemPasswordChar = true;
                tbWVkey.UseSystemPasswordChar = true;
                btnPasswordShowPassword.Text = "Show password and key";
            }
        }
    }
}