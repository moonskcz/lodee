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

        public List<Cell> CreateShipShape (Ship inpShip)
        {

            List<Cell> retShip = new List<Cell>();

            switch (inpShip.Type)
            {
                case "sub":
                    retShip.Add(new Cell(inpShip, 0, 0));
                    break;
                case "destroyer":
                    retShip.Add(new Cell(inpShip, 0, 0));
                    retShip.Add(new Cell(inpShip, 1, 0));
                    break;
                case "cruiser":
                    retShip.Add(new Cell(inpShip, 0, 0));
                    retShip.Add(new Cell(inpShip, 1, 0));
                    retShip.Add(new Cell(inpShip, 2, 0));
                    break;
                case "battlehip":
                    retShip.Add(new Cell(inpShip, 0, 0));
                    retShip.Add(new Cell(inpShip, 1, 0));
                    retShip.Add(new Cell(inpShip, 2, 0));
                    retShip.Add(new Cell(inpShip, 3, 0));
                    break;
                case "carrier":

                case "landBase":

                case "hydro":

                case "cruiserII":

                case "heavyCruiser":

                case "katamaran":

                case "lightBattleship":

                case "carrierII":
                    
                default:
                    break;
            }

            return retShip;
            
        }

        


    }
}
