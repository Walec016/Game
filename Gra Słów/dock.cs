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
    public partial class dock : Form
    {

        public static dock menu = new dock();
        public static Form2 reg = new Form2();
        public static Form1 log = new Form1();
        SqlConnection con = new SqlConnection("Data Source=.,1469;Initial Catalog=Game;Persist Security Info=True;User ID=sa;Password=Rezzon123"); //połącznie do bazy

        public dock()
        {

            InitializeComponent();
            

        }

        private void dock_Load(object sender, EventArgs e)
        {
            SidePanel.Height = SideButton1.Height;
            SidePanel.Top = SideButton1.Top;
        }

        private void SideButton1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = SideButton1.Height;
            SidePanel.Top = SideButton1.Top;
        }

        private void SideButton2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = SideButton2.Height;
            SidePanel.Top = SideButton2.Top;
        }

        private void SideButton3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = SideButton3.Height;
            SidePanel.Top = SideButton3.Top;
        }

        private void SideButton4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = SideButton4.Height;
            SidePanel.Top = SideButton4.Top;
        }

        private void SideButton5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = SideButton5.Height;
            SidePanel.Top = SideButton5.Top;
        }

        private void SideButton6_Click(object sender, EventArgs e)
        {
            SidePanel.Height = SideButton6.Height;
            SidePanel.Top = SideButton6.Top;
            this.Hide();
            log.Show();
            
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        //Funkcja dająca możliwość poruszania Form1

        bool drag = false;
        Point start_point = new Point(0, 0);

        private void Menu_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void Menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        } 
        private void Menu_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    } //
}
