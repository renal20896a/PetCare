﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetCare
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void Button_User_Login_Click(object sender, EventArgs e)
        {
            FormUserLogin log = new FormUserLogin();
            this.Hide();
            log.ShowDialog();
            this.Close();
        }

        private void Button_Admin_Login_Click(object sender, EventArgs e)
        {
            FormAdminLogin log = new FormAdminLogin();
            this.Hide();
            log.ShowDialog();
            this.Close();
        }
    }
}
