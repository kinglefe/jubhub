using System;
using System.Collections.Generic;
namespace Jubulant
{
    public class Market : Room
    {
        public static Dictionary<string, Item> inventory;
        public ScenarioCenter scenarios;

        public Market(string _name, string _shortName) : base(_name, _shortName)
        {
            inventory = new Dictionary<string, Item>();
            createInventory();
            scenarios = new ScenarioCenter();
        }

        private void createScenarios()
        {
            ScenarioCenter.Instance.addScenario("You see an old lady on the floor, What do you do first?", ["help her", "call 911", "keep shopping"], 5);
        }

        private void createInventory()
        {
            // adding the items 
            Item health = new Item("health", 15, 20, 5);
            Item food = new Item("food", 40, 15, 5);
            

            
            // putting them in inventory 
            inventory.Add(health.ItemName, health);
            inventory.Add(food.ItemName, food);

            
        }

        public string displayInventory()
        {
            string output = "";
            foreach (Item item in inventory.Values)
            {
                output += "\n" + item.ItemName + ": " + item.quantity + " which costs " + item.price + " points";
            }
            return output;
        }
        
    }
}


/*
 * the market should hold an inventory of things
 * a way to buy and take out item from inventory
 * charges the player 
 */