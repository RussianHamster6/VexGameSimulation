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
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Switches to the Robot Screen
            robotScreen temp = new robotScreen();
            temp.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Switches to the Game Screen
            gameScreen temp = new gameScreen();
            temp.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        string runPosASim()
        {
            string result = "ASim";
            return result;
        }

        string runPosBSim()
        {
            string result = "BSim";
            return result;
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            turningPoint oturningPoint = new turningPoint();

            foreach (GameObject o in oturningPoint.gameObjects)
            {

            }
        }
    }
}
