using System;
using System.Collections;
using System.Collections.Generic;
namespace Jubulant
{
    public class Market : Room
    {
        public static Dictionary<string, Item> inventory;
        

        public Market(string _name, string _shortName) : base(_name, _shortName)
        {
            inventory = new Dictionary<string, Item>();
            createScenarios();
        }

        private void createScenarios()
        {
            scenarioBox.Add(new Scenario("\nThe Bank is being robbed. What's next? \n\t1) call 911\n\t2) try and leave\n\t3) hide\n", new List<int>() { 10, 5, 20 }));
            scenarioBox.Add(new Scenario("\nYou are parking in the parking, trying to find a spot. You find one but there is another car waiting for for it. What's next?\n\t1) find another spot\n\t2) call the police\n\t3) take the chance\n", new List<int>() { 15, 1, 40 }));
            scenarioBox.Add(new Scenario("\nYou are paying at the register and you come up short on the total. Do you steal or put something back?\n\t1) steal\n\t2) return the item\n", new List<int>() { 25, 20 }));
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
