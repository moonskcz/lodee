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
            
            Ship shipA = new Ship("carrierII");
            Ship shipB = new Ship("heavyCruiser");
            Ship shipC = new Ship("hydro");
            Ship shipD = new Ship("katamaran");

            ArrayHandler arrHand = new ArrayHandler();

            List<List<Cell>> Field = arrHand.CreateArray(10);
            /*
            arrHand.KillCell(Field, 5, 4);
            arrHand.KillCell(Field, 8, 4);
            arrHand.KillCell(Field, 7, 2);
            arrHand.KillCell(Field, 1, 4);
            arrHand.KillCell(Field, 3, 4);
            arrHand.KillCell(Field, 5, 2);
            arrHand.KillCell(Field, 5, 5);
            arrHand.KillCell(Field, 5, 4);
            arrHand.KillCell(Field, 2, 7);
            arrHand.KillCell(Field, 3, 0);
            arrHand.KillCell(Field, 1, 8);
            */

            arrHand.RenderArray(Field, shipA);
            arrHand.RenderArray(Field, shipB);
            arrHand.RenderArray(Field, shipC);
            arrHand.RenderArray(Field, shipD);

            arrHand.KillCell(Field, 6, 2);
            arrHand.KillCell(Field, 3, 1);
            arrHand.KillCell(Field, 9, 9);


            arrHand.RenderArray(Field);

        }
    }
}
