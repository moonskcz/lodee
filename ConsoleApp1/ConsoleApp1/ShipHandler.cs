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

        public void CreateShipShape (Ship inpShip)
        {

            List<Cell> retShip = new List<Cell>();

            switch (inpShip.Type)
            {
                case "sub":
                    retShip.Add(new Cell(inpShip, 0, 0));
                    inpShip.Height = 1;
                    inpShip.Width = 1;
                    break;
                case "destroyer":
                    retShip.Add(new Cell(inpShip, 0, 0));
                    retShip.Add(new Cell(inpShip, 0, 1));
                    inpShip.Height = 1;
                    inpShip.Width = 2;
                    break;
                case "cruiser":
                    retShip.Add(new Cell(inpShip, 0, 0));
                    retShip.Add(new Cell(inpShip, 0, 1));
                    retShip.Add(new Cell(inpShip, 0, 2));
                    inpShip.Height = 1;
                    inpShip.Width = 3;
                    break;
                case "battlehip":
                    retShip.Add(new Cell(inpShip, 0, 0));
                    retShip.Add(new Cell(inpShip, 0, 1));
                    retShip.Add(new Cell(inpShip, 0, 2));
                    retShip.Add(new Cell(inpShip, 0, 3));
                    inpShip.Height = 1;
                    inpShip.Width = 4;
                    break;
                case "carrier":
                    retShip.Add(new Cell(inpShip, 0, 0));
                    retShip.Add(new Cell(inpShip, 0, 1));
                    retShip.Add(new Cell(inpShip, 0, 2));
                    retShip.Add(new Cell(inpShip, 0, 3));
                    retShip.Add(new Cell(inpShip, 0, 5));
                    inpShip.Height = 1;
                    inpShip.Width = 5;
                    break;
                case "landBase":
                    retShip.Add(new Cell(inpShip, 1, 0));
                    retShip.Add(new Cell(inpShip, 1, 1));
                    retShip.Add(new Cell(inpShip, 1, 2));
                    retShip.Add(new Cell(inpShip, 0, 0));
                    retShip.Add(new Cell(inpShip, 0, 1));
                    retShip.Add(new Cell(inpShip, 0, 2));
                    inpShip.Height = 2;
                    inpShip.Width = 3;
                    break;
                case "hydro":
                    retShip.Add(new Cell(inpShip, 0, 1));
                    retShip.Add(new Cell(inpShip, 1, 0));
                    retShip.Add(new Cell(inpShip, 1, 2));
                    inpShip.Height = 2;
                    inpShip.Width = 3;
                    break;
                case "cruiserII":
                    retShip.Add(new Cell(inpShip, 0, 1));
                    retShip.Add(new Cell(inpShip, 1, 0));
                    retShip.Add(new Cell(inpShip, 1, 2));
                    retShip.Add(new Cell(inpShip, 1, 1));
                    inpShip.Height = 2;
                    inpShip.Width = 3;
                    break;
                case "heavyCruiser":
                    retShip.Add(new Cell(inpShip, 0, 1));
                    retShip.Add(new Cell(inpShip, 1, 0));
                    retShip.Add(new Cell(inpShip, 1, 2));
                    retShip.Add(new Cell(inpShip, 1, 1));
                    retShip.Add(new Cell(inpShip, 2, 1));
                    inpShip.Height = 3;
                    inpShip.Width = 3;
                    break;
                case "katamaran":
                    retShip.Add(new Cell(inpShip, 0, 0));
                    retShip.Add(new Cell(inpShip, 0, 2));
                    retShip.Add(new Cell(inpShip, 1, 0));
                    retShip.Add(new Cell(inpShip, 1, 1));
                    retShip.Add(new Cell(inpShip, 1, 2));
                    retShip.Add(new Cell(inpShip, 2, 0));
                    retShip.Add(new Cell(inpShip, 2, 2));
                    inpShip.Height = 3;
                    inpShip.Width = 3;
                    break;
                case "lightBattleship":
                    retShip.Add(new Cell(inpShip, 0, 0));
                    retShip.Add(new Cell(inpShip, 1, 0));
                    retShip.Add(new Cell(inpShip, 1, 1));
                    inpShip.Height = 2;
                    inpShip.Width = 3;
                    break;
                case "carrierII":
                    retShip.Add(new Cell(inpShip, 0, 3));
                    retShip.Add(new Cell(inpShip, 0, 4));
                    retShip.Add(new Cell(inpShip, 1, 0));
                    retShip.Add(new Cell(inpShip, 1, 1));
                    retShip.Add(new Cell(inpShip, 1, 2));
                    retShip.Add(new Cell(inpShip, 1, 3));
                    retShip.Add(new Cell(inpShip, 1, 4));
                    inpShip.Height = 2;
                    inpShip.Width = 5;
                    break;
                default:
                    break;
            }

            inpShip.ShipLives = retShip.Count;

            inpShip.Shape = retShip;
            
        }

        public void GetRotation (Ship ship)
        {

            List<Cell> retShip = new List<Cell>();

            ship.Rotation++;
            if (ship.Rotation == 4)
            {
                ship.Rotation = 0;
            }

            switch (ship.Type)
            {
                case "sub":
                    retShip.Add(new Cell(ship, 0, 0));
                    ship.Height = 1;
                    ship.Width = 1;
                    break;
                case "destroyer":
                    switch (ship.Rotation)
                    {
                        case 0:
                            retShip.Add(new Cell(ship, 0, 0));
                            retShip.Add(new Cell(ship, 0, 1));
                            ship.Height = 1;
                            ship.Width = 2;
                            break;
                        case 1:
                            retShip.Add(new Cell(ship, 0, 0));
                            retShip.Add(new Cell(ship, 1, 0));
                            ship.Height = 2;
                            ship.Width = 1;
                            break;
                        case 2:
                            retShip.Add(new Cell(ship, 0, 0));
                            retShip.Add(new Cell(ship, 0, 1));
                            ship.Height = 1;
                            ship.Width = 2;
                            break;
                        case 3:
                            retShip.Add(new Cell(ship, 0, 0));
                            retShip.Add(new Cell(ship, 1, 0));
                            ship.Height = 2;
                            ship.Width = 1;
                            break;
                    }
                    break;
                case "cruiser":
                    switch (ship.Rotation)
                    {
                        case 0:
                            retShip.Add(new Cell(ship, 0, 0));
                            retShip.Add(new Cell(ship, 0, 1));
                            retShip.Add(new Cell(ship, 0, 2));
                            ship.Height = 1;
                            ship.Width = 3;
                            break;
                        case 1:
                            retShip.Add(new Cell(ship, 0, 0));
                            retShip.Add(new Cell(ship, 1, 0));
                            retShip.Add(new Cell(ship, 2, 0));
                            ship.Height = 3;
                            ship.Width = 1;
                            break;
                        case 2:
                            retShip.Add(new Cell(ship, 0, 0));
                            retShip.Add(new Cell(ship, 0, 1));
                            retShip.Add(new Cell(ship, 0, 2));
                            ship.Height = 1;
                            ship.Width = 3;
                            break;
                        case 3:
                            retShip.Add(new Cell(ship, 0, 0));
                            retShip.Add(new Cell(ship, 1, 0));
                            retShip.Add(new Cell(ship, 2, 0));
                            ship.Height = 3;
                            ship.Width = 1;
                            break;
                    }
                    break;
                case "battlehip":
                    switch (ship.Rotation)
                    {
                        case 0:
                            retShip.Add(new Cell(ship, 0, 0));
                            retShip.Add(new Cell(ship, 0, 1));
                            retShip.Add(new Cell(ship, 0, 2));
                            retShip.Add(new Cell(ship, 0, 3));
                            ship.Height = 1;
                            ship.Width = 4;
                            break;
                        case 1:
                            retShip.Add(new Cell(ship, 0, 0));
                            retShip.Add(new Cell(ship, 1, 0));
                            retShip.Add(new Cell(ship, 2, 0));
                            retShip.Add(new Cell(ship, 3, 0));
                            ship.Height = 4;
                            ship.Width = 1;
                            break;
                        case 2:
                            retShip.Add(new Cell(ship, 0, 0));
                            retShip.Add(new Cell(ship, 0, 1));
                            retShip.Add(new Cell(ship, 0, 2));
                            retShip.Add(new Cell(ship, 0, 3));
                            ship.Height = 1;
                            ship.Width = 4;
                            break;
                        case 3:
                            retShip.Add(new Cell(ship, 0, 0));
                            retShip.Add(new Cell(ship, 1, 0));
                            retShip.Add(new Cell(ship, 2, 0));
                            retShip.Add(new Cell(ship, 3, 0));
                            ship.Height = 4;
                            ship.Width = 1;
                            break;
                    }
                    break;
                case "carrier":
                    switch (ship.Rotation)
                    {
                        case 0:
                            retShip.Add(new Cell(ship, 0, 0));
                            retShip.Add(new Cell(ship, 0, 1));
                            retShip.Add(new Cell(ship, 0, 2));
                            retShip.Add(new Cell(ship, 0, 3));
                            retShip.Add(new Cell(ship, 0, 4));
                            ship.Height = 1;
                            ship.Width = 5;
                            break;
                        case 1:
                            retShip.Add(new Cell(ship, 0, 0));
                            retShip.Add(new Cell(ship, 1, 0));
                            retShip.Add(new Cell(ship, 2, 0));
                            retShip.Add(new Cell(ship, 3, 0));
                            retShip.Add(new Cell(ship, 4, 0));
                            ship.Height = 5;
                            ship.Width = 1;
                            break;
                        case 2:
                            retShip.Add(new Cell(ship, 0, 0));
                            retShip.Add(new Cell(ship, 0, 1));
                            retShip.Add(new Cell(ship, 0, 2));
                            retShip.Add(new Cell(ship, 0, 3));
                            retShip.Add(new Cell(ship, 0, 4));
                            ship.Height = 1;
                            ship.Width = 5;
                            break;
                        case 3:
                            retShip.Add(new Cell(ship, 0, 0));
                            retShip.Add(new Cell(ship, 1, 0));
                            retShip.Add(new Cell(ship, 2, 0));
                            retShip.Add(new Cell(ship, 3, 0));
                            retShip.Add(new Cell(ship, 4, 0));
                            ship.Height = 5;
                            ship.Width = 1;
                            break;
                    }
                    break;
                case "landBase":
                    switch (ship.Rotation)
                    {
                        case 0:
                            retShip.Add(new Cell(ship, 0, 0));
                            retShip.Add(new Cell(ship, 0, 1));
                            retShip.Add(new Cell(ship, 0, 2));
                            retShip.Add(new Cell(ship, 1, 0));
                            retShip.Add(new Cell(ship, 1, 1));
                            retShip.Add(new Cell(ship, 1, 2));
                            ship.Height = 2;
                            ship.Width = 3;
                            break;
                        case 1:
                            retShip.Add(new Cell(ship, 0, 0));
                            retShip.Add(new Cell(ship, 1, 0));
                            retShip.Add(new Cell(ship, 2, 0));
                            retShip.Add(new Cell(ship, 0, 1));
                            retShip.Add(new Cell(ship, 1, 1));
                            retShip.Add(new Cell(ship, 2, 1));
                            ship.Height = 3;
                            ship.Width = 2;
                            break;
                        case 2:
                            retShip.Add(new Cell(ship, 0, 0));
                            retShip.Add(new Cell(ship, 0, 1));
                            retShip.Add(new Cell(ship, 0, 2));
                            retShip.Add(new Cell(ship, 1, 0));
                            retShip.Add(new Cell(ship, 1, 1));
                            retShip.Add(new Cell(ship, 1, 2));
                            ship.Height = 2;
                            ship.Width = 3;
                            break;
                        case 3:
                            retShip.Add(new Cell(ship, 0, 0));
                            retShip.Add(new Cell(ship, 1, 0));
                            retShip.Add(new Cell(ship, 2, 0));
                            retShip.Add(new Cell(ship, 0, 1));
                            retShip.Add(new Cell(ship, 1, 1));
                            retShip.Add(new Cell(ship, 2, 1));
                            ship.Height = 3;
                            ship.Width = 2;
                            break;
                    }
                    break;
                case "hydro":
                    switch (ship.Rotation)
                    {
                        case 0:
                            retShip.Add(new Cell(ship, 0, 1));
                            retShip.Add(new Cell(ship, 1, 0));
                            retShip.Add(new Cell(ship, 1, 2));
                            ship.Height = 2;
                            ship.Width = 3;
                            break;
                        case 1:
                            retShip.Add(new Cell(ship, 0, 0));
                            retShip.Add(new Cell(ship, 1, 1));
                            retShip.Add(new Cell(ship, 2, 0));
                            ship.Height = 3;
                            ship.Width = 2;
                            break;
                        case 2:
                            retShip.Add(new Cell(ship, 0, 0));
                            retShip.Add(new Cell(ship, 0, 2));
                            retShip.Add(new Cell(ship, 1, 1));
                            ship.Height = 2;
                            ship.Width = 3;
                            break;
                        case 3:
                            retShip.Add(new Cell(ship, 0, 1));
                            retShip.Add(new Cell(ship, 1, 0));
                            retShip.Add(new Cell(ship, 2, 1));
                            ship.Height = 3;
                            ship.Width = 2;
                            break;
                    }
                    break;
                case "cruiserII":
                    switch (ship.Rotation)
                    {
                        case 0:
                            retShip.Add(new Cell(ship, 0, 1));
                            retShip.Add(new Cell(ship, 1, 0));
                            retShip.Add(new Cell(ship, 1, 1));
                            retShip.Add(new Cell(ship, 1, 2));
                            ship.Height = 2;
                            ship.Width = 3;
                            break;
                        case 1:
                            retShip.Add(new Cell(ship, 0, 0));
                            retShip.Add(new Cell(ship, 1, 0));
                            retShip.Add(new Cell(ship, 1, 1));
                            retShip.Add(new Cell(ship, 2, 0));
                            ship.Height = 3;
                            ship.Width = 2;
                            break;
                        case 2:
                            retShip.Add(new Cell(ship, 0, 0));
                            retShip.Add(new Cell(ship, 0, 1));
                            retShip.Add(new Cell(ship, 0, 2));
                            retShip.Add(new Cell(ship, 1, 1));
                            ship.Height = 2;
                            ship.Width = 3;
                            break;
                        case 3:
                            retShip.Add(new Cell(ship, 0, 1));
                            retShip.Add(new Cell(ship, 1, 0));
                            retShip.Add(new Cell(ship, 1, 1));
                            retShip.Add(new Cell(ship, 2, 1));
                            ship.Height = 3;
                            ship.Width = 2;
                            break;
                    }/*
                    retShip.Add(new Cell(inpShip, 0, 1));
                    retShip.Add(new Cell(inpShip, 1, 0));
                    retShip.Add(new Cell(inpShip, 1, 2));
                    retShip.Add(new Cell(inpShip, 1, 1));
                    ship.Height = 2;
                    ship.Width = 3;*/
                    break;
                case "heavyCruiser":
                    
                    retShip.Add(new Cell(ship, 0, 1));
                    retShip.Add(new Cell(ship, 1, 0));
                    retShip.Add(new Cell(ship, 1, 2));
                    retShip.Add(new Cell(ship, 1, 1));
                    retShip.Add(new Cell(ship, 2, 1));
                    ship.Height = 3;
                    ship.Width = 3;
                    break;
                case "katamaran":
                    switch (ship.Rotation)
                    {
                        case 0:
                            retShip.Add(new Cell(ship, 0, 0));
                            retShip.Add(new Cell(ship, 0, 2));
                            retShip.Add(new Cell(ship, 1, 0));
                            retShip.Add(new Cell(ship, 1, 1));
                            retShip.Add(new Cell(ship, 1, 2));
                            retShip.Add(new Cell(ship, 2, 0));
                            retShip.Add(new Cell(ship, 2, 2));
                            ship.Height = 3;
                            ship.Width = 3;
                            break;
                        case 1:
                            retShip.Add(new Cell(ship, 0, 0));
                            retShip.Add(new Cell(ship, 0, 1));
                            retShip.Add(new Cell(ship, 0, 2));
                            retShip.Add(new Cell(ship, 1, 1));
                            retShip.Add(new Cell(ship, 2, 0));
                            retShip.Add(new Cell(ship, 2, 1));
                            retShip.Add(new Cell(ship, 2, 2));
                            ship.Height = 3;
                            ship.Width = 3;
                            break;
                        case 2:
                            retShip.Add(new Cell(ship, 0, 0));
                            retShip.Add(new Cell(ship, 0, 2));
                            retShip.Add(new Cell(ship, 1, 0));
                            retShip.Add(new Cell(ship, 1, 1));
                            retShip.Add(new Cell(ship, 1, 2));
                            retShip.Add(new Cell(ship, 2, 0));
                            retShip.Add(new Cell(ship, 2, 2));
                            ship.Height = 3;
                            ship.Width = 3;
                            break;
                        case 3:
                            retShip.Add(new Cell(ship, 0, 0));
                            retShip.Add(new Cell(ship, 0, 1));
                            retShip.Add(new Cell(ship, 0, 2));
                            retShip.Add(new Cell(ship, 1, 1));
                            retShip.Add(new Cell(ship, 2, 0));
                            retShip.Add(new Cell(ship, 2, 1));
                            retShip.Add(new Cell(ship, 2, 2));
                            ship.Height = 3;
                            ship.Width = 3;
                            break;
                    }/*
                    retShip.Add(new Cell(inpShip, 0, 0));
                    retShip.Add(new Cell(inpShip, 0, 2));
                    retShip.Add(new Cell(inpShip, 1, 0));
                    retShip.Add(new Cell(inpShip, 1, 1));
                    retShip.Add(new Cell(inpShip, 1, 2));
                    retShip.Add(new Cell(inpShip, 2, 0));
                    retShip.Add(new Cell(inpShip, 2, 2));
                    ship.Height = 3;
                    ship.Width = 3;*/
                    break;
                case "lightBattleship":
                    switch (ship.Rotation)
                    {
                        case 0:
                            retShip.Add(new Cell(ship, 0, 0));
                            retShip.Add(new Cell(ship, 1, 0));
                            retShip.Add(new Cell(ship, 1, 1));
                            ship.Height = 2;
                            ship.Width = 2;
                            break;
                        case 1:
                            retShip.Add(new Cell(ship, 0, 0));
                            retShip.Add(new Cell(ship, 0, 1));
                            retShip.Add(new Cell(ship, 1, 1));
                            ship.Height = 2;
                            ship.Width = 2;
                            break;
                        case 2:
                            retShip.Add(new Cell(ship, 0, 0));
                            retShip.Add(new Cell(ship, 1, 0));
                            retShip.Add(new Cell(ship, 1, 1));
                            ship.Height = 2;
                            ship.Width = 2;
                            break;
                        case 3:
                            retShip.Add(new Cell(ship, 0, 1));
                            retShip.Add(new Cell(ship, 1, 0));
                            retShip.Add(new Cell(ship, 1, 1));
                            ship.Height = 2;
                            ship.Width = 2;
                            break;
                    }
                    break;
                case "carrierII":
                    switch (ship.Rotation)
                    {
                        case 0:
                            retShip.Add(new Cell(ship, 0, 3));
                            retShip.Add(new Cell(ship, 0, 4));
                            retShip.Add(new Cell(ship, 1, 0));
                            retShip.Add(new Cell(ship, 1, 1));
                            retShip.Add(new Cell(ship, 1, 2));
                            retShip.Add(new Cell(ship, 1, 3));
                            retShip.Add(new Cell(ship, 1, 4));
                            ship.Height = 2;
                            ship.Width = 5;
                            break;
                        case 1:
                            retShip.Add(new Cell(ship, 0, 0));
                            retShip.Add(new Cell(ship, 1, 0));
                            retShip.Add(new Cell(ship, 2, 0));
                            retShip.Add(new Cell(ship, 3, 0));
                            retShip.Add(new Cell(ship, 3, 1));
                            retShip.Add(new Cell(ship, 4, 0));
                            retShip.Add(new Cell(ship, 4, 1));
                            ship.Height = 5;
                            ship.Width = 2;
                            break;
                        case 2:
                            retShip.Add(new Cell(ship, 1, 0));
                            retShip.Add(new Cell(ship, 1, 1));
                            retShip.Add(new Cell(ship, 0, 0));
                            retShip.Add(new Cell(ship, 0, 1));
                            retShip.Add(new Cell(ship, 0, 2));
                            retShip.Add(new Cell(ship, 0, 3));
                            retShip.Add(new Cell(ship, 0, 4));
                            ship.Height = 2;
                            ship.Width = 5;
                            break;
                        case 3:
                            retShip.Add(new Cell(ship, 0, 0));
                            retShip.Add(new Cell(ship, 0, 1));
                            retShip.Add(new Cell(ship, 1, 0));
                            retShip.Add(new Cell(ship, 1, 1));
                            retShip.Add(new Cell(ship, 2, 1));
                            retShip.Add(new Cell(ship, 3, 1));
                            retShip.Add(new Cell(ship, 4, 1));
                            ship.Height = 5;
                            ship.Width = 2;
                            break;
                    }
                    break;
            }

            ship.ShipLives = retShip.Count;

            ship.Shape = retShip;
        }

        public void ShipRotate(Ship ship)
        {

            int tmpp = ship.Width;
            ship.Width = ship.Height;
            ship.Height = tmpp;

            foreach (Cell cell in ship.Shape)
            {

                int wMiddle = (int)Math.Ceiling(ship.Width / 2.0);
                int hMiddle = (int)Math.Ceiling(ship.Height / 2.0);

                Console.WriteLine("");
                Console.WriteLine(wMiddle.ToString());
                Console.WriteLine(hMiddle.ToString());

                /*
                if (ship.Width % 2 != 1)
                {
                    Console.WriteLine($"{(ship.Width / 2).ToString()} Modulo");
                    wMiddle = ship.Width / 2;
                    wMiddle++;
                } else
                {
                    wMiddle = ship.Width / 2;
                    Console.WriteLine($"{(ship.Width / 2).ToString()}");

                }

                if (ship.Height % 2 != 1)
                {
                    Console.WriteLine($"{(ship.Height / 2).ToString()} Modulo");

                    hMiddle = ship.Width / 2;
                    hMiddle++;
                } else
                {
                    Console.WriteLine($"{(ship.Height / 2).ToString()}");

                    hMiddle = ship.Width / 2;
                }
                */
                int tmpX = cell.X;
                int tmpY = cell.Y;

                Console.WriteLine(tmpX);
                Console.WriteLine(tmpY);


                if (tmpY < wMiddle)
                {
                    cell.Y = wMiddle -tmpX;
                } else if (tmpY > wMiddle)
                {
                    cell.Y = tmpX + wMiddle;
                } else
                {
                    cell.Y = wMiddle;
                }

                if (tmpX < hMiddle)
                {
                    cell.X = hMiddle -tmpY;
                } else if (tmpX > hMiddle)
                {
                    cell.X = tmpY + hMiddle;
                } else
                {
                    cell.X = hMiddle;
                }

                //Console.WriteLine($"{wMiddle.ToString()} {hMiddle.ToString()} {ship.Height} {ship.Width}");

                /*
                int finX = ship.Height -1 -tmpX;
                int finY = ship.Width -1 -tmpY;


                cell.X = finX;
                

                cell.Y = finY;

                
                /*
                cell.X = ship.Height - cell.Y - 1;
                cell.Y = ship.Width - tmpX - 1;
                /*
                if ((ship.Rotation + 1) % 2 == 1)
                {
                    cell.Y = tmpX;
                    cell.X = ship.Height - 1 - tmpY;
                } else
                {
                    cell.X = tmpY;
                    cell.Y = ship.Width - 1 - tmpX;
                }
                /*
                float newX = cell.X / ship.Height;

                if (newX > 0.5)
                {

                }*/

                Console.ReadLine();

            }

            

            ship.Rotation++;

            if (ship.Rotation == 3)
            {
                ship.Rotation = 0;
            }

        }

        public void ShipDied (Ship ship)
        {

        }

    }
}
