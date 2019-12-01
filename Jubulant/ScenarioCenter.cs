using System;
using System.Collections.Generic;
namespace Jubulant
{
    public class ScenarioCenter
    {
        List<Scenario> scenarios;
        private static ScenarioCenter _instance;
        public static ScenarioCenter Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ScenarioCenter();
                }
                return _instance;
            }
        }
        
        public ScenarioCenter()
        {
            scenarios = new List<Scenario>();
            
        }

        
        public void addScenario(string _question, string[] _answer, int _points)
        {
            scenarios.Add(new Scenario(_question, _answer, _points));
        }
        public void removeScenario(Scenario scenario)
        {
            scenarios.Remove(scenario);
        }
        public void display()
        {
            foreach (Scenario scenario in scenarios)
            {
                user.outputMessage("Answer with the 'answer' command (1,2,3)");
                user.outputMessage(scenario._Scenario);

                List<String> answ = scenario.getAnswers();
                foreach (string res in answ)
                {
                    user.outputMessage("Choice: " + res);

                }
                removeScenario(scenario);
            } 
        }
       
    }

    
}
/* this class should
 * be able to create scenarios
 * be able to display scenarios
 */
