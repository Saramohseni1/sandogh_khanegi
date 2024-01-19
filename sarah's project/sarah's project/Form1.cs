using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace sarah_s_project

{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        mainform main = new mainform();
        signup signup = new signup();

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string pass = textBox2.Text;
            string Password = "";
            SqlConnection sc = new SqlConnection(@"C:\USERS\FANOOS\SOURCE\REPOS\SARAH'S PROJECT\SARAH'S PROJECT\DATABASE1.MDF");
            sc.Open();
            SqlCommand cmd = new SqlCommand("SELECT Password FROM [dbo].[Table] WHERE Username=@username", sc);
            cmd.Parameters.AddWithValue("@username", username);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Password = reader["Password"].ToString();
            }
            if (pass != Password)
            {
                MessageBox.Show($"Wrong password;Try again.");
            }
            else if (username == "")
            {
                MessageBox.Show("What is your username?");
            }
            else if (pass == "")
            {
                MessageBox.Show("please enter your password");
            }
            else
            {
                MessageBox.Show($"Welcome, {username}!");
                main.Show();

                textBox1.Clear();
                textBox2.Clear();
            }
            sc.Close();

            main.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            signup.Show();
        }


    }
}
