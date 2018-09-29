using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayHandler arrHand = new ArrayHandler();

            TeamHandler TH1 = new TeamHandler(1);
            TeamHandler TH2 = new TeamHandler(2);
            /*
            Ship shipAA = new Ship("carrierII", TH1);

            Ship shipBA = new Ship("sub", TH2);
            */
            List<List<Cell>> Field1 = arrHand.CreateArray(10);
            List<List<Cell>> Field2 = arrHand.CreateArray(10);

            arrHand.ShipConfigMenu(TH1, TH2, Field1, Field2);
            /*
            arrHand.RenderArray(Field1, shipAA);

            arrHand.RenderArray(Field2, shipBA);
            */
            arrHand.Turns(Field1, TH1, Field2, TH2);

        }
    }
}
