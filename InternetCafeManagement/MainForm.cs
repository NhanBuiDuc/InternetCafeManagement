﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InternetCafeManagement.Account_Form;
using InternetCafeManagement.Class;
using InternetCafeManagement.AdminForm;
using InternetCafeManagement.UserForm;
namespace InternetCafeManagement
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            formProfile fProfile = new formProfile();
            fProfile.Show(this);
        }

        private void Manager_Click(object sender, EventArgs e)
        {
            ComputerRoomManageForm computerRoomManageForm = new ComputerRoomManageForm();
            computerRoomManageForm.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormServer server = new FormServer();
            server.Show(this);
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            FormClient  client = new FormClient();
            client.Show(this);
        }
    }
}
