using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace vexGameSimulation
{
    public partial class gameScreen : Form
    {
        string conString = "datasource=localhost;port=3306;uid=root;pwd=root;database=vexgamesim"; //Establishes the connection string for use later in queries 
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
            //section below loads list of games to the gameList
            DataTable dt = new DataTable();

            string Query = "SELECT gameName, gameID from gametable"; //Runs the query to select the gameName and gameID from the gametable 
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
            try
            {
                //Saves Data For gameTable
                string Query = "INSERT INTO vexgamesim.gametable(gameName,gameFileReference) VALUES(@gameName, @gameFileReference);"; //Creates the query for saving the parameters @robotName, @robotSpeed, @gameID to the columns robotName,robotSpeed,gameID
                MySqlConnection connection = new MySqlConnection(conString); //sets the string to establish the connection to the database  
                MySqlCommand command = new MySqlCommand(Query, connection); //creates the command with the 
                command.Parameters.AddWithValue("@gameName", gameNameTxt.Text); //Passes a parameter to the query @robotname for the values of robotNameTxt.Text
                command.Parameters.AddWithValue("@gameFileReference", FileReferenceTxt.Text); //Passes the FileReferenceTxt.Text
                MySqlDataReader reader; //creates a datareader
                connection.Open(); //Opens the connection
                reader = command.ExecuteReader(); //Executes the command using the reader
                connection.Close(); //Closes the connection
                MessageBox.Show("Game Saved Successfully");
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void saveChangesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "UPDATE vexgamesim.gametable SET gameName=@gameName,gameFileReference=@gameFileReference WHERE gameID =" + gameList.SelectedValue.ToString();//creates the query to set the specified parameters at the ID for the game that is selected 
                MySqlConnection connection = new MySqlConnection(conString);//Establishes the connection using the conString
                MySqlCommand command = new MySqlCommand(Query, connection); //Creates the command that will be executed 
                command.Parameters.AddWithValue("@gameName", gameNameTxt.Text); 
                command.Parameters.AddWithValue("@gameFileReference", FileReferenceTxt.Text); 
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
            string Query = "SELECT * FROM gametable WHERE gameID = " + gameList.SelectedValue; //Creates the query for loading data from the robottable where the robotID is the selected value
            MySqlConnection connection = new MySqlConnection(conString); //creates a new connection using the connection string
            MySqlCommand command = new MySqlCommand(Query, connection); //creates a command with the query and the connection
            connection.Open(); //Opens the connection
            MySqlDataReader reader = command.ExecuteReader(); //executes the comand using the reader
            reader.Read(); //Tells the reader to read the data in the database 
            gameNameTxt.Text = (reader["gameName"].ToString()); // sets the text field in gameNameTxt to be the gameName
            FileReferenceTxt.Text = (reader["gameFileReference"].ToString()); //sets the gameFileReference.Text to be equal to the gameFileReference
            gameList.SelectedValue = (reader["gameID"].ToString()); //sets the gameList's Selected Value to be the same as the GameID in the database
            connection.Close(); //Closes the connection
        }
    }
}
