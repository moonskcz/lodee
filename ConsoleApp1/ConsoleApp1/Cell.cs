using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cell
    {

        public int X;
        public int Y;

        public enum States {empty, emptyHit, ship, shipHit};

        public int State = 0;

        private Ship ship;

        public Cell (Ship inpShip, int x, int y)
        {
            ship = inpShip;
            X = x;
            Y = y;

            if (inpShip != null) State = 2;
        }
        
        public bool Kill ()
        {

            if (ship == null && State == 0)
            {
                State = 1;
                return false;
            } else if (ship != null && State == 2)
            {
                State = 3;
                ship.Hit();
                return true;
            }

            return false;

        }

    }
}
