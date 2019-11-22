using System;
namespace Jubulant
{
    public class BuyCommand : Command
    {
        public BuyCommand()
        {
            this.name = "buy";
        }

        override
        public bool execute(Player player)
        {
            if (this.hasSecondWord())
            {
                player.outputMessage(this.secondWord);
            }
            else
            {
                player.outputMessage("\nBuy What?");
            }
            return false;
        }
    }
}
