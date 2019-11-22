using System;
namespace Jubulant
{
    public class Bank
    {
        private double _balance;
        public double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }
        public Bank()
        {
            Balance = 100.0;
        }

        void addPoints(double points)
        {
            Balance += points;
        }
        void addPoints(int points)
        {
            Balance += points;
        }

        void withdrawPoints(double points)
        {
            Balance -= points;
        }
        void withdrawPoints(int points)
        {
            Balance -= points;
        }

        double getBalance()
        {
            return Balance;
        }
    }
}

/* the purpose of this class is to handle points balance x
 * be able to return balance x
 * be able to add points to the player balance x
 * be able to subtract points from the balance x
 * each player starts at 100 points x
 */