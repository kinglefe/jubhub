using System;
namespace Jubulant
{
    public class Item
    {
        private string itemName;
        public string ItemName { get; set; }

        public int price;
        

        private bool canBuy;
        public bool CanBuy { get; set; }


        public Item() : this("No Item")
        {
        }
        public Item(string _itemName) : this(_itemName, 0, true)
        {

        }
        public Item(string _itemName, int _price, bool _canBuy) 
        {
            ItemName = _itemName;
            price = _price;
            CanBuy = _canBuy;
        }
    }
}

/*
 * be able to have a name of item
 * price of item
 * deal with whether this item can be bought
 */