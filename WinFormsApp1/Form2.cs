﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //on click should show Form3.cs and close this form
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //on click should show IncomeHandler.cs and close this form
            IncomeHandler incomeHandler = new IncomeHandler();
            incomeHandler.Show();
            this.Close();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
