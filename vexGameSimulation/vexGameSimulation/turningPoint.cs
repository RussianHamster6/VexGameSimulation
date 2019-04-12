using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vexGameSimulation
{
    class turningPoint
    {
        //Sets the start point for the robot's two possible start points A and B
        public float robotXPosA = 0.5f;
        public float robotYPosA = 3.5f;
        public float robotXPosB = 0.5f;
        public float robotYPosB = 1.5f;

        //creates the list of possible actions 
        public static string[] actionlist = { "pickUpBall","hitTopFlag","hitMidFlag","hitBotFlag","flipCap","stackCapLow","stackCapHigh","pickUpCap","parkLow","parkHigh" };

        public static string limitedAction = "pickUpBall";
        public static int limitedActionAmount = 2;
        //initialises all the objects in the game simulation
        //All Flag actions
        public List<GameObject> gameObjects = new List<GameObject>();
        //Constructor
        public turningPoint()
        {

            GameObject redTopFlag = new GameObject("hitTopFlag", 1f, 5.5f, 2, false, "pickUpBall", "redTopFlag");
            GameObject redMidFlag = new GameObject("hitMidFlag", 1f, 5.5f, 2, false, "pickUpBall", "redMidFlag");
            GameObject redBotFlag = new GameObject("hitBotFlag", 1f, 5.5f, 1, false, "pickUpBall", "redBotFlag");
            GameObject neutralTopFlag = new GameObject("hitTopFlag", 3f, 5.5f, 2, false, "pickUpBall", "neutralTopFlag");
            GameObject neutralMidFlag = new GameObject("hitMidFlag", 3f, 5.5f, 2, false, "pickUpBall", "neutralMidFlag");
            GameObject neutralBotFlag = new GameObject("hitBotFlag", 3f, 5.5f, 2, false, "pickUpBall", "neutralBotFlag");
            GameObject blueTopFlag = new GameObject("hitTopFlag", 5f, 5.5f, 2, false, "pickUpBall", "blueTopFlag");
            GameObject blueMidFlag = new GameObject("hitMidFlag", 5f, 5.5f, 2, false, "pickUpBall", "blueMidFlag");
            GameObject blueBotFlag = new GameObject("hitBotFlag", 5f, 5.5f, 2, false, "pickUpBall", "blueBotFlag");
            //All Flipping Cap Actions
            GameObject redCapNearFlag = new GameObject("flipCap", 1.5f, 4.5f, 1, false, "", "redCapNearFlag");
            GameObject redCapNearWall = new GameObject("flipCap", 2.5f, 0.5f, 1, false, "", "redCapNearWall");
            GameObject redCapNearWallPark = new GameObject("flipCap", 2.5f, 2.5f, 1, false, "", "redCapNearWallPark");
            GameObject redCapNearFlagPark = new GameObject("flipCap", 2.5f, 3.5f, 1, false, "", "redCapNearFlagPark");
            GameObject blueCapNearFlag = new GameObject("flipCap", 4.5f, 4.5f, 1, false, "", "blueCapNearFlag");
            GameObject blueCapNearWall = new GameObject("flipCap", 3.5f, 0.5f, 1, false, "", "blueCapNearWall");
            GameObject blueCapNearWallPark = new GameObject("flipCap", 3.5f, 2.5f, 1, false, "", "blueCapNearWallPark");
            GameObject blueCapNearFlagPark = new GameObject("flipCap", 3.5f, 3.5f, 1, false, "", "blueCapNearFlagPark");
            //All Picking Up Actions
            GameObject pickUpRedCapNearFlag = new GameObject("pickUpCap", 1.5f, 4.5f, 1, false, "flipCap", "pickUpRedCapNearFlag");
            GameObject pickUpRedCapNearWall = new GameObject("pickUpCap", 2.5f, 0.5f, 1, false, "flipCap", "pickUpRedCapNearWall");
            GameObject pickUpRedCapNearWallPark = new GameObject("pickUpCap", 2.5f, 2.5f, 1, false, "flipCap", "pickUpRedCapNearWallPark");
            GameObject pickUpRedCapNearFlagPark = new GameObject("pickUpCap", 2.5f, 3.5f, 1, false, "flipCap", "pickUpRedCapNearFlagPark");
            GameObject pickUpBlueCapNearFlag = new GameObject("pickUpCap", 4.5f, 4.5f, 1, false, "flipCap", "pickUpBlueCapNearFlag");
            GameObject pickUpBlueCapNearWall = new GameObject("pickUpCap", 3.5f, 0.5f, 1, false, "flipCap", "pickUpBlueCapNearWall");
            GameObject pickUpBlueCapNearWallPark = new GameObject("pickUpCap", 3.5f, 2.5f, 1, false, "flipCap", "pickUpBlueCapNearWallPark");
            GameObject pcikUpBlueCapNearFlagPark = new GameObject("pickUpCap", 3.5f, 3.5f, 1, false, "flipCap", "pcikUpBlueCapNearFlagPark");
            GameObject pickUpBallRedCapNearFlag1 = new GameObject("pickUpBall", 1.25f, 4.5f, 1, false, "", "pickUpBallRedCapNearFlag1");
            GameObject pickUpBallRedCapNearFlag2 = new GameObject("pickUpBall", 1.75f, 4.5f, 1, false, "", "pickUpBallRedCapNearFlag2");
            GameObject pickUpBallBlueCapNearFlag1 = new GameObject("pickUpBall", 4.25f, 4.5f, 1, false, "", "pickUpBallBlueCapNearFlag1");
            GameObject pickUpBallBlueCapNearFlag2 = new GameObject("pickUpBall", 4.75f, 4.5f, 1, false, "", "pickUpBallBlueCapNearFlag2");
            GameObject pickUpBallRedCapNearFlagPark = new GameObject("pickUpBall", 2.5f, 3.5f, 1, false, "", "pickUpBallRedCapNearFlagPark");
            GameObject pickUpBallRedCapNearWallPark = new GameObject("pickUpBall", 2.5f, 2.5f, 1, false, "", "pickUpBallRedCapNearWallPark");
            GameObject pickUpBallBlueCapNearFlagPark = new GameObject("pickUpBall", 3.5f, 3.5f, 1, false, "", "pickUpBallBlueCapNearFlagPark");
            GameObject pickUpBallBlueCapNearWallPark = new GameObject("flipCap", 3.5f, 2.5f, 1, false, "", "pickUpBallBlueCapNearWallPark");
            GameObject pickUpBallBlueCapNearWall1 = new GameObject("flipCap", 3.25f, 0.5f, 1, false, "", "pickUpBallBlueCapNearWall1");
            GameObject pickUpBallBlueCapNearWall2 = new GameObject("flipCap", 3.75f, 0.5f, 1, false, "", "pickUpBallBlueCapNearWall2");
            GameObject pickUpBallRedCapNearWall1 = new GameObject("flipCap", 2.25f, 0.5f, 1, false, "", "pickUpBallRedCapNearWall1");
            GameObject pickUpBallRedCapNearWall2 = new GameObject("flipCap", 2.75f, 0.5f, 1, false, "" , "pickUpBallRedCapNearWall2");
            //All Stacking Actions
            GameObject redHighStack = new GameObject("stackCapHigh", 0f, 3f, 1, false, "pickUpCap", "redHighStack");
            GameObject redLowStackDriverSide = new GameObject("stackCapLow", 0f, 1f, 1, false, "pickUpCap", "redLowStackDriverSide");
            GameObject redLowStackOppFlag = new GameObject("stackCapLow", 1.5f, 0f, 1, false, "pickUpCap", "redLowStackOppFlag");
            GameObject blueHighStack = new GameObject("stackCapHigh", 6f, 3f, 1, false, "pickUpCap", "blueHighStack");
            GameObject blueLowStackDriverSide = new GameObject("stackCapLow", 6f, 1f, 1, false, "pickUpCap", "blueLowStackDriverSide");
            GameObject blueLowStackOppFlag = new GameObject("stackCapLow", 4.5f, 0f, 1, false, "pickUpCap", "blueLowStackOppFlag");

            //Adds all the game objects to a list 
            gameObjects.Add(redTopFlag);
            gameObjects.Add(redMidFlag);
            gameObjects.Add(redBotFlag);
            gameObjects.Add(neutralTopFlag);
            gameObjects.Add(neutralMidFlag);
            gameObjects.Add(neutralBotFlag);
            gameObjects.Add(blueTopFlag);
            gameObjects.Add(blueMidFlag);
            gameObjects.Add(blueBotFlag);
            gameObjects.Add(redCapNearFlag);
            gameObjects.Add(redCapNearWall);
            gameObjects.Add(redCapNearWallPark);
            gameObjects.Add(redCapNearFlagPark);
            gameObjects.Add(blueCapNearFlag);
            gameObjects.Add(blueCapNearWall);
            gameObjects.Add(blueCapNearWallPark);
            gameObjects.Add(blueCapNearFlagPark);
            gameObjects.Add(pickUpRedCapNearFlag);
            gameObjects.Add(pickUpRedCapNearWall);
            gameObjects.Add(pickUpRedCapNearWallPark);
            gameObjects.Add(pickUpRedCapNearFlagPark);
            gameObjects.Add(pickUpBlueCapNearFlag);
            gameObjects.Add(pickUpBlueCapNearWall);
            gameObjects.Add(pickUpBlueCapNearWallPark);
            gameObjects.Add(pcikUpBlueCapNearFlagPark);
            gameObjects.Add(pickUpBallRedCapNearFlag1);
            gameObjects.Add(pickUpBallRedCapNearFlag2);
            gameObjects.Add(pickUpBallBlueCapNearFlag1);
            gameObjects.Add(pickUpBallBlueCapNearFlag2);
            gameObjects.Add(pickUpBallRedCapNearFlagPark);
            gameObjects.Add(pickUpBallRedCapNearWallPark);
            gameObjects.Add(pickUpBallBlueCapNearFlagPark);
            gameObjects.Add(pickUpBallBlueCapNearWallPark);
            gameObjects.Add(pickUpBallBlueCapNearWall1);
            gameObjects.Add(pickUpBallBlueCapNearWall2);
            gameObjects.Add(pickUpBallRedCapNearWall1);
            gameObjects.Add(pickUpBallRedCapNearWall2);
            gameObjects.Add(redHighStack);
            gameObjects.Add(redLowStackDriverSide);
            gameObjects.Add(redLowStackOppFlag);
            gameObjects.Add(blueHighStack);
            gameObjects.Add(blueLowStackDriverSide);
            gameObjects.Add(blueLowStackOppFlag);
        }
    }
}
