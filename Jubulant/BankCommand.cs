using System;
namespace Jubulant
{
    public class BankCommand : Command
    {
        public BankCommand()
        {
            this.name = "bank";
        }

        override
        public bool execute(Player player)
        {
            if (this.hasSecondWord() && this.secondWord == "balance")
            {
                player.outputMessage("" + player.getBalance());
            }
            else
            {
                player.outputMessage("\nYou are poor. You are alone. You wander around the world on crack. Get some money fool.");
            }
            return false;
        }
    }
}
