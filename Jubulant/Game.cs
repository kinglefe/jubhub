using System;
namespace Jubulant
{
    public class Game
    {
        Player player;
        Parser parser;
        bool playing;

        public Game()
        {
            //GameWorld gameWorld = new GameWorld();
            this.playing = false;
            parser = new Parser(new CommandWords());
            player = new Player(GameWorld.Instance.Entrance);
        }


        /**
     *  Main play routine.  Loops until end of play.
     */
        public void play()
        {

            // Enter the main command loop.  Here we repeatedly read commands and
            // execute them until the game is over.

            bool finished = false;
            while (!finished)
            {
                Console.Write("\n>");
                Command command = parser.parseCommand(Console.ReadLine());
                if (command == null)
                {
                    Console.WriteLine("I don't understand...");
                }
                else
                {
                    finished = command.execute(player);
                }
            }
        }


        public void start()
        {
            playing = true;
            player.outputMessage(welcome());
        }

        public void end()
        {
            playing = false;
            player.outputMessage(goodbye());
        }

        public string welcome()
        {
            return "Welcome to the World of Jubulant!\n\n The World of Jubulant is a new, incredibly \"boring\" adventure game.\n\nType 'help' if you need help." + player.currentRoom.description();
        }

        public string goodbye()
        {
            return "\nThank you for playing, Goodbye. \n";
        }

    }
}
