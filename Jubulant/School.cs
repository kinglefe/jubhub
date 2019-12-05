using System;
using System.Collections.Generic;
namespace Jubulant
{
    public class School : Room
    {
        public School(string _name, string _short) : base(_name, _short)
        {
            createScenarios();
        }

        private void createScenarios()
        {
            scenarioBox.Add(new Scenario("You are given a bad grade. What's next?\n\t1) ask the professor\n\t2) take it", new List<int>() { 20, 10}));
            scenarioBox.Add(new Scenario("They charged you double tuition. What's next?\n\t1) go off\n\t2) check the financial aid office.", new List<int> { 20, 25}));
            scenarioBox.Add(new Scenario("There is free food in the cafe. They not wearing gloves with the food thoo. What's next?\n\t1) they can have it :(\n\t2) get the cleanest looking one", new List<int> { 20, 2 }));
        }
    }
}
