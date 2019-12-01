using System;
using System.Collections.Generic;
namespace Jubulant
{
    public class WorkPlace : Room
    {
        public List<Scenario> scenarios;
        public WorkPlace(string _roomName, string _shortName) : base(_roomName,_shortName)
        {
            scenarios = new List<Scenario>();
        }


        // come back to me

        /* the purpose of this class is to start scenarios when the player has entered the room
         * using the scenario class
         */
    }
}
