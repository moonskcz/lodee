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

                for (int y = 0; y < ArrSize; y++) {
                    field[x].Add(new Cell(null, x, y));
                }

            }

            return field;

        }

        public string GetCellState (Cell cell)
        {

            switch (cell.State)
            {
                case 0:
                    return @" ";
                case 1:
                    return @"X";
                case 2:
                    return @"S";
                case 3:
                    return @"H";
                default:
                    return @" ";
            }
        }

        public string RenderArray(List<List<Cell>> Array)
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
                    ret += "|" + GetCellState(cell);
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

        public string RenderArray(List<List<Cell>> Array, Ship inpShip)
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
                    ret += "|" + GetCellState(cell);
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

        public void KillCell (List<List<Cell>> Array, int inpX, int inpY)
        {

            Array[inpX][inpY].Kill();

        }

    }
}
