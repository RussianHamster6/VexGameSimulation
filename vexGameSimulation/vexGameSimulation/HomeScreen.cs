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

        bool checkCanDoacc(GameObject o)
        {
            int index = 0;
            bool flag = false;
            while (index < robotScreen.requiredAccList.Count && flag == false)
            {
                if (robotScreen.requiredAccList[index] == o.GetRequiredAction() && robotScreen.canPerformAcList[index] == true)
                {
                    flag = true;
                }
                index++;
            }
            return flag;
        }

        float getTimeForAcc(GameObject o)
        {
            int index = 0;
            bool flag = false;
            float result = 0;
            while (index < robotScreen.requiredAccList.Count && flag == false)
            {
                if (robotScreen.requiredAccList[index] == o.GetRequiredAction())
                {
                    result = robotScreen.timeToComplete[index];
                    flag = true;
                }
                index++;
            }
            return result;
        }

        bool checkPANTScore(GameObject  o)
        {
            if (o.GetPANTScore().Length > 0)
            {
                foreach (GameObject a in actionsCompletedListB)
                {
                    if (a.GetRequiredAction() == o.GetPANTScore())
                    {
                        a.requiredAction = a.GetRequiredAction() + "!";
                        return true;
                    }
                }
                return false;
            }
            else
            {
                return true;
            }
        }
        bool checkActionLimit(GameObject o)
        {
            int count = 0;
            int index = 0;
            if (turningPoint.limitedAction == o.GetRequiredAction())
            {
                while (index < actionsCompletedListB.Count)
                {
                    if (actionsCompletedListB[index].GetRequiredAction() == turningPoint.limitedAction)
                    {
                        count++;
                    }
                    index++;
                    if (count == turningPoint.limitedActionAmount)
                    {
                        return false;
                    }
                }
                if (count < turningPoint.limitedActionAmount)
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
            return true; //This needs to be tested and may need to be changed.
        }

        bool checkBeenScoredA(GameObject o)
        {
            int i = 0;
            bool flag = true;
            if (actionsCompletedListA.Count == 0)
            {
                flag = true;
            }
            else
            {
                while (i < actionsCompletedListA.Count && flag == true)
                {
                    if (actionsCompletedListA[i].GetName() == o.GetName())
                    {
                        flag = false;
                    }
                    else
                    {
                        flag = true;
                    }
                    i++;
                }
            }
            return flag;
        }

        bool checkBeenScoredB(GameObject o)
        {
            int i = 0;
            bool flag = true;
            if (actionsCompletedListB.Count == 0)
            {
                flag = true;
            }
            else
            {
                while (i < actionsCompletedListB.Count && flag == true)
                {
                    if (actionsCompletedListB[i].GetName() == o.GetName())
                    {
                        flag = false;
                    }
                    else
                    {
                        flag = true;
                    }
                    i++;
                }
            }
            return flag;
        }

        public double pythag(float posX1, float posY1, float posX2, float posY2)
        {
            float xDist = posX1 - posX2;
            float yDist = posY1 - posY2;

            double result = Math.Sqrt((xDist * xDist) + (yDist * yDist));
            return result;
        }

        public List<GameObject> actionsCompletedListA = new List<GameObject>();

        public void ASideSim()
        {
            //A SIDE SIM

            //Assigning Variables 
            //Creating a new instance of the selected game to instanciate 
            dynamic GameO;

            var gameObjType = Type.GetType(gameScreen.gameToInstanciate);

            GameO = Activator.CreateInstance(gameObjType);

            //Variables for the robot position
            float robotPosX = GameO.robotXPosA;
            float robotPosY = GameO.robotYPosA;
            //variables for the current time passed in the game 
            float currentTime = 0;

            //Bool values for the functions to assign values to.
            bool prevAccNeeded;
            bool canDoAcc;
            bool limitedAction;
            bool beenScored;

            //creates the value of speed based off of the vex robotics competition tiles standard length of 0.6096M
            float tilePerSecondSpeed = (robotScreen.robotSpeedMS * 6.5626f);
            //Initialises the score value at 0 
            int totalScore = 0;


            while (currentTime < 105)
            {
                //Creates a closeO placeholder with a distance at an extremem so it will be replaced by the first valid action the robot can take. 
                GameObject closeO = new GameObject("PlaceHolder", 10f, 10f, 0, false, "PlaceHolder", "placeholder");
                foreach (GameObject o in GameO.gameObjects)
                {

                    float objXLoc = o.GetXlocation();
                    float objYLoc = o.GetYlocation();

                    //Checks if the robot can do the action needed for the 3.281
                    canDoAcc = checkCanDoacc(o);
                    //Checks if object needs a previous action to score the object
                    prevAccNeeded = checkPANTScore(o);
                    //Checks if there is too many of the limited action on the robot
                    limitedAction = checkActionLimit(o);
                    beenScored = checkBeenScoredA(o);
                    //If all above checks passed determine distance

                    if ((canDoAcc == true &&
                        prevAccNeeded == true) &&
                        (beenScored == true &&
                        limitedAction == true))
                    {
                        double oDist = pythag(objXLoc, objYLoc, robotPosX, robotPosY);

                        if (oDist < pythag(closeO.GetXlocation(), closeO.GetYlocation(), robotPosX, robotPosY))
                        {
                            closeO = o;
                        }
                        else if (closeO.GetName() == "placeholder")
                        {
                            closeO = o;
                        }

                    }
                }
                //Sets GameTime to maximum if placeholder is the CloseO still
                if (closeO.GetName() == "placeholder")
                {
                    currentTime = 105;
                }
                else
                {
                    //Add the optimal outcome to the list
                    actionsCompletedListA.Add(closeO);
                    currentTime = currentTime + (getTimeForAcc(closeO) + (float.Parse(pythag(closeO.GetXlocation(), closeO.GetYlocation(), robotPosX, robotPosY).ToString()) * tilePerSecondSpeed));
                    closeO.beenScored = true;
                    totalScore = totalScore + closeO.GetPointVal();
                }
            }
            //display list of best moves
            int i = 0;
            string bestAcString = "";
            MessageBox.Show("Your Robot Can Do " + actionsCompletedListA.Count.ToString() + " Moves On the A side");
            while (i < actionsCompletedListA.Count)
            {
                bestAcString = bestAcString + ", " + actionsCompletedListA[i].GetName();
                i++;
            }
            MessageBox.Show(bestAcString);
        }

        public List<GameObject> actionsCompletedListB = new List<GameObject>();

        public void BSideSim()
        {
            //B SIDE SIM

            //Assigning Variables 
            //Creating a new instance of the selected game to instanciate 
            var gameObjType = Type.GetType(gameScreen.gameToInstanciate);

            dynamic GameO = Activator.CreateInstance(gameObjType);

            //Variables for the robot position
            float robotPosX = GameO.robotXPosB;
            float robotPosY = GameO.robotYPosB;
            //variables for the current time passed in the game 
            float currentTime = 0;

            //Bool values for the functions to assign values to.
            bool prevAccNeeded;
            bool canDoAcc;
            bool limitedAction;
            bool beenScored;

            //creates the value of speed based off of the vex robotics competition tiles standard length of 0.6096M
            float tilePerSecondSpeed = (robotScreen.robotSpeedMS * 6.5626f);
            //Initialises the score value at 0 
            int totalScore = 0;


            while (currentTime < 105)
            {
                //Creates a closeO placeholder with a distance at an extremem so it will be replaced by the first valid action the robot can take. 
                GameObject closeO = new GameObject("PlaceHolder", 10f, 10f, 0, false, "PlaceHolder", "placeholder");
                foreach (GameObject o in GameO.gameObjects)
                {

                    float objXLoc = o.GetXlocation();
                    float objYLoc = o.GetYlocation();

                    //Checks if the robot can do the action needed for the 3.281
                    canDoAcc = checkCanDoacc(o);
                    //Checks if object needs a previous action to score the object
                    prevAccNeeded = checkPANTScore(o);
                    //Checks if there is too many of the limited action on the robot
                    limitedAction = checkActionLimit(o);
                    beenScored = checkBeenScoredB(o);
                    //If all above checks passed determine distance

                    if ((canDoAcc == true &&
                        prevAccNeeded == true) &&
                        (beenScored == true &&
                        limitedAction == true))
                    {
                        double oDist = pythag(objXLoc, objYLoc, robotPosX, robotPosY);

                        if (oDist < pythag(closeO.GetXlocation(), closeO.GetYlocation(), robotPosX, robotPosY))
                        {
                            closeO = o;
                        }
                        else if (closeO.GetName() == "placeholder")
                        {
                            closeO = o;
                        }

                    }
                }
                //Sets GameTime to maximum if placeholder is the CloseO still
                if (closeO.GetName() == "placeholder")
                {
                    currentTime = 105;
                }
                else
                {
                    //Add the optimal outcome to the list
                    actionsCompletedListB.Add(closeO);
                    currentTime = currentTime + (getTimeForAcc(closeO) + (float.Parse(pythag(closeO.GetXlocation(), closeO.GetYlocation(), robotPosX, robotPosY).ToString()) * tilePerSecondSpeed));
                    closeO.beenScored = true;
                    totalScore = totalScore + closeO.GetPointVal();
                }
            }
            //display list of best moves
            int i = 0;
            string bestAcString = "";
            MessageBox.Show("Your Robot Can Do " + actionsCompletedListB.Count.ToString() + " Moves On the B side");
            while (i < actionsCompletedListB.Count)
            {
                bestAcString = bestAcString + ", " + actionsCompletedListB[i].GetName();
                i++;
            }
            MessageBox.Show(bestAcString);
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            actionsCompletedListA = new List<GameObject>();
            actionsCompletedListB = new List<GameObject>();
            ASideSim();
            BSideSim();
        }
    }
}
