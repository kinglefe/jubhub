using System;
using System.Collections.Generic;
namespace Jubulant
{
    public class Market : Room
    {
        Dictionary<string, Item> inventory;
        
        public Market(string _name, string _shortName) : base(_name, _shortName)
        {
            inventory = new Dictionary<string, Item>();
        }

        public void createInventory()
        {
            Item health = new Item("health", 15, true);
            Item food = new Item("food", 40, true);

            inventory.Add(health.ItemName, health);
            inventory.Add(food.ItemName, health);
        }

        
    }
}


/*
 * the market should hold an inventory of things
 * a way to buy and take out item from inventory
 * charges the player 
 */