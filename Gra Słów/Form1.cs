using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Gra_Słów
{

    public partial class Form1 : Form
    {

        public static dock menu = new dock();
        public static Form2 reg = new Form2();
        public static Form1 log = new Form1();
        SqlConnection con = new SqlConnection("Data Source=.,1469;Initial Catalog=Game;Persist Security Info=True;User ID=sa;Password=Rezzon123"); //połącznie do bazy
        public string set;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread(); // Zamyka wszystko
        }

        private void label1_Click(object sender, EventArgs e)
        {
            txtLogin.Clear();
            txtPass.Clear();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Login where USERNAME='" + txtLogin.Text+ "'and PASSWORD ='" +txtPass.Text+ "'" ,con); // query wykonujące sprawdzenie danych
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1) //sprawdzenie zgodności danych z bazą
            {
                menu.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Błędny login lub hasło");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            reg.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPass.PasswordChar = '\0';
            }

            else
            {
                txtPass.PasswordChar = '*';
            }
        }
    }
}
