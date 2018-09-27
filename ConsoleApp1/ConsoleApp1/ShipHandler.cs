using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ShipHandler
    {

        /* sub, destroyer, cruiser, battlehip, carrier, landBase, hydro, cruiserII, heavyCruiser, katamaran, lightBattleship, carrierII */

        public void CreateShipShape (Ship inpShip)
        {

            List<Cell> retShip = new List<Cell>();

            switch (inpShip.Type)
            {
                case "sub":
                    retShip.Add(new Cell(inpShip, 0, 0));
                    inpShip.Height = 1;
                    inpShip.Width = 1;
                    break;
                case "destroyer":
                    retShip.Add(new Cell(inpShip, 0, 0));
                    retShip.Add(new Cell(inpShip, 0, 1));
                    inpShip.Height = 1;
                    inpShip.Width = 2;
                    break;
                case "cruiser":
                    retShip.Add(new Cell(inpShip, 0, 0));
                    retShip.Add(new Cell(inpShip, 0, 1));
                    retShip.Add(new Cell(inpShip, 0, 2));
                    inpShip.Height = 1;
                    inpShip.Width = 3;
                    break;
                case "battlehip":
                    retShip.Add(new Cell(inpShip, 0, 0));
                    retShip.Add(new Cell(inpShip, 0, 1));
                    retShip.Add(new Cell(inpShip, 0, 2));
                    retShip.Add(new Cell(inpShip, 0, 3));
                    inpShip.Height = 1;
                    inpShip.Width = 4;
                    break;
                case "carrier":
                    retShip.Add(new Cell(inpShip, 0, 0));
                    retShip.Add(new Cell(inpShip, 0, 1));
                    retShip.Add(new Cell(inpShip, 0, 2));
                    retShip.Add(new Cell(inpShip, 0, 3));
                    retShip.Add(new Cell(inpShip, 0, 5));
                    inpShip.Height = 1;
                    inpShip.Width = 5;
                    break;
                case "landBase":
                    retShip.Add(new Cell(inpShip, 1, 0));
                    retShip.Add(new Cell(inpShip, 1, 1));
                    retShip.Add(new Cell(inpShip, 1, 2));
                    retShip.Add(new Cell(inpShip, 0, 0));
                    retShip.Add(new Cell(inpShip, 0, 1));
                    retShip.Add(new Cell(inpShip, 0, 2));
                    inpShip.Height = 2;
                    inpShip.Width = 3;
                    break;
                case "hydro":
                    retShip.Add(new Cell(inpShip, 0, 1));
                    retShip.Add(new Cell(inpShip, 1, 0));
                    retShip.Add(new Cell(inpShip, 1, 2));
                    inpShip.Height = 2;
                    inpShip.Width = 3;
                    break;
                case "cruiserII":
                    retShip.Add(new Cell(inpShip, 0, 1));
                    retShip.Add(new Cell(inpShip, 1, 0));
                    retShip.Add(new Cell(inpShip, 1, 2));
                    retShip.Add(new Cell(inpShip, 1, 1));
                    inpShip.Height = 2;
                    inpShip.Width = 3;
                    break;
                case "heavyCruiser":
                    retShip.Add(new Cell(inpShip, 0, 1));
                    retShip.Add(new Cell(inpShip, 1, 0));
                    retShip.Add(new Cell(inpShip, 1, 2));
                    retShip.Add(new Cell(inpShip, 1, 1));
                    retShip.Add(new Cell(inpShip, 2, 1));
                    inpShip.Height = 3;
                    inpShip.Width = 3;
                    break;
                case "katamaran":
                    retShip.Add(new Cell(inpShip, 0, 0));
                    retShip.Add(new Cell(inpShip, 0, 2));
                    retShip.Add(new Cell(inpShip, 1, 0));
                    retShip.Add(new Cell(inpShip, 1, 1));
                    retShip.Add(new Cell(inpShip, 1, 2));
                    retShip.Add(new Cell(inpShip, 2, 0));
                    retShip.Add(new Cell(inpShip, 2, 2));
                    inpShip.Height = 3;
                    inpShip.Width = 3;
                    break;
                case "lightBattleship":
                    retShip.Add(new Cell(inpShip, 0, 0));
                    retShip.Add(new Cell(inpShip, 1, 0));
                    retShip.Add(new Cell(inpShip, 1, 1));
                    inpShip.Height = 2;
                    inpShip.Width = 3;
                    break;
                case "carrierII":
                    retShip.Add(new Cell(inpShip, 0, 3));
                    retShip.Add(new Cell(inpShip, 0, 4));
                    retShip.Add(new Cell(inpShip, 1, 0));
                    retShip.Add(new Cell(inpShip, 1, 1));
                    retShip.Add(new Cell(inpShip, 1, 2));
                    retShip.Add(new Cell(inpShip, 1, 3));
                    retShip.Add(new Cell(inpShip, 1, 4));
                    inpShip.Height = 2;
                    inpShip.Width = 5;
                    break;
                default:
                    break;
            }

            inpShip.ShipLives = retShip.Count;

            inpShip.Shape = retShip;
            
        }

        public void ShipDied ()
        {

        }

        public void ShipRotate(Ship ship)
        {
            //only works with katamaran, cross and sticks
            

            foreach (Cell cell in ship.Shape)
            {
                int wMiddle;
                int hMiddle;

                if (ship.Width % 2 == 1)
                {
                    wMiddle = ship.Width / 2;
                    wMiddle++;
                } else
                {
                    wMiddle = ship.Width / 2;
                }

                if (ship.Height % 2 == 1)
                {
                    hMiddle = ship.Width / 2;
                    hMiddle++;
                } else
                {
                    hMiddle = ship.Width / 2;
                }

                int tmpX = cell.X;
                int tmpY = cell.Y;

                if (tmpY > hMiddle)
                {
                    cell.Y = hMiddle -tmpX;
                } else if (tmpY < hMiddle)
                {
                    cell.Y = tmpX + hMiddle;
                }

                if (tmpX > wMiddle)
                {
                    cell.X = wMiddle -tmpY;
                } else if (tmpX < wMiddle)
                {
                    cell.X = tmpY + wMiddle;
                }
                /*
                int finX = ship.Height -1 -tmpX;
                int finY = ship.Width -1 -tmpY;


                cell.X = finX;
                

                cell.Y = finY;

                
                /*
                cell.X = ship.Height - cell.Y - 1;
                cell.Y = ship.Width - tmpX - 1;
                /*
                if ((ship.Rotation + 1) % 2 == 1)
                {
                    cell.Y = tmpX;
                    cell.X = ship.Height - 1 - tmpY;
                } else
                {
                    cell.X = tmpY;
                    cell.Y = ship.Width - 1 - tmpX;
                }
                /*
                float newX = cell.X / ship.Height;

                if (newX > 0.5)
                {

                }*/

            }

            int tmpp = ship.Width;
            ship.Width = ship.Height;
            ship.Height = tmpp;

            ship.Rotation++;

            if (ship.Rotation == 3)
            {
                ship.Rotation = 0;
            }

        }

    }
}
