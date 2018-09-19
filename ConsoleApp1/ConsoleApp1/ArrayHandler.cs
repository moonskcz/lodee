using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ArrayHandler
    {

        public List<List<Cell>> CreateArray (int ArrSize)
        {

            List<List<Cell>> field = new List<List<Cell>>();

            for (int x = 0; x < ArrSize; x++)
            {

                field.Add(new List<Cell>());

                for (int y = 0; y < ArrSize; y++)
                {

                    field[x].Add(new Cell(null, x, y));

                }


            }

            return field;

        }

        public string GetCellState (Cell cell)
        {

            return "";

        }

        public string RenderArray (List<List<Cell>> Array)
        {

            string ret = "";

            for (int x = 0; x < Array.Count; x++)
            {
                ret += "--";
            }

            ret += @"-
";

            foreach (List<Cell> LCell in Array)
            {

                foreach (Cell cell in LCell)
                {
                     ret += "| ";
                }

                ret += @"|
";

                for (int x = 0; x < Array.Count; x++)
                {
                    ret += "--";
                }

                ret += @"-
";

            }

            return ret;

        }

    }
}
