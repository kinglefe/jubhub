using System;
namespace Jubulant
{
    public class EatCommand : Command
    {

        public EatCommand()
        {
            this.name = "eat";
        }

        public override bool execute(Player player)
        {
            if (this.hasSecondWord())
            {
                player.eat(this.secondWord);
            } else
            {
                player.outputMessage("\nEat What?");
            }
            return false;
        }
    }
}
