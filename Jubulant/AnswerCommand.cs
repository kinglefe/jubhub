using System;
namespace Jubulant
{
    public class AnswerCommand : Command
    {
        public AnswerCommand()
        {
            this.name = "answer";
        }

        public override bool execute(Player player)
        {
            if (this.hasSecondWord())
            {
                player.answer(Convert.ToInt32(secondWord));
            } else
            {
                player.outputMessage("Pick a valid choice.");
            }
            return false;
        }
    }
}
