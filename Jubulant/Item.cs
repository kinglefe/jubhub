using System;
namespace Jubulant
{
    public class Item
    {
        private string itemName;
        public string ItemName { get; set; }

        public int price;


        private int healthScore;
        public int HealthScore { get; set; }

        public int quantity { get; set; }

        public Item() : this("No Item")
        {
        }
        public Item(string _itemName) : this(_itemName, 0, 10, 1)
        {

        }
        public Item(string _itemName, int _price, int _healthPoints, int _quantity) 
        {
            ItemName = _itemName;
            price = _price;
            HealthScore = _healthPoints;
            quantity = _quantity; 
        }

        public void decrease(int points)
        {
            quantity -= points;   
        }
        public void increase(int points)
        {
            quantity += points;
        }
    }
}

/*
 * be able to have a name of item
 * price of item
 * deal with whether this item can be bought
 */