using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;
using System.ComponentModel;
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

        public void RenderArray(List<List<Cell>> Array)
        {

            Console.Clear();
            
            foreach (List<Cell> LCell in Array)
            {

                foreach (Cell cell in LCell)
                {
                    if (GetCellState(cell) == "S")
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Gray;
                    } else if (GetCellState(cell) == "H")
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Red;
                    } else if (GetCellState(cell) == " ")
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Blue;
                    } else if (GetCellState(cell) == "X")
                    {
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }
                    Console.Write ("|" + GetCellState(cell));

                    Console.ResetColor();
                }

                Console.WriteLine("");

            }

        }

        public void RenderArray(List<List<Cell>> Array, Ship inpShip)
        {

            bool placeBool = true;

            int posX = 0;
            int posY = 0;


            while (placeBool)
            {

                Console.Clear();

                

                int currX = 0;

                foreach (List<Cell> LCell in Array)
                {
                    int currY = 0;

                    foreach (Cell cell in LCell)
                    {
                        bool shipHere = false;

                        foreach (Cell smallCell in inpShip.Shape)
                        {
                            if ((posX + smallCell.X == currX) && (posY + smallCell.Y == currY)) shipHere = true;
                        }

                        if (shipHere)
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }

                        Console.Write("|" + GetCellState(cell));

                        Console.ResetColor();

                        currY++;
                    }
                    Console.WriteLine();

                    currX++;

                }

                Console.WriteLine($"{posX.ToString()}{posY.ToString()}");

                ConsoleKeyInfo nav = Console.ReadKey();

                if (nav.Key == ConsoleKey.UpArrow)
                {
                    Console.WriteLine("up");
                    if (posX > 0) posX--;
                }
                else if (nav.Key == ConsoleKey.LeftArrow)
                {
                    Console.WriteLine("left");
                    if (posY > 0) posY--;
                }
                else if (nav.Key == ConsoleKey.RightArrow)
                {
                    Console.WriteLine("right");
                    if (posY < Array.Count() - inpShip.Width) posY++;
                }
                else if (nav.Key == ConsoleKey.DownArrow)
                {
                    Console.WriteLine("down");
                    if (posX < Array.Count() - inpShip.Height) posX++;
                }
                else if (nav.Key == ConsoleKey.Spacebar)
                {
                    if (AddShip(inpShip, Array, posX, posY)) placeBool = false;
                }
            }
        }

        public void KillCell (List<List<Cell>> Array, int inpX, int inpY)
        {
            Array[inpX][inpY].Kill();
        }

        public bool AddShip (Ship inpShip, List<List<Cell>> inpField, int inpX, int inpY)
        {
            bool add = true;
            for (int x = inpX; x <= inpShip.Height + inpX; x++)
            {
                for (int y = inpY; y <= inpShip.Width + inpY; y++)
                {
                    foreach (Cell smallCell in inpShip.Shape)
                    {
                        if (smallCell.X + inpX == x && smallCell.Y + inpY == y)
                        {
                            if (inpField[x][y].State == 2 || inpField[x][y].State == 3)
                            {
                                add = false;
                            }
                        }
                    }
                }
            }

            if (add)
            {
                for (int x = inpX; x <= inpShip.Height + inpX; x++)
                {
                    for (int y = inpY; y <= inpShip.Width + inpY; y++)
                    {
                        foreach (Cell smallCell in inpShip.Shape)
                        {
                            if (smallCell.X + inpX == x && smallCell.Y + inpY == y)
                            {
                                inpField[x][y] = smallCell;
                            }
                        }
                    }
                }

                return true;

            } else return false;
        }

    }
}
