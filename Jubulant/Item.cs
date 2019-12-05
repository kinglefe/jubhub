using System;
namespace Jubulant
{
    public class Item
    {
        private string itemName;
        public string ItemName
        {
            get
            {
                return itemName;
            } set
            {
                itemName = value;
            }
        }

        public int price;


        private int healthScore;
        public int HealthScore
        {
            get
            {
                return healthScore;
            } set
            {
                healthScore = value;
            }
        }

        public bool canBuy;

        public double weight;
        public int quantity { get; set; }

        public Item() : this("No Item")
        {
        }
        public Item(string _itemName) : this(_itemName, 0, 10, 1, false, 0)
        {

        }
        public Item(string _itemName, int _price, int _healthPoints, int _quantity, bool _canBuy, double _weight) 
        {
            ItemName = _itemName;
            price = _price;
            HealthScore = _healthPoints;
            quantity = _quantity;
            this.canBuy = _canBuy;
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