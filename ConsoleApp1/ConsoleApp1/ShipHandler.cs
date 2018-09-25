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
                    retShip.Add(new Cell(inpShip, 0, 4));
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


    }
}
