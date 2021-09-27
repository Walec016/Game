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
            SqlDataAdapter logindt = new SqlDataAdapter("Select * from Login Where USERNAME='" + login.Text + "'", con);//Query sprawdzające czy użytkownik istnieje
            DataTable dt1 = new DataTable();
            logindt.Fill(dt1);

            if (dt1.Rows.Count == 1)//Sprawdza z bazą czy użytkownik jest zarejestrowany, jeśli tak, zamyka połącznenie z bazą
            {
                MessageBox.Show("Taki użytkownik jest już zarejestrowany");
                pass1.Clear();
                pass2.Clear();
                con.Close();
            }

            else
            {
                if (pass1.Text.Equals(""))
                {
                    con.Close();
                    MessageBox.Show("Hasło nie może być puste!");
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
                        login.Clear();
                        pass1.Clear();
                        pass2.Clear();
                        this.Hide();
                        log.Show();
                    }
                    else
                    {

                        MessageBox.Show("Hasła nie zgadzają się.");

                    }
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
        bool drag = false;
        Point start_point = new Point(0, 0);

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
    }
}
