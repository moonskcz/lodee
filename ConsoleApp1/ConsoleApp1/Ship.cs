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

        public int Rotation = 0;

        public List<Cell> Shape = new List<Cell>();

        public ShipHandler SH = new ShipHandler();

        public TeamHandler TH = null;

        public Ship (string inpType, TeamHandler th)
        {
            Type = inpType;

            TH = th;

            TH.AddShip(this);

            SH.CreateShipShape(this);

            foreach (Cell el in Shape)
            {
                ShipLives++;
            }

            ShipLives = ShipLives / 2;

        }

        public bool Hit ()
        {
            ShipLives--;

            if (ShipLives <= 0)
            {
                TH.ShipDied(this);
                Console.WriteLine($"Ship {Type} has been sunk.");
                Console.ReadKey();
            }

            return true;
        }
    }
}
