using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TeamHandler
    {

        public int Team = 0;

        public List<Ship> Ships = new List<Ship>();

        public TeamHandler (int team)
        {
            Team = team;
        }

        public void AddShip (Ship ship)
        {
            Ships.Add(ship);
        }

        public void ShipDied (Ship ship)
        {
            Ships.Remove(ship);

            if (Ships.Count <= 0)
            {

                Console.WriteLine($"Team {Team.ToString()} won!");

                Environment.Exit(0);

            }
        }

    }
}
