using System;
using System.Collections.Generic;
namespace Jubulant
{
    public class BankRoom : Room
    {
      
        public BankRoom(string _name, string _short) : base(_name, _short)
        {
            createScenarios();
            createInventory();
        }

        private void createScenarios()
        {
            scenarioBox.Add(new Scenario("\nThe Bank is being robbed. What's next? \na) call 911\nb) try and leave\nc) follow instructions\n",new List<int>() {0, 10, 25 }));
            scenarioBox.Add(new Scenario("\nYou are parking in the parking, trying to find a spot. You find one but there is another car waiting for for it. What's next?\na) find another spot\nb) call the police\nc) take the chance\n", new List<int>() {15, 1, 40 }));
            scenarioBox.Add(new Scenario("\nYou are paying at the register and you come up short on the total. Do you run or put something back?\na) steal\nb) return the item\n", new List<int>() { 25, 20 }));
        }

        private void createInventory()
        {
            roomInventory.Add(new Item("ATM"));
            roomInventory.Add(new Item("TellerStation"));
            roomInventory.Add(new Item("Vault"));

        }
    } 
}