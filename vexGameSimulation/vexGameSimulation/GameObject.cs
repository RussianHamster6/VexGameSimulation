using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vexGameSimulation
{
    class GameObject
    {
        //Creates the auto implemented properties for the below properties so that they can be later created in a constructor in the template
        public string requiredAction { get; set; }
        public float Xlocation { get; set; }
        public float Ylocation { get; set; }
        public int pointVal { get; set; }
        public bool beenScored { get; set; }

        //Constructor function to create a new GameObject
        public GameObject(string reqAction, float X, float Y, int points, bool scored)
        {
            requiredAction = reqAction;
            Xlocation = X;
            Ylocation = Y;
            pointVal = points;
            beenScored = scored;
        }

        //Getter functions to return the specified property of the GameObject
        public string GetRequiredAction() { return requiredAction; }
        public float GetXlocation() { return Xlocation; }
        public float GetYlocation() { return Ylocation; }
        public int GetPointVal() { return pointVal; }
        public bool GetBeenScored() { return beenScored; }
    }
}


