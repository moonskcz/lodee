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

        public enum State {empty, emptyHit, ship, shipHit};

        public Ship Ship;

        public Cell (Ship inpId, int x, int y)
        {
            this.Ship = inpId;
            this.X = x;
            this.Y = y;
        }

    }
}
