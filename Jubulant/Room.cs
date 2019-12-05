using System;
using System.Collections.Generic;
namespace Jubulant
{
    public class Room
    {
        private Dictionary<string, Room> exits;
        //private Dictionary<string, iItem> items;
        public List<Item> roomInventory;
        public List<Scenario> scenarioBox;
        public Scenario currentScenario;
        private string _tag;
        public string Tag
        {
            get
            {
                return _tag;
            }
            set
            {
                _tag = value;
            }
        }
        public string shortName { get; set; }

        public Room() : this("No Tag")
        {

        }

        public Room(string tag) : this(tag, "short")
        {

        }
        public Room(string _tag, string shortName)
        {
            exits = new Dictionary<string, Room>();
            this.Tag = _tag;
            this.shortName = shortName;
            scenarioBox = new List<Scenario>();
            roomInventory = new List<Item>();
        }
        public void setExit(string exitName, Room room)
        {
            exits[exitName] = room;
        }

        public Room getExit(string exitName)
        {
            Room room = null;
            exits.TryGetValue(exitName, out room);
            return room;
        }

        public string getExits()
        {
            string exitNames = "Exits: ";
            Dictionary<string, Room>.KeyCollection keys = exits.Keys;
            foreach (string exitName in keys)
            {
                exitNames += " " + exitName;
            }
            return exitNames;
        }

        public void displayRoomInventory()
        {
            if (roomInventory.Count > 0)
            {
                Console.WriteLine("Room Inventory: \n");
                foreach (Item i in roomInventory)
                {
                    Console.WriteLine("\t" + i.ItemName);
                }
            } else
            {
                Console.WriteLine("There is no inventory in " + shortName);
            }
        }
        public void displayScenarios()
        {
            if (scenarioBox.Count != 0)
            {
                Random rand = new Random();
                currentScenario = scenarioBox[rand.Next(0, 2)];

                Console.WriteLine(currentScenario._Scenario);
            }
            else
            {
                Console.WriteLine("No scenarios in this room.");
            }
            
        }

        public string description()
        {
            return "You are " + this.Tag + ".\n *** " + this.getExits();
        }
    }
}
