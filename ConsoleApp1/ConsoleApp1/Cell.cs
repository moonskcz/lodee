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

        public Cell (Ship inpId, int x, int y)
        {
            this.ship = inpId;
            this.X = x;
            this.Y = y;
        }
        
        public void Kill ()
        {

            if (ship == null && State == 0)
            {
                State = 1;
            } else if (ship != null && State == 2)
            {
                State = 3;
            }

        }

    }
}
