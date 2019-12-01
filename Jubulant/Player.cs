using System;
using System.Collections.Generic;
namespace Jubulant
{
    public class Player
    {
        private Room _currentRoom = null;
        public Room currentRoom
        {
            get
            {
                return _currentRoom;
            }
            set
            {
                _currentRoom = value;
            }
        }
        private Dictionary<string, Item> personalInventory;
        public ScenarioCenter scenarios;

        Bank myBank;
        Health myHealth;

        public Player(Room room)//, GameOutput output)
        {
            _currentRoom = room;
            myBank = new Bank();
            myHealth = new Health();
            personalInventory = new Dictionary<string, Item>();
            scenarios = new ScenarioCenter();

        }

        public void waltTo(string direction)
        {
            Room nextRoom = this._currentRoom.getExit(direction);
            if (nextRoom != null)
            {
                this._currentRoom = nextRoom;
                // Player posts a notification PlayerEnteredRoom
                NotificationCenter.Instance.postNotification(new Notification("PlayerEnteredRoom", this));
                this.outputMessage("\n" + this._currentRoom.description());
                myHealth.defaultFall();
                this.outputMessage("New Health Balance: " + myHealth.HealthPoints);
                scenarios.display();
            }
            else
            {
                this.outputMessage("\nThere is no exit called " + direction);
            }
        }

        public void displayInventory()
        {
            outputMessage("----------PERSONAL INVENTORY----------");
            if (personalInventory.Count >= 1)
            {
                foreach (Item myItem in personalInventory.Values)
                {

                    outputMessage("" + myItem.ItemName + "...... Q: " + myItem.quantity);

                }  
            }
            
        }
        public double getBalance()
        {
            return myBank.Balance;
        }

        public void outputMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void speak(String word)
        {
            outputMessage(word);
        }

        public void buy(string _itemName)
        { 
            if (Market.inventory.ContainsKey(_itemName))
            {
                Item marketItem;
                Market.inventory.TryGetValue(_itemName, out marketItem);
                if (personalInventory.ContainsKey(_itemName)){
                    Item myItem;
                    personalInventory.TryGetValue(_itemName, out myItem);
                    if (myItem.quantity >= 0)
                    {
                        myItem.increase(marketItem.quantity);
                        myBank.withdrawPoints(marketItem.price);
                        displayInventory();

                    }
                }
                else if (marketItem.price < myBank.Balance && marketItem.quantity >= 1)
                {
                    personalInventory.Add(_itemName, marketItem);
                    myBank.withdrawPoints(marketItem.price);
                    outputMessage("New Balance: " + myBank.getBalance());
                    displayInventory();
                    
                } else
                {
                    outputMessage("\nYou don't have enough points in your bank for " + marketItem.ItemName + " with a bank balance of " + myBank.getBalance());
                } 
            } else
            {
                outputMessage("\nBuy What??");
            }
        }

        public void eat(string _food)
        {
            if (personalInventory.ContainsKey(_food))
            {
                Item food;
                personalInventory.TryGetValue(_food, out food);
                if (food.quantity >= 1)
                {
                    myHealth.healthIncrease(15);
                    outputMessage("Your Health is now: " + myHealth.HealthPoints);
                } else
                {
                    myHealth.healthFall(5);
                    outputMessage("Your Health is now: " + myHealth.HealthPoints); 
                }

            }
        }

    }
}

