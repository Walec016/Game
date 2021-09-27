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
    public partial class Form2 : Form
    {
        public static dock menu = new dock();
        public static Form2 reg = new Form2();
        public static Form1 log = new Form1();
        SqlConnection con = new SqlConnection("Data Source=.,1469;Initial Catalog=Game;Persist Security Info=True;User ID=sa;Password=Rezzon123"); //połącznie do bazy
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void passview_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sel = new SqlDataAdapter("Select * from Login Where USERNAME='" + login.Text + "'", con);//Query sprawdzające czy użytkownik istnieje
            DataTable dt = new DataTable();
            sel.Fill(dt);

            if (dt.Rows.Count == 1)//Sprawdza z bazą czy użytkownik jest zarejestrowany, jeśli tak, zamyka połącznenie z bazą
            {
                MessageBox.Show("Taki użytkownik jest już zarejestrowany");
                con.Close();
            }

            else
            {
                if (pass1.Text.Equals(pass2.Text))
                {

                    string query = "INSERT INTO Login (USERNAME, PASSWORD) VALUES(@USERNAME, @PASSWORD)";//Query dodające wartości do bazy
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@USERNAME", login.Text); // Parametr dodający wartość texbox w miejsce USERNAME
                    command.Parameters.AddWithValue("@PASSWORD", pass1.Text);// Parametr dodający wartość texbox w miejsce PASSWORD
                    con.Open();
                    command.ExecuteNonQuery();


                    MessageBox.Show("Zarejestrowano. Zaloguj się");
                    this.Close();
                    log.Show();
                }
                else
                {

                    MessageBox.Show("Hasła nie zgadzają się.");

                }
            }    
        }


       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            log.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {

                pass1.PasswordChar = '\0';
                pass2.PasswordChar = '\0';

            }

            else
            {
                pass1.PasswordChar = '*';
                pass2.PasswordChar = '*';
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void login_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
