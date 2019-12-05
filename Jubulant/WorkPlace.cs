using System;
using System.Collections.Generic;
namespace Jubulant
{
    public class WorkPlace : Room
    {
        
        public WorkPlace(string _roomName, string _shortName) : base(_roomName,_shortName)
        {
            createScenarios();
        }

        private void createScenarios()
        {
            scenarioBox.Add(new Scenario("\nYou are allowed to work from home. Do you: \n\t1) do it\n\t2) enjoy the day", new List<int>() { 15, 10 }));
            scenarioBox.Add(new Scenario("\nThere is a new employee on the floor. What's next?\n\t1) introduce yourself\n\t2) mind your own business.", new List<int>() { 40, 15 }));
            scenarioBox.Add(new Scenario("\nYour team is working on a project. Do you \n\t1) work peacfully \n\t2) find new ways to be productive.", new List<int>() { 30, 25 }));
        }
        // come back to me

        /* the purpose of this class is to start scenarios when the player has entered the room
         * using the scenario class
         */
    }
}
