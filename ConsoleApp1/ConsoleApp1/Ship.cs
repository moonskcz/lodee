using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Ship
    {
        
        public int ShipLives = 0;

        public string Type = "sub";

        public int X = 0;
        public int Y = 0;

        List<List<int>> Shape;

        public void SetShipShape (List<List<int>> shape)
        {
            this.Shape = shape;
        }

    }
}
