using System;
namespace Jubulant
{
    public class QuitCommand : Command
    {

        public QuitCommand() : base()
        {
            this.name = "quit";
        }

        override
        public bool execute(Player player)
        {
            bool answer = true;
            if (this.hasSecondWord())
            {
                player.outputMessage("\nI cannot quit " + this.secondWord);
                answer = false;
            }
            return answer;
        }
    }
}
