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

        public string GetCellState(Cell cell, bool inpBool)
        {

            switch (cell.State)
            {
                case 0:
                    return @" ";
                case 1:
                    return @"X";
                case 2:
                    return @" ";
                case 3:
                    return @"H";
                default:
                    return @" ";
            }
        }

     /*   public void RenderArray(List<List<Cell>> Array)
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
        */
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
                else if (nav.Key == ConsoleKey.R)
                {
                    inpShip.SH.GetRotation(inpShip);
                }
            }
        }

        public void RenderArray(List<List<Cell>> Array, TeamHandler th)
        {

            bool turnBool = true;

            int posX = 0;
            int posY = 0;


            while (turnBool)
            {

                Console.Clear();

                int currX = 0;

                foreach (List<Cell> LCell in Array)
                {
                    int currY = 0;

                    foreach (Cell cell in LCell)
                    {

                        if (GetCellState(cell) == "S")
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        else if (GetCellState(cell) == "H")
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        else if (GetCellState(cell) == " ")
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        else if (GetCellState(cell) == "X")
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }

                        bool cursorHere = false;
                        
                        if ((posX == currX) && (posY == currY)) cursorHere = true;

                        if (cursorHere)
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }

                        Console.Write("|" + GetCellState(cell, true));

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
                    if (posY < Array.Count() - 1) posY++;
                }
                else if (nav.Key == ConsoleKey.DownArrow)
                {
                    Console.WriteLine("down");
                    if (posX < Array.Count() - 1) posX++;
                }
                else if (nav.Key == ConsoleKey.Spacebar)
                {
                    if (!KillCell(Array, posX, posY))
                    {
                        turnBool = false;
                        Console.WriteLine("Miss");
                        Console.WriteLine("Opponents turn");
                        Console.ReadLine();
                    } else
                    {
                        Console.WriteLine("Hit");
                        Console.WriteLine("Shoot again");
                        Console.ReadLine();
                    }
                }
            }
        }

        public bool KillCell (List<List<Cell>> Array, int inpX, int inpY)
        {
            return Array[inpX][inpY].Kill();
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
                            if (inpField[x][y].State == 2)
                            {
                                add = false;
                            }
                            try {
                                if (inpField[x][y - 1].State == 2)
                                {
                                    add = false;
                                }
                            } catch (ArgumentException) { }
                            try {
                                if (inpField[x][y + 1].State == 2)
                                {
                                    add = false;
                                }
                            } catch (ArgumentException) { }
                            try {
                                if (inpField[x - 1][y].State == 2)
                                {
                                    add = false;
                                }
                            } catch (ArgumentException) { }
                            try {
                                if (inpField[x + 1][y].State == 2)
                                {
                                    add = false;
                                }
                            } catch (ArgumentException) { }
                            
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

        public void Turns (List<List<Cell>> Array1, TeamHandler TH1, List<List<Cell>> Array2, TeamHandler TH2, List<List<Cell>> Array3, TeamHandler TH3)
        {
            while (true)
            {

                Console.Clear();
                Console.WriteLine("Choose an enemy to shoot at. Either 2 or 3");

                ConsoleKeyInfo nav = Console.ReadKey();

                if (nav.Key == ConsoleKey.D2)
                {
                    RenderArray(Array2, TH2);
                }
                else if (nav.Key == ConsoleKey.D3)
                {
                    RenderArray(Array3, TH3);
                }
                else
                {
                    RenderArray(Array2, TH2);
                }

                Console.Clear();
                Console.WriteLine("Choose an enemy to shoot at. Either 1 or 3");

                ConsoleKeyInfo nav1 = Console.ReadKey();

                if (nav1.Key == ConsoleKey.D1)
                {
                    RenderArray(Array1, TH1);
                }
                else if (nav1.Key == ConsoleKey.D3)
                {
                    RenderArray(Array3, TH3);
                }
                else
                {
                    RenderArray(Array1, TH1);
                }


                Console.Clear();
                Console.WriteLine("Choose an enemy to shoot at. Either 1 or 2");

                ConsoleKeyInfo nav2 = Console.ReadKey();

                if (nav2.Key == ConsoleKey.D2)
                {
                    RenderArray(Array2, TH2);
                }
                else if (nav2.Key == ConsoleKey.D1)
                {
                    RenderArray(Array1, TH1);
                }
                else
                {
                    RenderArray(Array1, TH1);
                }
                //RenderArray(Array1, TH1);
            }
        }

        public void ShipConfigMenu (TeamHandler TH1, TeamHandler TH2, TeamHandler TH3, List<List<Cell>> Field1, List<List<Cell>> Field2, List<List<Cell>> Field3)
        {
            ShipHandler shHand = new ShipHandler();

            List<string> chosenShips = new List<string>();

            bool turns = true;
            int curr = 0;

            while (turns)
            {

                Console.Clear();

                foreach (string val in shHand.AllShipTypes)
                {

                    if (chosenShips.Contains(val))
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    if (shHand.AllShipTypes.IndexOf(val) == curr)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }

                    Console.WriteLine(val);

                    Console.ResetColor();

                }

                if (curr == shHand.AllShipTypes.Count)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                Console.WriteLine("Continue");

                Console.ResetColor();

                ConsoleKeyInfo nav = Console.ReadKey();

                if (nav.Key == ConsoleKey.DownArrow)
                {
                    Console.WriteLine("up");
                    if (curr < shHand.AllShipTypes.Count)
                    {
                        curr++;
                    } else
                    {
                        curr = 0;
                    }
                } else if (nav.Key == ConsoleKey.UpArrow)
                {
                    Console.WriteLine("down");
                    if (curr > 0)
                    {
                        curr--;
                    }
                    else
                    {
                        curr = shHand.AllShipTypes.Count;
                    }
                } else if (nav.Key == ConsoleKey.Spacebar)
                {
                    if (curr == shHand.AllShipTypes.Count)
                    {
                        turns = false;
                        foreach (string el in chosenShips)
                        {
                            new Ship(el, TH1);
                            new Ship(el, TH2);
                            new Ship(el, TH3);
                        }
                        foreach (Ship ship in TH1.Ships)
                        {
                            RenderArray(Field1, ship);
                        }
                        foreach (Ship ship in TH2.Ships)
                        {
                            RenderArray(Field2, ship);
                        }
                        foreach (Ship ship in TH3.Ships)
                        {
                            RenderArray(Field3, ship);
                        }
                    } else
                    {
                        if (!chosenShips.Contains(shHand.AllShipTypes[curr]))
                        {
                            chosenShips.Add(shHand.AllShipTypes[curr]);
                        } else
                        {
                            chosenShips.Remove(shHand.AllShipTypes[curr]);
                        }
                    }
                }

            }
        }

    }
}
