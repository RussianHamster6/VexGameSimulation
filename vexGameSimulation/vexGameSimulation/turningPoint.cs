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

        //initialises all the objects in the game simulation
        //All Flag actions
        public List<GameObject> gameObjects = new List<GameObject>();
        //Constructor
        public turningPoint()
        {

            GameObject redTopFlag = new GameObject("hitTopFlag", 1f, 5.5f, 2, false, "pickUpBall");
            GameObject redMidFlag = new GameObject("hitMidFlag", 1f, 5.5f, 2, false, "pickUpBall");
            GameObject redBotFlag = new GameObject("hitBotFlag", 1f, 5.5f, 1, false, "pickUpBall");
            GameObject neutralTopFlag = new GameObject("hitTopFlag", 3f, 5.5f, 2, false, "pickUpBall");
            GameObject neutralMidFlag = new GameObject("hitMidFlag", 3f, 5.5f, 2, false, "pickUpBall");
            GameObject neutralBotFlag = new GameObject("hitBotFlag", 3f, 5.5f, 2, false, "pickUpBall");
            GameObject blueTopFlag = new GameObject("hitTopFlag", 5f, 5.5f, 2, true, "pickUpBall");
            GameObject blueMidFlag = new GameObject("hitMidFlag", 5f, 5.5f, 2, true, "pickUpBall");
            GameObject blueBotFlag = new GameObject("hitBotFlag", 5f, 5.5f, 2, true, "pickUpBall");
            //All Flipping Cap Actions
            GameObject redCapNearFlag = new GameObject("flipCap", 1.5f, 4.5f, 1, false, "");
            GameObject redCapNearWall = new GameObject("flipCap", 2.5f, 0.5f, 1, false, "");
            GameObject redCapNearWallPark = new GameObject("flipCap", 2.5f, 2.5f, 1, false, "");
            GameObject redCapNearFlagPark = new GameObject("flipCap", 2.5f, 3.5f, 1, false, "");
            GameObject blueCapNearFlag = new GameObject("flipCap", 4.5f, 4.5f, 1, false, "");
            GameObject blueCapNearWall = new GameObject("flipCap", 3.5f, 0.5f, 1, false, "");
            GameObject blueCapNearWallPark = new GameObject("flipCap", 3.5f, 2.5f, 1, false, "");
            GameObject blueCapNearFlagPark = new GameObject("flipCap", 3.5f, 3.5f, 1, false, "");
            //All Picking Up Actions
            GameObject pickUpRedCapNearFlag = new GameObject("pickUpCap", 1.5f, 4.5f, 1, false, "flipCap");
            GameObject pickUpRedCapNearWall = new GameObject("pickUpCap", 2.5f, 0.5f, 1, false, "flipCap");
            GameObject pickUpRedCapNearWallPark = new GameObject("pickUpCap", 2.5f, 2.5f, 1, false, "flipCap");
            GameObject pickUpRedCapNearFlagPark = new GameObject("pickUpCap", 2.5f, 3.5f, 1, false, "flipCap");
            GameObject pickUpBlueCapNearFlag = new GameObject("pickUpCap", 4.5f, 4.5f, 1, false, "flipCap");
            GameObject pickUpBlueCapNearWall = new GameObject("pickUpCap", 3.5f, 0.5f, 1, false, "flipCap");
            GameObject pickUpBlueCapNearWallPark = new GameObject("pickUpCap", 3.5f, 2.5f, 1, false, "flipCap");
            GameObject pcikUpBlueCapNearFlagPark = new GameObject("pickUpCap", 3.5f, 3.5f, 1, false, "flipCap");
            GameObject pickUpBallRedCapNearFlag1 = new GameObject("pickUpBall", 1.25f, 4.5f, 1, false, "");
            GameObject pickUpBallRedCapNearFlag2 = new GameObject("pickUpBall", 1.75f, 4.5f, 1, false, "");
            GameObject pickUpBallBlueCapNearFlag1 = new GameObject("pickUpBall", 4.25f, 4.5f, 1, false, "");
            GameObject pickUpBallBlueCapNearFlag2 = new GameObject("pickUpBall", 4.75f, 4.5f, 1, false, "");
            GameObject pickUpBallRedCapNearFlagPark = new GameObject("pickUpBall", 2.5f, 3.5f, 1, false, "");
            GameObject pickUpBallRedCapNearWallPark = new GameObject("pickUpBall", 2.5f, 2.5f, 1, false, "");
            GameObject pickUpBallBlueCapNearFlagPark = new GameObject("pickUpBall", 3.5f, 3.5f, 1, false, "");
            GameObject pickUpBallBlueCapNearWallPark = new GameObject("flipCap", 3.5f, 2.5f, 1, false, "");
            GameObject pickUpBallBlueCapNearWall1 = new GameObject("flipCap", 3.25f, 0.5f, 1, false, "");
            GameObject pickUpBallBlueCapNearWall2 = new GameObject("flipCap", 3.75f, 0.5f, 1, false, "");
            GameObject pickUpBallRedCapNearWall1 = new GameObject("flipCap", 2.25f, 0.5f, 1, false, "");
            GameObject pickUpBallRedCapNearWall2 = new GameObject("flipCap", 2.75f, 0.5f, 1, false, "");
            //All Stacking Actions
            GameObject redHighStack = new GameObject("stackCapHigh", 0f, 3f, 1, false, "pickUpCap");
            GameObject redLowStackDriverSide = new GameObject("stackCapLow", 0f, 1f, 1, false, "pickUpCap");
            GameObject redLowStackOppFlag = new GameObject("stackCapLow", 1.5f, 0f, 1, false, "pickUpCap");
            GameObject blueHighStack = new GameObject("stackCapHigh", 6f, 3f, 1, false, "pickUpCap");
            GameObject blueLowStackDriverSide = new GameObject("stackCapLow", 6f, 1f, 1, false, "pickUpCap");
            GameObject blueLowStackOppFlag = new GameObject("stackCapLow", 4.5f, 0f, 1, false, "pickUpCap");

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
