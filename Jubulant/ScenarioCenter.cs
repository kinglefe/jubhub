using System;
using System.Collections.Generic;
using System.Linq;
namespace Jubulant
{
    public class ScenarioCenter
    {
        public List<Scenario> scenarios;
        public Scenario currentScenario;
        
        public ScenarioCenter()
        {
            scenarios = new List<Scenario>();
            
            
        }


        public void addScenario( Scenario scenario)
        {
            scenarios.Add(scenario);
        }

        public void removeScenario(Scenario scenario)
        {
            scenarios.Remove(scenario);
            
        }
        
       
    }
}
/* this class should
 * be able to create scenarios
 * be able to display scenarios
 */
