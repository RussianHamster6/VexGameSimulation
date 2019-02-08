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
        string conString = "datasource=localhost;port=3306;uid=root;pwd=root;database=vexgamesim"; //Establishes the connection string for use later in queries 
        string Query; //Sets a Query string that can be reassigned
        int i; //Sets an int to i that can then be reassigned 
       
        public robotScreen()
        {
            InitializeComponent();
        }

        private void robotScreen_Load(object sender, EventArgs e)
        {
            //section below loads list of games to the gameList
            DataTable dt = new DataTable();

            this.robottableTableAdapter.Fill(this.vexgamesimDataSet.robottable); //Fills RobotTable with the data from the robottable
            Query = "SELECT gameName, gameID from gametable"; //Runs the query to select the gameName and gameID from the gametable 
            MySqlConnection connection = new MySqlConnection(conString); //sets the string to establish the connection to the database 
            MySqlCommand command = new MySqlCommand(Query, connection); //Creates a command using the query and the constring to be run later 
            MySqlDataAdapter da = new MySqlDataAdapter(Query, conString); //creates a data adapter for the data to be thrown into the data table
            da.Fill(dt); //fills the datatable with the data
            connection.Open(); //opens the connection
            gameList.DataSource = dt; //sets the datasource for the gamelist to be the datatable
            gameList.DisplayMember = "gameName"; //sets the display member property to be equal to the gamename property of the gamelist.DisplayMember
            gameList.ValueMember = "gameID"; //Sets the value value member property to be equal to the gameID property of the gamelist.Valuemember 
            gameList.Enabled = true; //Enables the gamelist in case it was disabled
            command.ExecuteNonQuery(); //Executes the command
            connection.Close(); //Closes the connection

            //selection below loads list of robots to the robotList

            DataTable dt2 = new DataTable();

            this.robottableTableAdapter.Fill(this.vexgamesimDataSet.robottable);//Fills RobotTable with the data from the robottable
            Query = "SELECT robotName, robotID from robottable"; //Runs the query to select the gameName and gameID from the gametable 
            MySqlConnection connection2 = new MySqlConnection(conString);//sets the string to establish the connection to the database 
            MySqlCommand command2 = new MySqlCommand(Query, connection);//Creates a command using the query and the constring to be run later 
            MySqlDataAdapter da2 = new MySqlDataAdapter(Query, conString);//creates a data adapter for the data to be thrown into the data table
            da2.Fill(dt2); //fills the datatable with the data
            connection.Open(); //opens the connection
            RobotList.DataSource = dt2; //sets the datasource for the gamelist to be the datatable
            RobotList.DisplayMember = "robotName"; //sets the display member property to be equal to the gamename property of the RobotList.DisplayMember
            RobotList.ValueMember = "robotID"; //Sets the value value member property to be equal to the gameID property of the RobotList.ValueMember 
            RobotList.Enabled = true; //Enables the RobotList in case it was disabled
            command.ExecuteNonQuery(); //Executes the command
            connection.Close(); //Closes the connection
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeScreen temp = new HomeScreen(); //Creates a new HomeScreen Object
            temp.Show();//Shows the new HomeScreen Object
            this.Hide(); //Hides the current object
        }

        private void saveAsNewBtn_Click(object sender, EventArgs e)
        {
            try
            {
                float robotSpeed = float.Parse(robotSpeedTxt.Text, CultureInfo.InvariantCulture.NumberFormat); //convert the robotSpeedTxt input into a floating point number
                Query = "INSERT INTO vexgamesim.robottable(robotName,robotSpeed,gameID) VALUES(@robotName, @robotSpeed, @gameID);"; //Creates the query for saving the parameters @robotName, @robotSpeed, @gameID to the columns robotName,robotSpeed,gameID
                MySqlConnection connection = new MySqlConnection(conString); //sets the string to establish the connection to the database  
                MySqlCommand command = new MySqlCommand(Query, connection); //creates the command with the 
                command.Parameters.AddWithValue("@robotName", robotNameTxt.Text); //Passes a parameter to the query @robotname for the values of robotNameTxt.Text
                command.Parameters.AddWithValue("@robotSpeed", robotSpeed); //Passes the robotSpeed into the parameter for @robotSpeed
                command.Parameters.AddWithValue("@gameID", gameList.SelectedValue); //Passes the gameList.SelectedValue into the parameter for @gameID
                MySqlDataReader reader; //creates a datareader
                connection.Open(); //Opens the connection
                reader = command.ExecuteReader(); //Executes the command using the reader
                connection.Close(); //Closes the connection
                MessageBox.Show("Data has been Saved!"); //Shows a messagebox detailing if the data has been saved.

            }

            catch
            {
                MessageBox.Show("Failed to Save"); //Shows a messageBox showign that the data has failed to save
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void robotSpeedTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float robotSpeed = float.Parse(robotSpeedTxt.Text, CultureInfo.InvariantCulture.NumberFormat); //Checks too see if the robotSpeedTxt can be converted into a float
            }
            catch
            {
                MessageBox.Show("Robot Speed needs to be a number"); //Shows a messagebox detailing why there was an error
                robotSpeedTxt.Text = ""; //Sets the value in the robotSpeedTxt.Text field to empty so that the user can attempt to re submit with valid data
            }
        }

        private void saveChangesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                float robotSpeed = float.Parse(robotSpeedTxt.Text, CultureInfo.InvariantCulture.NumberFormat);
                Query = "UPDATE vexgamesim.robottable SET robotName=@robotName,robotSpeed=@robotSpeed,gameID=@gameID WHERE robotID =" + RobotList.SelectedValue.ToString();//creates the query to set the specified parameters at the ID for the robot that is selected 
                MySqlConnection connection = new MySqlConnection(conString);//Establishes the connection using the conString
                MySqlCommand command = new MySqlCommand(Query, connection); //Creates the command that will be executed 
                command.Parameters.AddWithValue("@robotName", robotNameTxt.Text); //Adds the value from rootNameTxt to the paramater @robotName
                command.Parameters.AddWithValue("@robotSpeed", robotSpeed); //Adds the robotSpeed to the parameter @robotSpeed
                command.Parameters.AddWithValue("@gameID", gameList.SelectedValue); //Adds the gameList.SelectedValue value to the parameter @gameId
                MySqlDataReader reader; //Creates a blank data reader
                connection.Open();//Opens the connection
                reader = command.ExecuteReader(); //executes the command with the reader
                connection.Close();//Closes the connection
                MessageBox.Show("Data has been Changed!"); //Shows a messagebox saying the data has been changed
            }
            catch
            {
                MessageBox.Show("Failed to Change");//Throws an error if the data fails to save
            }
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Query = "SELECT * FROM robottable WHERE robotID = " + RobotList.SelectedValue; //Creates the query for loading data from the robottable where the robotID is the selected value
                MySqlConnection connection = new MySqlConnection(conString); //creates a new connection using the connection string
                MySqlCommand command = new MySqlCommand(Query, connection); //creates a command with the query and the connection
                connection.Open(); //Opens the connection
                MySqlDataReader reader = command.ExecuteReader(); //executes the comand using the reader
                reader.Read(); //Tells the reader to read the data in the database 
                robotNameTxt.Text = (reader["robotName"].ToString()); // sets the text field in robotNameTxt to be the robotName
                robotSpeedTxt.Text = (reader["robotSpeed"].ToString()); //sets the robotSpeedTxt.Text to be equal to the robot Speed
                gameList.SelectedValue = (reader["gameID"].ToString()); //sets the gameList's Selected Value to be the same as the GameID in the database
                connection.Close(); //Closes the connection
            }
            catch
            {
                MessageBox.Show("Failed to load"); //Shows a messagebox with the failed to load error
            }
        }
    }
    
}
