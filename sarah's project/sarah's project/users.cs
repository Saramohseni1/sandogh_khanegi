using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace sarah_s_project
{
    public partial class users : Form
    {
        public users()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text;
                string lname = textBox2.Text;
                int pay = int.Parse(textBox3.Text);
                string phone = textBox4.Text;
                string addres = textBox5.Text;
                string line = name + "," + lname + "," + phone + "," + addres + "\n";
                File.AppendAllText("Text.txt", line);
                string[] Lines = File.ReadAllLines("Text.txt");
                foreach (string Line in Lines)
                {
                    listBox1.Items.Add(Line);
                    string[] choose = Line.Split(',');

                }
                string cs = @"C:\USERS\FANOOS\SOURCE\REPOS\SARAH'S PROJECT\SARAH'S PROJECT\DATABASE1.MDF";
                SqlConnection sc = new SqlConnection(cs);
                string cmd = "INSERT INTO [dbo].[Table](fisrtname,lastname,phone,address,payoutamount)VALUES(@fisrtname,@lastname,@phone,@address,@payoutamount) ";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
