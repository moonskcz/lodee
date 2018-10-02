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
            TeamHandler TH3 = new TeamHandler(3);

            List<List<Cell>> Field1 = arrHand.CreateArray(10);
            List<List<Cell>> Field2 = arrHand.CreateArray(10);
            List<List<Cell>> Field3 = arrHand.CreateArray(10);

            arrHand.ShipConfigMenu(TH1, TH2, TH3, Field1, Field2, Field3);
            arrHand.Turns(Field1, TH1, Field2, TH2, Field3, TH3);

        }
    }
}
