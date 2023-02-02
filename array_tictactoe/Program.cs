using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace array_tictactoe
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Create Board
            board Board1 = new board();

           // Track used squares
            int[] usedVals = new int[] {};

            string input = "";
            do
            {

            do
            {
                Board1.GetBoard();
                Console.WriteLine("Player {0}: Choose where to put your sign", Board1.ActivePlayer);
                input = Console.ReadLine();
                if (input.Length != 1 || input.Equals("0"))
                {
                    Console.Clear();
                    Console.WriteLine("You must choose 1-9");
                }
                else
                {
                    if (!int.TryParse(input, out int value))
                    {
                        Console.Clear();
                        Console.WriteLine("Value must be an integer!");
                    }
                    else if (usedVals.Contains(value))
                    {
                        Console.Clear();
                        Console.WriteLine("{0} has already been used. Try again.", value);
                    }
                    else
                    {
                        //Mark square
                        Console.Clear();
                        switch (value)
                        {
                            case 1:
                                {
                                    usedVals = usedVals.Append(value).ToArray();
                                    Board1.BoardState[0, 0] = Board1.SetActivePlayerMark();
                                    Board1.ChangePlayer();
                                    break;
                                }
                            case 2:
                                {
                                    usedVals = usedVals.Append(value).ToArray();
                                    Board1.BoardState[0, 1] = Board1.SetActivePlayerMark();
                                    Board1.ChangePlayer();
                                    break;
                                }
                            case 3:
                                {
                                    usedVals = usedVals.Append(value).ToArray();
                                    Board1.BoardState[0, 2] = Board1.SetActivePlayerMark();
                                    Board1.ChangePlayer();
                                    break;
                                }
                            case 4:
                                {
                                    usedVals = usedVals.Append(value).ToArray();
                                    Board1.BoardState[1, 0] = Board1.SetActivePlayerMark();
                                    Board1.ChangePlayer();
                                    break;
                                }
                            case 5:
                                {
                                    usedVals = usedVals.Append(value).ToArray();
                                    Board1.BoardState[1, 1] = Board1.SetActivePlayerMark();
                                    Board1.ChangePlayer();
                                    break;
                                }
                            case 6:
                                {
                                    usedVals = usedVals.Append(value).ToArray();
                                    Board1.BoardState[1, 2] = Board1.SetActivePlayerMark();
                                    Board1.ChangePlayer();
                                    break;
                                }
                            case 7:
                                {
                                    usedVals = usedVals.Append(value).ToArray();
                                    Board1.BoardState[2, 0] = Board1.SetActivePlayerMark();
                                    Board1.ChangePlayer();
                                    break;
                                }
                            case 8:
                                {
                                    usedVals = usedVals.Append(value).ToArray();
                                    Board1.BoardState[2, 1] = Board1.SetActivePlayerMark();
                                    Board1.ChangePlayer();
                                    break;
                                }
                            case 9:
                                {
                                    usedVals = usedVals.Append(value).ToArray();
                                    Board1.BoardState[2, 2] = Board1.SetActivePlayerMark();
                                    Board1.ChangePlayer();
                                    break;
                                }

                            default:
                                break;
                        }


                    }
                }


            } while (!board.Checker2(Board1.BoardState) && usedVals.Length < 9);

            Board1.GetBoard();

            if (board.Checker2(Board1.BoardState)){
 
                Board1.ChangePlayer();
                Console.WriteLine("Game over! A winner is player {0}!", Board1.ActivePlayer);

            }
            else
            {
                Console.WriteLine("Game over! It's a draw!");
            }

            Console.WriteLine("Pressa ny key to play again!");
                Console.ReadLine();
                Console.Clear();
                Board1.ResetBoard();
                //Array.Clear(usedVals, 0, usedVals.Length);
                usedVals = new int[] { };

            } while (true);
        }
    }
}
