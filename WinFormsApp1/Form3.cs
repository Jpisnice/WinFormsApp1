using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //on click should close this form and open Form2.cs
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //on click should add all textbox entries to the database in exp-table

            //connection string
            string conString = "Data Source=DESKTOP-2QJQJ3G;Initial Catalog=ExpenseManager;Integrated Security=True";
            //query
            string query = "INSERT INTO exp (exp-name, exp-amount, exp-date) VALUES (@exp-name, @exp-amount, @exp-date)";
            //connection
            SqlConnection con = new SqlConnection(conString);
            //command
            SqlCommand cmd = new SqlCommand(query, con);
            //open connection
            con.Open();
            //execute query
            cmd.ExecuteNonQuery();
            //display message
            MessageBox.Show("Expense added successfully");

            //close connection
            con.Close();
            
            

        }
    }
}
