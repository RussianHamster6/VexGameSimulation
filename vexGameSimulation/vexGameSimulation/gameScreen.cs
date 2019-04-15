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
    public partial class gameScreen : Form
    {
        public static string gameToInstanciate;

        public gameScreen()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void gameScreen_Load(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            gameToInstanciate = "vexGameSimulation." + FileReferenceTxt.Text+", vexGameSimulation";

            HomeScreen temp = new HomeScreen();
            temp.Show();
            this.Hide();
        }

        private void saveAsNewBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine(typeof(turningPoint).AssemblyQualifiedName);
        }

        private void saveChangesBtn_Click(object sender, EventArgs e)
        {

        }

        private void loadBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
