﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Managment__System
{
    public partial class Home_form : Form
    {
        public Home_form()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ADD_BOOK form = new ADD_BOOK();
            form.Show();
        }

        private void Borrow_btn_Click(object sender, EventArgs e)
        {
            Old_Member form = new Old_Member();
            form.Show();
        }

        private void Return_btn_Click(object sender, EventArgs e)
        {
            Old_Member form = new Old_Member();
            form.Show();

        }

        private void Buy_btn_Click(object sender, EventArgs e)
        {
            Old_Member form = new Old_Member();
            form.Show();

        }

        private void New_member_btn_Click(object sender, EventArgs e)
        {
            Sign_up form = new Sign_up();
            form.Show();


        }

        private void Home_form_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text=$"Memory Used :{Sign_up.Mem()}";
        }
    }
}
