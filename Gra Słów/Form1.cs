using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Gra_Słów
{

    public partial class Form1 : Form
    {

        public static dock menu = new dock();
        public static Form2 reg = new Form2();
        public static Form1 log = new Form1();
        SqlConnection con = new SqlConnection("Data Source=.,1469;Initial Catalog=Game;Persist Security Info=True;User ID=sa;Password=Rezzon123"); //połącznie do bazy


        public Form1()
        {
            InitializeComponent();
        }
      

        private void Form1_Load(object sender, EventArgs e)
        {
            txtLogin.Focus();
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


        public void button2_Click(object sender, EventArgs e)
        {

            
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Login where USERNAME='" + txtLogin.Text+ "'and PASSWORD ='" +txtPass.Text+ "'" ,con); // query wykonujące sprawdzenie danych
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1) //sprawdzenie zgodności danych z bazą
            {
                SqlDataAdapter up1 = new SqlDataAdapter("Update Login set ACTIVE = '1' where USERNAME ='"+txtLogin.Text+"'", con) ;
                menu.setUserName(txtLogin.Text);
                up1.Fill(dt); //zmienia w tabeli Active na 1
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

        //Funkcja dająca możliwość poruszania Form1

        bool drag = false;
        Point start_point = new Point(0,0);

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }//

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            SqlDataAdapter up2 = new SqlDataAdapter("Update Login set ACTIVE = '0' where USERNAME = '" + menu.getUserName() + "'", con);
            DataTable dt2 = new DataTable();
            up2.Fill(dt2); //zmienia w tabeli Active na 0
            Application.ExitThread(); // Zamyka wszystko
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Funkcja minimalizująca aplikację do Tray

        private void Form1_Resize(object sender, EventArgs e)
        {
            
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;

        }
        


    }
    
    //
}
