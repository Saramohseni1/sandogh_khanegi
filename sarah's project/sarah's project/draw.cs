using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Elastic.Apm.Api;
using System.Collections.Generic;

namespace sarah_s_project
{
    public partial class draw : Form
    {
        public draw()
        {
            InitializeComponent();
        }
        private List<string> items = new List<string> { " 1", " 2", " 3", " 4", " 5", " 6" };

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int selectedIndex = random.Next(items.Count);
            string selectedItem = items[selectedIndex];
            MessageBox.Show( selectedItem);
        }
    }
}
        




