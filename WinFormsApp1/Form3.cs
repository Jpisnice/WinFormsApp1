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
            HomePage f2 = new HomePage();
            f2.Show();
            this.Hide();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //on click enters all textbox enties to exp_table in database using Microsoft SQL Server Management Studio
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2017\Projects\WinFormsApp1\WinFormsApp1\Expenses.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO exp_table (exp_name, exp_amount, exp_date) VALUES (@exp_name, @exp_amount, @exp_date)", con);
            cmd.Parameters.AddWithValue("@exp_name", textBox1.Text);
            cmd.Parameters.AddWithValue("@exp_amount", textBox2.Text);
            cmd.Parameters.AddWithValue("@exp_date", dateTimePicker1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Inserted Successfully");
            



        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Select matching entries from exp_table and make chamges in respective fields
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2017\Projects\WinFormsApp1\WinFormsApp1\Expenses.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE exp_table SET exp_name = @exp_name, exp_amount = @exp_amount, exp_date = @exp_date WHERE exp_name = @exp_name", con);
            cmd.Parameters.AddWithValue("@exp_name", textBox1.Text);
            cmd.Parameters.AddWithValue("@exp_amount", textBox2.Text);
            cmd.Parameters.AddWithValue("@exp_date", dateTimePicker1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Updated Successfully");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Check enties if they exist in exp_table and delete them
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2017\Projects\WinFormsApp1\WinFormsApp1\Expenses.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM exp_table WHERE exp_name = @exp_name", con);
            cmd.Parameters.AddWithValue("@exp_name", textBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Deleted Successfully");
        }
    }
}
