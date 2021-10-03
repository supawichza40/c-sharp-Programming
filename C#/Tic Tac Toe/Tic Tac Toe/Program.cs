using System;

namespace Tic_Tac_Toe
{
    class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                string[,] ticTakToeBoard =
{
                {"1","2","3" },
                {"4","5","6" },
                {"7","8","9" },

            };
                int count = 0;
                while (true)
                {
                    string playerOne = "O";
                    string playerTwo = "X";
                    bool correctInput = true;
                    string userInputString = "";
                    //1. define all the variable for the game including the board and players 
                    displayBoard(ticTakToeBoard);
                    //2. have a loop for player1 and player 2 with the same commentary for both of them
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Player one, what is your option?1-9");
                            userInputString = Console.ReadLine();
                            correctInput = Int32.TryParse(userInputString, out int result);
                            if (correctInput == true && result>=1 &&result<=9)
                            {
                                break;
                                count++;
                                
                            }
                            else if (correctInput == false)
                            {
                                Console.WriteLine("Invalid Input");
                            }
                        }
                        catch (Exception)
                        {

                            Console.WriteLine("Invalid Input, please try again, must be a number and range between 1-9");
                        }

                    }

                    changeBoard(ticTakToeBoard, playerOne, userInputString);
                    Console.Clear();
                    //3.Every time there is a change in the board we need to check for the winner both horizontal, vertical and diagonal
                    displayBoard(ticTakToeBoard);
                    bool playerWin = checkForWinner(ticTakToeBoard,count);
                    if (playerWin == true)
                    {
                        Console.WriteLine("Press any key to reset the game");
                        Console.ReadKey();
                        break;


                    }
                    Console.Clear();
                    //1. define all the variable for the game including the board and players 
                    displayBoard(ticTakToeBoard);
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Player Two, what is your option?1-9");
                            userInputString = Console.ReadLine();
                            correctInput = Int32.TryParse(userInputString, out int result);
                            if (correctInput == true && result >= 1 && result <= 9)
                            {
                                break;
                                count++;

                            }
                            else if (correctInput == false)
                            {
                                Console.WriteLine("Invalid Input, please try again, must be a number and range between 1-9");
                            }
                        }
                        catch (Exception)
                        {

                            Console.WriteLine("Invalid Input, please try again, must be a number and range between 1-9");
                        }

                    }

                    //2. have a loop for player1 and player 2 with the same commentary for both of them

                    changeBoard(ticTakToeBoard, playerTwo, userInputString);
                    //3.Every time there is a change in the board we need to check for the winner both horizontal, vertical and diagonal

                    playerWin = checkForWinner(ticTakToeBoard,count);
                    if (playerWin == true)
                    {
                        Console.WriteLine("Press any key to reset the game");
                        Console.ReadKey();
                        break;


                    }
                    Console.Clear();
                }



            }
        }

        public static bool checkForWinner(string[,] ticTakToeBoard,int count)
        {
            //check for Horizontal win
            for (int i = 0; i < ticTakToeBoard.GetLength(0); i++)
            {
                for (int j = 0; j < ticTakToeBoard.GetLength(1)-2; j++)
                {
                    if (ticTakToeBoard[i,j]==ticTakToeBoard[i,j+1]&& ticTakToeBoard[i,j]==ticTakToeBoard[i,j+2])
                    {
                        if (ticTakToeBoard[i,j]=="X")
                        {
                            Console.WriteLine("The Winner is playerTwo by Horizontal Win");
                            return true;
                        }
                        else if (ticTakToeBoard[i, j] == "O")
                        {
                            Console.WriteLine("The Winner is playerOne by Horizontal Win");
                            return true;
                        }
                        else if(count==9)
                        {
                            Console.WriteLine("This match is a draw");
                            return true;
                        }
                    }
                }
            }
            


            //checked for vertical win
            for (int i = 0; i < ticTakToeBoard.GetLength(0)-2; i++)
            {
                for (int j = 0; j < ticTakToeBoard.GetLength(1); j++)
                {
                    if (ticTakToeBoard[i, j] == ticTakToeBoard[i+1, j] && ticTakToeBoard[i, j] == ticTakToeBoard[i+2, j])
                    {
                        if (ticTakToeBoard[i, j] == "X")
                        {
                            Console.WriteLine("The Winner is playerTwo by Vertical Win");
                            return true;
                        }
                        else if (ticTakToeBoard[i, j] == "O")
                        {
                            Console.WriteLine("The Winner is playerOne by Vertical Win");
                            return true;
                        }
                    }
                }
            }
            //checked for diagonal win
            for (int i = 0; i < ticTakToeBoard.GetLength(0)-2; i++)
            {
                if (ticTakToeBoard[i,i]==ticTakToeBoard[i+1,i+1] &&ticTakToeBoard[i,i]==ticTakToeBoard[i+2,i+2])
                {
                    if (ticTakToeBoard[i, i] == "X")
                    {
                        Console.WriteLine("The Winner is playerTwo by Diagonal Win");
                        return true;
                    }
                    else if (ticTakToeBoard[i, i] == "O")
                    {
                        Console.WriteLine("The Winner is playerOne by Diagonal Win");
                        return true;
                    }
                }
                if (ticTakToeBoard[0,2]==ticTakToeBoard[1,1]&&ticTakToeBoard[2,0]==ticTakToeBoard[1,1])
                {
                    if (ticTakToeBoard[1,1] == "X")
                    {
                        Console.WriteLine("The Winner is playerTwo by Diagonal Win");
                        return true;
                    }
                    else if (ticTakToeBoard[1,1] == "O")
                    {
                        Console.WriteLine("The Winner is playerOne by Diagonal Win");
                        return true;
                    }
                }
            }

            return false;
        }
 
        public static void displayBoard(string[,] ticTakToeBoard)
        {
            for (int i = 0; i < ticTakToeBoard.GetLength(0); i++)
            {

                for (int j = 0; j < ticTakToeBoard.GetLength(1); j++)
                {

                    Console.Write("|" + ticTakToeBoard[i, j] + "|");

                }
                Console.WriteLine();
                if (i == ticTakToeBoard.GetLength(0) - 1)
                {
                    break;
                }
                Console.WriteLine("-----------");

            }
        }
        public static void changeBoard(string[,] ticTakToeBoard,string playerOneOrTwo,string location)
        {
            for (int i = 0; i < ticTakToeBoard.GetLength(0); i++)
            {
                for (int j = 0; j < ticTakToeBoard.GetLength(1); j++)
                {
                    if (ticTakToeBoard[i,j] == location)
                    {
                        ticTakToeBoard[i, j] = playerOneOrTwo;
                    }
                }
            }
        }

    }
}
