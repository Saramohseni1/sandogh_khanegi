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
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }
        
        signup signup = new signup();
        users users = new users();
        draw draw = new draw();
        payment pay = new payment();

        private void button1_Click(object sender, EventArgs e)
        {
            draw.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            users.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pay.Show();
        }
    }
}
