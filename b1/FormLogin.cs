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

namespace b1
{
    public partial class FormLogin : Form
    {
        Koneksi Konn = new Koneksi();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = Konn.GetConn();
            string username = textUsername.Text;
            string password = textPassword.Text;

            {
                Conn.Open();
                string query = "select lvl from tb_user where username = @Username AND password = @Password";
                SqlCommand cmd = new SqlCommand(query, Conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                string lvl = (string)cmd.ExecuteScalar();
                if (lvl != null)
                {
                    if(lvl == "Kasir")
                    {
                        FormMainMenu menu = new FormMainMenu();
                        menu.SetupForm(lvl, username);
                        menu.Show();
                    }
                    else if(lvl == "Admin")
                    {
                        FormMainMenu menu = new FormMainMenu();
                        menu.SetupForm(lvl, username);
                        menu.Show();
                    }
                    
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau password salah!");
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
