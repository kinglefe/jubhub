using System;
using System.Collections.Generic;
namespace Jubulant
{
    public class blackMarketVendor : Room
    {
        public static Dictionary<string, Item> blackMarketinventory;


        public blackMarketVendor(string _name, string _shortName) : base(_name, _shortName)
        {
            blackMarketinventory = new Dictionary<string, Item>();
            createInventory();
            createScenarios();
        }

        private void createScenarios()
        {
            scenarioBox.Add(new Scenario("\nYour friend is overdosing on crack. What's next?\na) call an ambulance\nb) keep walking\nc) check on them\n", new List<int>() { 15, 0, 30 }));
            scenarioBox.Add(new Scenario("\nThere is a strange man following you. What's next?\na) run\nb) call the police\nc) keep walking\n", new List<int>() { 40, 10,25 }));
            scenarioBox.Add(new Scenario("\nThere are black market organs on the ground on your way out. Do you report it or puke?\na) return\nb) puke\n", new List<int>() { 20 , 30 }));
        }


        private void createInventory()
        {
            // adding the items 
            Item drugs = new Item("drugs", 10, 20, 100, true, 2.0);
            Item organs = new Item("organs", 40, 15, 5, true, 10);
            Item liftedTV = new Item("TV", 75, 0, 10, true, 80);

            Item health = new Item("health", 15, 20, 5, true, 0);
            Item food  = new Item("food", 40, 15, 5, true, 5);




            // putting them in inventory 
            blackMarketinventory.Add(drugs.ItemName, drugs);
            blackMarketinventory.Add(organs.ItemName, organs);
            blackMarketinventory.Add(liftedTV.ItemName, liftedTV);
            blackMarketinventory.Add(health.ItemName, health);
            blackMarketinventory.Add(food.ItemName, food);


        }

        public string displayInventory()
        {
            string output = "";
            foreach (Item item in blackMarketinventory.Values)
            {
                output += "\n" + item.ItemName + ": " + item.quantity + " which costs " + item.price + " points";
            }
            return output;
        }

    }
}

