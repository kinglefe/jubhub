using System;
namespace Jubulant
{
    public abstract class Command
    {
        private string _name;
        public string name { get { return _name; } set { _name = value; } }
        private string _secondWord;
        public string secondWord { get { return _secondWord; } set { _secondWord = value; } }
        private string _thirdWord;
        public string thirdWord { get { return _thirdWord; } set { _thirdWord = value; } }

        public Command()
        {
            this.name = "";
            this.secondWord = null;
            this.thirdWord = null;
        }

        public bool hasSecondWord()
        {
            return this.secondWord != null;
        }

        public bool hasThirdWord()
        {
            return this.thirdWord != null;
        }

        public abstract bool execute(Player player);
    }
}
