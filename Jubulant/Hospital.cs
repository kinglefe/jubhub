using System;
using System.Collections.Generic;
namespace Jubulant
{
    public class Hospital : Room
    {
        public Hospital(string _name, string sho) :base(_name, sho)
        {
            createScenarios();
        }

        private void createScenarios()
        {
            scenarioBox.Add(new Scenario("There is free donuts in the hospital. Someone coughed on them. What's next?\n\t1) they can have it :(\n\t2) get the cleanest looking one", new List<int> { 20, 2 }));
            scenarioBox.Add(new Scenario("Your mom is unfortunately in the hospital and needs a blood transfusion. What's next?\n\t1) duh, she can have it :)\n\t2) wait", new List<int> { 40, 0 }));
            scenarioBox.Add(new Scenario("You are visiting a friend and notice that the nurse is giving him unnecessary shots. What's next?\n\t1) report her :(\n\t2) Lock Door, dial Doctor", new List<int> { 20, 40 }));
        }
    }
}
