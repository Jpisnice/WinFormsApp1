namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //verify detals and give warning if empty else open HomePage.cs
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please enter your username and password");
            }
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                HomePage hp = new HomePage();
                hp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}