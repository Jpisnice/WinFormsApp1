using System;
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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //on click shoud open form1.cs and close this form
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //on click should open form3.cs and close this form
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //on click should open IncomeHandler.cs and close this form
            IncomeHandler ih = new IncomeHandler();
            ih.Show();
            this.Hide();
            
        }
    }
}
