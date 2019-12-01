using System;
namespace Jubulant
{
    public class Health
    {
        private int _health;
        public int HealthPoints { get { return _health; } set { _health = value; } }

        public Health()
        {
            this._health = 100;
        }

        public void healthFall(int points)
        {
            HealthPoints -= points;
        }

        public void healthIncrease(int points)
        {
            HealthPoints += points;
        }

        public void defaultFall()
        {
            healthFall(15);
        }
    }
}
