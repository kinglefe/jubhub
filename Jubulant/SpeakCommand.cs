using System;
namespace Jubulant
{
    public class SpeakCommand : Command
    {
        public SpeakCommand() : base()
        {
            this.name = "speak";
        }

        override
        public bool execute(Player player)
        {
            if (this.hasSecondWord())
            {
                player.speak(this.secondWord);
            }
            else
            {
                player.outputMessage("\nSpeak What?");
            }
            return false;
        }
    }
}
