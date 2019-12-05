using System;
using System.Collections.Generic;
namespace Jubulant
{ 
    public class Mall : Room
    {
        public Mall(string _name, string _short) : base(_name, _short)
        {
            createScenarios();
        }
        private void createScenarios()
        {
            scenarioBox.Add(new Scenario("The cops are chasing a thief, they yell for you to stop him. What's next?\n\t1) what do I look like a mall cop to ya\n\t2) trip him up", new List<int> { 30, 15 }));
            scenarioBox.Add(new Scenario("You like some music in the shop, but don't have any money. What's next?\n\t1) steal it\n\t2) save up for it", new List<int> { 10, 20}));
            scenarioBox.Add(new Scenario("Your friend bought you some food. What's next?\n\t1) thank them\n\t2) try to pay them back later", new List<int> { 30, 13 }));
        }
    }
}
