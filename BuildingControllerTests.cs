using System;
using TestBuildingController;



namespace TestBuildingController
{
    class BuildingControllerTests
    {
        static void Main(string[] args)
        {

            BuildingController bc1 = new BuildingController();                              // test new building controller creation with no Parameters
            BuildingController bc2 = new BuildingController("CT001");                       // test new building controller only a buildingID  
            BuildingController bc3 = new BuildingController("Item3", "cheese");             // test new building controller only a buildingID  and current State

            


        }
        
    }

   
}
