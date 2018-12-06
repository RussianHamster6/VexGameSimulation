using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vexGameSimulation
{
    public partial class robotScreen : Form
    {
        public robotScreen()
        {
            InitializeComponent();
        }

        private void robotScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeScreen temp = new HomeScreen();
            temp.Show();
            this.Hide();
        }
    }
}
