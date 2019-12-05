using System;
namespace Jubulant
{
    public class BackCommand : Command
    {
        public BackCommand()
        {
            this.name = "back";
        }

        public override bool execute(Player player)
        {
            if (this.name == "back")
            {
                player.back();
            } else
            {
                player.outputMessage("Back? Where?");
            }
            return false;
        }
    }
}
