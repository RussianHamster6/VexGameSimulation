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
            // TODO: This line of code loads data into the 'vexgamesimDataSet.robottable' table. You can move, or remove it, as needed.
            this.robottableTableAdapter.Fill(this.vexgamesimDataSet.robottable);

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

        private void saveAsNewBtn_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
