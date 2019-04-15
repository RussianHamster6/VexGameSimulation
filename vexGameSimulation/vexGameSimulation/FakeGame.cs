using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vexGameSimulation
{
    class FakeGame
    {

        //Sets the start point for the robot's two possible start points A and B
        public float robotXPosA = 0.5f;
        public float robotYPosA = 3.5f;
        public float robotXPosB = 0.5f;
        public float robotYPosB = 1.5f;

        //creates the list of possible actions 
        public static string[] actionlist = { "fakeAction" };

        public static string limitedAction = "";
        public static int limitedActionAmount = 2;
        //initialises all the objects in the game simulation
        //All Flag actions
        public List<GameObject> gameObjects = new List<GameObject>();
        //Constructor
        public FakeGame()
        {
            GameObject fakeObject = new GameObject("fakeAction", 1f, 5.5f, 2, false, "", "FakeObject");

            gameObjects.Add(fakeObject);
        }
    }
}
