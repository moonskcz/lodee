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

        public void RenderArray(List<List<Cell>> Array, Ship inpShip)
        {

            bool placeBool = true;
            string ret = "";

            int posX = 0;
            int posY = 0;


            while (placeBool)
            {

                ret = "";

                
                ConsoleKeyInfo nav = Console.ReadKey();

                Console.Clear();

                if (nav.Key == ConsoleKey.UpArrow)
                {
                    Console.WriteLine("up");
                    if (posX > 0) posX--;
                } else if (nav.Key == ConsoleKey.LeftArrow)
                {
                    Console.WriteLine("left");
                    if (posY > 0) posY--;
                } else if (nav.Key == ConsoleKey.RightArrow)
                {
                    Console.WriteLine("right");
                    if (posY < Array.Count() - 1) posY++;
                } else if (nav.Key == ConsoleKey.DownArrow)
                {
                    Console.WriteLine("down");
                    if (posX < Array.Count() - 1) posX++;
                }

                Console.WriteLine($"{posX.ToString()}{posY.ToString()}");

                int currX = 0;

                foreach (List<Cell> LCell in Array)
                {
                    int currY = 0;

                    foreach (Cell cell in LCell)
                    {
                        bool shipHere = false;

                        foreach (Cell smallCell in inpShip.Shape)
                        {

                        }

                        if ((posX == currX && posY == currY) || (shipHere))
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                        }

                        Console.Write("|" + GetCellState(cell));

                        Console.ResetColor();

                        currY++;
                    }
                    Console.WriteLine();

                    currX++;

                }

                Console.WriteLine(ret);

            }

        }

        public void KillCell (List<List<Cell>> Array, int inpX, int inpY)
        {

            Array[inpX][inpY].Kill();

        }

        /*public List<List<Cell>> AddShip ()
        {
            return;
        }*/

    }
}
