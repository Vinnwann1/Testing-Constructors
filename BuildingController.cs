using System;
using System.Collections.Generic;
using System.Text;

namespace TestBuildingController
{
    class BuildingController
    {
        public static int BuildingUniqueID = 0;            //Create a Unique ID for BuildingID
        public int mybuildingid = 0;
        public int Mybuildingid
        {
            get
            {
                return mybuildingid;
            }
        }
        public string buildingID;                                        //declare Name Data type string
        public string  currentState;                              //declare status Data type string
        public bool currentStateState;                              //declare status Data type boolean
        public string defaultname = "requires name";             // Default name when not set

        public BuildingController()                             // constructor if function is called with no parameters
        {

            BuildingUniqueID++;
            this.mybuildingid = BuildingUniqueID;
            this.buildingID = SetBuildingID(defaultname);
            this.currentState = "out of hours";
            this.currentStateState = SetCurrentState();
            Console.WriteLine(Display());
        }
        public BuildingController(string name)                  // constructor if function is called with name  parameter
        {
            BuildingUniqueID++;
            this.mybuildingid = BuildingUniqueID;
            this.buildingID = SetBuildingID(name);
            this.currentState = "out of hours";
            this.currentStateState = SetCurrentState();
            Console.WriteLine(Display());


        }
        public BuildingController(string name, string status)       // constructor if function is called with name & status parameters
        {
            BuildingUniqueID++;
            this.mybuildingid = BuildingUniqueID;
            this.buildingID = SetBuildingID(name);
            this.currentState = status;
            this.currentStateState = SetCurrentState();
           Console.WriteLine(Display());
        }

        //Functions
        string SetBuildingID(string Text)              // Function Converts uppercase character to lowercase.
        {
            string str1;
            char[] arr1;
            int l, i;
            l = 0;
            str1 = Text;
            l = str1.Length;
            arr1 = str1.ToCharArray(0, l);                 
            for (i = 0; i < l; i++)                         //  Loop Trough text per single char
            {
                arr1[i] = Char.ToLower(arr1[i]);            // Converts uppercase character to lowercase one letter at a time
            }
            string s = string.Join("", arr1);               // convert array to string
            return s;
        }
        public string Display()                             //Display Attributes
        {
            return "| ID:" + this.mybuildingid + "| Building Name:" + this.buildingID + "| Current State: '" + GetCurrentState() + "' " + this.currentStateState + "| ";
        }

        public string GetCurrentState()                 //get currentState
        {
            return this.currentState;
        }

        public bool SetCurrentState()                   //Set currentState and return true or false
        {
            if (this.currentState == "closed" || this.currentState == "out of hours" || this.currentState == "out of hours" || this.currentState == "open" || this.currentState == "fire drill" || this.currentState == "fire alarm")
            {
                return true;
            }
            else
                return false;
        }


    }




}




