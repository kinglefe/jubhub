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


        Bank myBank;

        public Player(Room room)//, GameOutput output)
        {
            _currentRoom = room;
            myBank = new Bank();
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
                myBank.Balance -= 15;
            }
            else
            {
                this.outputMessage("\nThere is no exit called " + direction);
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

        /*public bool buy(string _itemName)
        {
            if (currentRoom.shortName == "market" && myBank.Balance > 0)
            {
                currentRoom
            }
        }*/

    }
}

