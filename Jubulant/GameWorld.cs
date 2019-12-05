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
        
        private GameWorld()
        {
            _entrance = createWorld();
            // GameWorld subscribes to the notification PlayerEnteredRoom
            //NotificationCenter.Instance.addObserver("PlayerEnteredRoom", playerEnteredRoom);
        }

        private Room createWorld()
        {
            // setting up the rooms 
            Home home = new Home("at home", "home");
            School school = new School("getting some good ole education at school.", "school");
            Market market = new Market("shopping in the market.", "market");
            BankRoom bank = new BankRoom("at the bank.", "bank");
            blackMarketVendor blackMarket = new blackMarketVendor("at the Black Market", "blackMarket");
            WorkPlace work = new WorkPlace("at work running up a check.", "work");
            Mall mall = new Mall("at the local Mall", "mall");
            Hospital hospital = new Hospital("at the hospital", "hospital");


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

            return home;
        }

        // callback method for PlayerEnteredRoom
        //d 
    }
}
