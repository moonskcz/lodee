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
            
            Ship shipA = new Ship();

            ArrayHandler arrHand = new ArrayHandler();

            List<List<Cell>> Field = arrHand.CreateArray(15);

            Console.WriteLine(arrHand.RenderArray(Field));

        }
    }
}
