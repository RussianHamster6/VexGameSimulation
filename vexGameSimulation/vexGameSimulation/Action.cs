using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vexGameSimulation
{
    class Action
    {
        //Creating the auto implemented properties for the variables stated below so that they can be created by the constructor function that will be made after these.

        public string actionName { get; set; } 
        public float timeToComplete { get; set; }
        public float probOfSuccess { get; set; }
        public bool canDoAction { get; set; }

        //Here is the constructor so that I can create actions with this template
        public Action(string name, float time, float prob, bool canDoAc)
        {
            actionName = name; //Assigns name value from function to the actionName of the object
            timeToComplete = time; //Assigns time value from function to the timeToComplete of the object 
            probOfSuccess = prob; //Assigns prob value from function to the probOfSuccess of the object
            canDoAction = canDoAc; //Assigns canDoAc from function to the canDoAction of the object
        }

        //Assigns the getter functions so that I can get the properties of an object from the object later
        public string GetActionName() { return actionName; } 
        public float GetTimeToComplete() { return timeToComplete; }
        public float GetProbOfSuccess() { return probOfSuccess; }
        public bool GetCanDoAction() { return canDoAction; }
    }
}


