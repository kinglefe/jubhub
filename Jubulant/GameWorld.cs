using System;
using System.Collections.Generic;
namespace Jubulant
{
    public class GameWorld
    {
        static private GameWorld _instance;
        static public GameWorld Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GameWorld();
                return _instance;
            }
        }
        private Room _entrance;
        public Room Entrance { get { return _entrance; } }
        private Room trigger;
        private GameWorld()
        {
            _entrance = createWorld();
            // GameWorld subscribes to the notification PlayerEnteredRoom
            NotificationCenter.Instance.addObserver("PlayerEnteredRoom", playerEnteredRoom);
        }

        private Room createWorld()
        {
            // setting up the rooms 
            Room home = new Room("at home", "home");
            Room school = new Room("getting some good ole education at school.", "school");
            Market market = new Market("shopping in the market.", "market");
            Room bank = new Room("at the bank.", "bank");
            Room blackMarket = new Room("at the Black Market", "blackMarket");
            Room work = new Room("at work running up a check.", "work");
            Room mall = new Room("at the local Mall", "mall");
            Room hospital = new Room("at the hospital", "hospital");


            // setting up the exits
            /// home and to market(west)
            home.setExit(market.shortName, market);
            market.setExit(home.shortName, home);

            /// home and to mall(north)
            home.setExit(mall.shortName, mall);
            mall.setExit(home.shortName, home);

            /// home and bank(south)
            home.setExit(bank.shortName, bank);
            bank.setExit(home.shortName, home);



            /// market and hospital(north)
            market.setExit(hospital.shortName, hospital);
            hospital.setExit(market.shortName, market);

            /// market and work(south)
            market.setExit(work.shortName, work);
            work.setExit(market.shortName, market);

            /// market and school(east)
            market.setExit(school.shortName, school);
            school.setExit(market.shortName, market);


            /// work and the black market (south of work)
            work.setExit(blackMarket.shortName, blackMarket);
            blackMarket.setExit(work.shortName, work);

            /*Room outside = new Room("outside the main entrance of the university");
            Room cctparking = new Room("in the parking lot at CCT");
            Room boulevard = new Room("on the boulevard");
            Room universityParking = new Room("in the parking lot at University Hall");
            Room parkingDeck = new Room("in the parking deck");
            Room cct = new Room("in the CCT building");
            Room theGreen = new Room("in the green in from of Schuster Center");
            Room universityHall = new Room("in University Hall");
            Room schuster = new Room("in the Schuster Center");

            outside.setExit("west", boulevard);

            boulevard.setExit("east", outside);
            boulevard.setExit("south", cctparking);
            boulevard.setExit("west", theGreen);
            boulevard.setExit("north", universityParking);

            cctparking.setExit("west", cct);
            cctparking.setExit("north", boulevard);

            cct.setExit("east", cctparking);
            cct.setExit("north", schuster);

            schuster.setExit("south", cct);
            schuster.setExit("north", universityHall);
            schuster.setExit("east", theGreen);

            theGreen.setExit("west", schuster);
            theGreen.setExit("east", boulevard);

            universityHall.setExit("south", schuster);
            universityHall.setExit("east", universityParking);

            universityParking.setExit("south", boulevard);
            universityParking.setExit("west", universityHall);
            universityParking.setExit("north", parkingDeck);

            parkingDeck.setExit("south", universityParking);

            trigger = parkingDeck;

            return outside; */
            return home;
        }

        // callback method for PlayerEnteredRoom
        public void playerEnteredRoom(Notification notification)
        {
            Player player = (Player)notification.Object;
            if (player.currentRoom == trigger)
            {
                Console.WriteLine("Player entered the trigger room");
            }
        }
    }
}
