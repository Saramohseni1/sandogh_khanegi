using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sarah_s_project
{
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fname = textBox1.Text;
            string lname = textBox2.Text;
            string payout = textBox3.Text;
            SqlConnection sc = new SqlConnection(@"C:\USERS\FANOOS\SOURCE\REPOS\SARAH'S PROJECT\SARAH'S PROJECT\DATABASE1.MDF");
            sc.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Table](firstname,lastname.payoutamount) Values(@firstname,@lastname,@payoutamount");
            cmd.Parameters.AddWithValue("@firstname", fname);
            cmd.Parameters.AddWithValue("@lastname", lname);
            cmd.Parameters.AddWithValue("@payoutamount", payout);
            cmd.ExecuteNonQuery();
            this.Hide();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            sc.Close();
        }
    }
}
