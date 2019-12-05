using System;
using System.Collections;
using System.Collections.Generic;
namespace Jubulant
{
    public class Player
    {
        private Room _currentRoom;
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
        private Stack<Room> backCommand;
        private Dictionary<string, Item> personalInventory;
        public ScenarioCenter scenarios;
        public Scenario currentScenario;

        Bank myBank;
        Health myHealth;

        public Player(Room room)//, GameOutput output)
        {
            _currentRoom = room;
            myBank = new Bank();
            myHealth = new Health();
            personalInventory = new Dictionary<string, Item>();
            scenarios = new ScenarioCenter();
            backCommand = new Stack<Room>(10);
            
        }

        public void outputMessage(string message)
        {
            Console.WriteLine(message);
        }
        public void waltTo(string direction)
        {
 
            Room nextRoom = this._currentRoom.getExit(direction);
            if (nextRoom != null)
            {
                backCommand.Push(currentRoom);
                this._currentRoom = nextRoom;
                // Player posts a notification PlayerEnteredRoom
                //NotificationCenter.Instance.postNotification(new Notification("PlayerEnteredRoom", this));
                this.outputMessage("\n" + this._currentRoom.description());
                currentRoom.displayRoomInventory();
                myHealth.defaultFall();
                this.outputMessage("New Health Balance: " + myHealth.HealthPoints);
                currentRoom.displayScenarios();
            }
            else
            {
                this.outputMessage("\nThere is no exit called " + direction);
            }
        }

        public void back()
        {
            Room prev;
            backCommand.TryPeek(out prev);
            if (prev != null)
            {
                waltTo(prev.shortName);
            }
            else
            {
                outputMessage("You don't have any previous rooms.");
            }
        }

        public void answer(int choice)
        {
            List<int> ans = currentRoom.currentScenario.answers;
            
            if (choice == 1)
            {
                myBank.addPoints(ans[0]);
                outputMessage("Reward: " + ans[0]);
                outputMessage("New Bank Balance: " + myBank.Balance);    
            } else if ( choice == 2)
            {
                myBank.addPoints(ans[1]);
                outputMessage("Reward: " + ans[1]);
                outputMessage("New Bank Balance: " + myBank.Balance);
            } else
            {
                if (ans.Count > 2)
                {
                    myBank.addPoints(ans[2]);
                    outputMessage("Reward: " + ans[2]);
                    outputMessage("New Bank Balance: " + myBank.Balance);
                }
         
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

        

        public void speak(String word)
        {
            outputMessage(word);
        }

        public void buy(string _itemName)
        { 
            if (blackMarketVendor.blackMarketinventory.ContainsKey(_itemName))
            {
                Item marketItem;
                blackMarketVendor.blackMarketinventory.TryGetValue(_itemName, out marketItem);
                if (personalInventory.ContainsKey(_itemName) ){
                    Item myItem;
                    personalInventory.TryGetValue(_itemName, out myItem);
                    if (myItem.quantity >= 0 && marketItem.canBuy)
                    {
                        myItem.increase(marketItem.quantity);
                        myBank.withdrawPoints(marketItem.price);
                        displayInventory();

                    }
                }
                else if (marketItem.price < myBank.Balance && marketItem.quantity >= 1)
                {
                    if (marketItem.canBuy == true)
                    {
                        personalInventory.Add(_itemName, marketItem);
                        myBank.withdrawPoints(marketItem.price);
                        outputMessage("New Balance: " + myBank.getBalance());
                        displayInventory();
                    }
                    
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
            Item food;
            personalInventory.TryGetValue(_food, out food);
            if (personalInventory.ContainsKey(_food) && food.ItemName.Equals("food"))
            {
    
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

