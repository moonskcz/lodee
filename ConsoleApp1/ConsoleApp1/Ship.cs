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

        public int Width = 1;
        public int Height = 1;

        public List<Cell> Shape = new List<Cell>();

        ShipHandler SH = new ShipHandler();

        public Ship (string inpType)
        {
            Type = inpType;
            SH.CreateShipShape(this);
        }

    }
}
