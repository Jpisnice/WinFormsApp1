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
    public partial class IncomeHandler : Form
    {
        public IncomeHandler()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //on click should close this form and open Form2.cs

            HomePage f2 = new HomePage();
            f2.Show();
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //on clcik enters all entries to inc_table in database using Microsoft SQL Server Management Studio
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2017\Projects\WinFormsApp1\WinFormsApp1\Expenses.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO inc_table (inc_name, inc_amount, inc_date) VALUES (@inc_name, @inc_amount, @inc_date)", con);
            cmd.Parameters.AddWithValue("@inc_name", textBox1.Text);
            cmd.Parameters.AddWithValue("@inc_amount", textBox2.Text);
            cmd.Parameters.AddWithValue("@inc_date", dateTimePicker1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Inserted Successfully");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //on click should modify corresponding entries in inc_table
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2017\Projects\WinFormsApp1\WinFormsApp1\Expenses.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE inc_table SET inc_name = @inc_name, inc_amount = @inc_amount, inc_date = @inc_date WHERE inc_name = @inc_name", con);
            cmd.Parameters.AddWithValue("@inc_name", textBox1.Text);
            cmd.Parameters.AddWithValue("@inc_amount", textBox2.Text);
            cmd.Parameters.AddWithValue("@inc_date", dateTimePicker1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Updated Successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //on click should delete corresponding entries in inc_table
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2017\Projects\WinFormsApp1\WinFormsApp1\Expenses.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM inc_table WHERE inc_name = @inc_name", con);
            cmd.Parameters.AddWithValue("@inc_name", textBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Deleted Successfully");
            
        }
    }
}
