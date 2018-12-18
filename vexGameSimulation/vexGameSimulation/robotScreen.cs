﻿using System;
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

        public robotScreen()
        {
            InitializeComponent();
        }

        private void robotScreen_Load(object sender, EventArgs e)
        {
            this.robottableTableAdapter.Fill(this.vexgamesimDataSet.robottable);
            //TODO: Load data into the comboboxes from the database with game names and robot names.
            Query = "";

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
                Query = "INSERT INTO vexgamesim.robottable(robotName,robotSpeed) VALUES('" + this.robotNameTxt.Text + "','" + robotSpeed + "');";
                MySqlConnection connection = new MySqlConnection(conString);
                MySqlCommand command = new MySqlCommand(Query, connection);
                MySqlDataReader reader;
                connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {

                }
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
    }
}
