﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_DB_Project
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();

            btn_login.FlatAppearance.BorderColor = Color.Orange;
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_uname.Text == "0" || txt_passwd.Text == "0")
            {
                Page p = new Page(txt_uname.Text);
                this.Hide();
                p.Show();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void txt_passwd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}