using System;
namespace Jubulant
{
    public class Home : Room
    {
        public Home(string _name, string _short) : base(_name, _short)
        {
            createInventory();
        }

        public void createInventory()
        {
            roomInventory.Add(new Item("Couch"));
            roomInventory.Add(new Item("Bed"));
            roomInventory.Add(new Item("Fridge"));
            roomInventory.Add(new Item("trash"));
        }
    }
}
