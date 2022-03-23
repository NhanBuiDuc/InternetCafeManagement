﻿using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using InternetCafeManagement.Class;
namespace InternetCafeManagement
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }
        DBConnection db = new DBConnection();
        Account account = new Account();

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            textBoxUsername.Focus();
        }

        private void labelCreateAccount_Click(object sender, EventArgs e)
        {
            formRegister formRegister = new formRegister();
            formRegister.Show(this);
            this.Hide();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.PasswordChar = '\0';

            }
            else
            {
                textBoxPassword.PasswordChar = '•';

            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            

            if (account.login(username, password))
            {
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Login Success");
                CurrentUser.Id = account.getUserID(username);
                formMain dashBoard = new formMain();
                dashBoard.Show(this);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            textBoxUsername.Select();
            textBoxUsername.Text = "admin1";
            textBoxPassword.Text = "123";
        }
    }
}