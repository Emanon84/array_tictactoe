using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_tictactoe
{
    internal class board
    {

        private int activePlayer = 1;

        public int ActivePlayer {
            get { return activePlayer; } 
        
        } 

        private string[,] boardstate =
{
                {"1","2","3" },
                {"4","5","6" },
                {"7","8","9" } 
            };

        public string[,] BoardState
        {
            get { return boardstate; }
            set { boardstate = value; }
        }

        public void ResetBoard()
        {
           string[,] boardstateClean =
{
                {"1","2","3" },
                {"4","5","6" },
                {"7","8","9" } 
            };
            boardstate = boardstateClean;
    }

        public void ChangePlayer()
        {
            if(activePlayer == 1)
            {
                activePlayer = 2;
            }
            else
            { 
                activePlayer = 1; 
            }
        }

        public string SetActivePlayerMark()
        {
            if (activePlayer == 1)
            {
                return "X";
            }
            else
            {
                return "O";
            }
        }


        public void GetBoard()
        {
            Console.WriteLine(
                    @"   
                       |   |
                     {0} | {1} |  {2}
                    ___|___|___
                       |   |
                     {3} | {4} |  {5}
                    ___|___|___
                       |   |   
                     {6} | {7} |  {8}   
                       |   |   "
            , boardstate[0, 0], boardstate[0, 1], boardstate[0, 2], 
              boardstate[1, 0], boardstate[1, 1], boardstate[1, 2], 
              boardstate[2, 0], boardstate[2, 1], boardstate[2, 2]);

        }


        


        public static bool Checker(string[,] board)
        {

            int counterX = 0;
            int counterO = 0;

            //Console.WriteLine("Checking left to right");
            //Diagonal left to right
            for(int i = 0; i< board.GetLength(0); i++)
            {
                for(int j = 0; j<board.GetLength(1); j++)
                {

                    if (i == j)
                    {
                        if (board[i, j].Equals("X"))
                        {
                            counterX++;
                        }
                        else if (board[i, j].Equals("O"))
                        {
                            counterO++;
                        }

                        if(counterX == 3 || counterO == 3)
                        {
                            return true;
                        }
                    }

                }
            }

            //Diagonal right to left
            counterX = 0;
            counterO = 0;
            //Console.WriteLine("Checking right to left");

            for (int i = 0, j = 2; i < board.GetLength(0); i++, j--)
            {

                if (board[i, j].Equals("X"))
                {
                    counterX++;
                }
                else if (board[i, j].Equals("O"))
                {
                    counterO++;
                }

                if (counterX == 3 || counterO == 3)
                {
                    return true;
                }

            }

            // Rows
            //Console.WriteLine("Checking rows");
            counterX = 0;
            counterO = 0;

            for (int i = 0; i < board.GetLength(0); i++)
            {
                //Console.WriteLine("loop1");
                for (int j = 0; j < board.GetLength(1); j++)
                {
                   //Console.WriteLine("loop2");

                    //Console.WriteLine(board[i, j]);
                    if (board[i, j].Equals("X"))
                    {
                        counterX++;
                    }
                    else if (board[i, j].Equals("O"))
                    {
                        counterO++;
                    }

                    if (counterX == 3 || counterO == 3)
                    {
                        //Console.WriteLine("Tre i rad!. nollar counters");
                        return true;
                    }

                    if (j == 2)
                    {
                       // Console.WriteLine("Nollar counters");
                        counterX = 0;
                        counterO = 0;
                    }


                }
            }

            //Columns
            //Console.WriteLine("Checking columns");
            counterX = 0;
            counterO = 0;

            for (int i = 0; i < board.GetLength(1); i++)
            {
                //Console.WriteLine("loop1");
                for (int j = 0; j < board.GetLength(0); j++)
                {
                    //Console.WriteLine("loop2");

                    //Console.WriteLine(board[i, j]);
                    if (board[j, i].Equals("X"))
                    {
                        counterX++;
                    }
                    else if (board[j, i].Equals("O"))
                    {
                        counterO++;
                    }

                    if (counterX == 3 || counterO == 3)
                    {
                        //Console.WriteLine("Tre i rad!. nollar counters");
                        return true;
                    }

                    if (j == 2)
                    {
                        // Console.WriteLine("Nollar counters");
                        counterX = 0;
                        counterO = 0;
                    }
                }
            }
            return false;
        }


        public static bool Checker2(string[,] board)
        {

            for (int i = 0; i < board.GetLength(0); i++)
            {
                //vertical
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                {
                    return true;
                }
                //horizontal
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
                {
                    return true;
                }

                //Diagonal right to left

                if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                {
                    return true;
                }

                //Diagonal left to right

                if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
                {
                    return true;
                }
            }
            return false;
        }


    }
}
