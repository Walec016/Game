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
    public partial class UCMenu : UserControl
    {
        public static dock menu = new dock();
        public static Container container = new Container();
        public static UCMenu ucmenu = new UCMenu();
        public static Form1 log = new Form1();
        SqlConnection con = new SqlConnection("Data Source=.,1469;Initial Catalog=Game;Persist Security Info=True;User ID=sa;Password=Rezzon123"); //połącznie do bazy
        
        public UCMenu()
        {
            InitializeComponent();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UCMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtPassChange_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDisplayedName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPassChange2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        { 

            if (txtDisplayedName.Text != (""))
            {
                con.Open();
                SqlDataAdapter up1 = new SqlDataAdapter("Update Login set VISIBLENAME = '" + txtDisplayedName.Text + "' where USERNAME='" + menu.getUser()  + "'", con);
                DataTable dt = new DataTable();
                up1.Fill(dt); 
                
                
            }

            else if (txtDisplayedName.Text == "")
            {
                MessageBox.Show("Wprowadź nazwę");
            }




            if (txtPassChange.Text.Equals(""))
            {
                con.Close();
                MessageBox.Show("Hasło nie może być puste!");
            }

            else if (txtPassChange.Text == txtPassChange2.Text)
            {
               SqlDataAdapter passup = new SqlDataAdapter("Update Login set PASSWORD='" + txtPassChange.Text + "' Where USERNAME='" + menu.getUser() + "'", con);
               DataTable dt3 = new DataTable();
               passup.Fill(dt3);
            }
             else if (txtPassChange2.Text.Equals(""))
             {
               con.Close();
               MessageBox.Show("Powtórz hasło!");
             }
             else
             {
              MessageBox.Show("Hasła nie zgadzają się.");
             }
        }
    }
}
            
