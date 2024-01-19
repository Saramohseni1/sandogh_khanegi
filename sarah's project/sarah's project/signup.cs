using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sarah_s_project
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }
        mainform main = new mainform();

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string fullname = textBox1.Text;
                int idnum = int.Parse(textBox2.Text);
                string username = textBox3.Text;
                string password = textBox4.Text;
                string pconf = textBox5.Text;
                SqlConnection sc = new SqlConnection(@"C:\USERS\FANOOS\SOURCE\REPOS\SARAH'S PROJECT\SARAH'S PROJECT\DATABASE1.MDF");
                sc.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Table] (UserName,Password) Values(@username,@password)", sc);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);
                if (password != pconf)
                {
                    MessageBox.Show($"your passwords dont match!");
                }
                else if (username == "" || password == "" || pconf == "")
                {
                    MessageBox.Show("something went wrong! please try again");
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account successfuly created!");
                    main.Show();
                    this.Hide();

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                }
                sc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
