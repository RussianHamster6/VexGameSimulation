using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace vexGameSimulation
{
    public partial class robotScreen : Form
    {
        string conString = "datasource=localhost;port=3306;uid=root;pwd=root;database=vexgamesim";
        string Query;
        int i;
       
        public robotScreen()
        {
            InitializeComponent();
        }

        private void robotScreen_Load(object sender, EventArgs e)
        {
            //section below loads list of games to the gameList
            DataTable dt = new DataTable();

            this.robottableTableAdapter.Fill(this.vexgamesimDataSet.robottable);
            Query = "SELECT gameName, gameID from gametable";
            MySqlConnection connection = new MySqlConnection(conString);
            MySqlCommand command = new MySqlCommand(Query, connection);
            MySqlDataAdapter da = new MySqlDataAdapter(Query, conString);
            da.Fill(dt);
            connection.Open();
            gameList.DataSource = dt;
            gameList.DisplayMember = "gameName";
            gameList.ValueMember = "gameID";
            gameList.Enabled = true;
            command.ExecuteNonQuery();
            connection.Close();

            //selection below loads list of robots to the robotList

            DataTable dt2 = new DataTable();

            this.robottableTableAdapter.Fill(this.vexgamesimDataSet.robottable);
            Query = "SELECT robotName, robotID from robottable";
            MySqlConnection connection2 = new MySqlConnection(conString);
            MySqlCommand command2 = new MySqlCommand(Query, connection2);
            MySqlDataAdapter da2 = new MySqlDataAdapter(Query, conString);
            da2.Fill(dt2);
            connection2.Open();
            RobotList.DataSource = dt2;
            RobotList.DisplayMember = "robotName";
            RobotList.ValueMember = "robotID";
            RobotList.Enabled = true;
            command2.ExecuteNonQuery();
            connection2.Close();
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
            try
            {
                float robotSpeed = float.Parse(robotSpeedTxt.Text, CultureInfo.InvariantCulture.NumberFormat); //convert the robotSpeedTxt input into a number
                Query = "INSERT INTO vexgamesim.robottable(robotName,robotSpeed,gameID) VALUES(@robotName, @robotSpeed, @gameID);";
                MySqlConnection connection = new MySqlConnection(conString);
                MySqlCommand command = new MySqlCommand(Query, connection);
                command.Parameters.AddWithValue("@robotName", robotNameTxt.Text);
                command.Parameters.AddWithValue("@robotSpeed", robotSpeed);
                command.Parameters.AddWithValue("@gameID", gameList.SelectedValue);
                MySqlDataReader reader;
                connection.Open();
                reader = command.ExecuteReader();
                connection.Close();
                MessageBox.Show("Data has been Saved!");

            }

            catch
            {
                MessageBox.Show("Failed to Save");
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void robotSpeedTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float robotSpeed = float.Parse(robotSpeedTxt.Text, CultureInfo.InvariantCulture.NumberFormat); //convert the robotSpeedTxt input into a number
            }
            catch
            {
                MessageBox.Show("Robot Speed needs to be a number");
                robotSpeedTxt.Text = "";
            }
        }

        private void saveChangesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                float robotSpeed = float.Parse(robotSpeedTxt.Text, CultureInfo.InvariantCulture.NumberFormat);
                Query = "UPDATE vexgamesim.robottable SET robotName=@robotName,robotSpeed=@robotSpeed,gameID=@gameID WHERE robotID =" + RobotList.SelectedValue.ToString();
                MySqlConnection connection = new MySqlConnection(conString);
                MySqlCommand command = new MySqlCommand(Query, connection);
                command.Parameters.AddWithValue("@robotName", robotNameTxt.Text);
                command.Parameters.AddWithValue("@robotSpeed", robotSpeed);
                command.Parameters.AddWithValue("@gameID", gameList.SelectedValue);
                MySqlDataReader reader;
                connection.Open();
                reader = command.ExecuteReader();
                connection.Close();
                MessageBox.Show("Data has been Changed!");
            }
            catch
            {
                MessageBox.Show("Failed to Change");
            }
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            Query = "SELECT * FROM robottable WHERE robotID = " + RobotList.SelectedValue;
            MySqlConnection connection2 = new MySqlConnection(conString);
            MySqlCommand command2 = new MySqlCommand(Query, connection2);
            connection2.Open();
            MySqlDataReader reader = command2.ExecuteReader();          
            reader.Read();
            robotNameTxt.Text = (reader["robotName"].ToString());
            robotSpeedTxt.Text = (reader["robotSpeed"].ToString());
            gameList.SelectedValue = (reader["gameID"].ToString());
            connection2.Close();
        }
    }
    
}
