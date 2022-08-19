using System;

namespace Practice_space
{
    class Program
    {
        static bool WinCheck(string specificPlayer, string[,] game)
        {
            for (int counter = 0; counter < 3; counter++)
            {
                if (game[counter, 0] == specificPlayer && game[counter, 1] == specificPlayer && game[counter, 2] == specificPlayer || game[0, counter] == specificPlayer && game[1, counter] == specificPlayer && game[2, counter] == specificPlayer)
                {
                    Console.WriteLine(specificPlayer + "'s have won. Well done!");
                    return true;
                }
            }
            if (game[0, 0] == specificPlayer && game[1, 1] == specificPlayer && game[2, 2] == specificPlayer || game[0, 2] == specificPlayer && game[1, 1] == specificPlayer && game[2, 0] == specificPlayer)
            {
                Console.WriteLine(specificPlayer + "'s have won. Well done!");
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {

            //TIC TAC TOE
            string[,] ticTacToe = new string[,]
            {
                {"-","-","-"},
                {"-","-","-"},
                {"-","-","-"}
            };



            bool gamePlaying = true;
            bool playerSelector = true;
            int userInputRow;
            int userInputColumn;
            string playerOutput;
            string output;
            string feedback = "";
            while (gamePlaying)
            {
                Console.Clear();
                Console.WriteLine(feedback);

                //INPUT CHECKS
                Console.WriteLine("Current board:\n");
                for (int row = 0; row < ticTacToe.GetLength(0); row++)
                {
                    output = "";
                    for (int column = 0; column < ticTacToe.GetLength(1); column++)
                    {
                        output = output + ticTacToe[row, column].ToString() + " ";
                    }
                    Console.WriteLine(output);
                }

                Console.WriteLine("\nPlease enter the row number :");
                if (int.TryParse(Console.ReadLine(), out userInputRow))
                {
                    if (userInputRow < 0 || userInputRow > 2)
                    {
                        feedback = "Sorry but that value is not an option.\nTry something between 0 and 2.\n";
                        continue;
                    }
                    feedback = "";
                }
                else
                {
                    feedback = "Sorry but that value is not an option.\nTry something between 0 and 2.\n";
                    continue;
                }

                Console.WriteLine("Please enter the column number :");
                if (int.TryParse(Console.ReadLine(), out userInputColumn))
                {
                    if (userInputColumn < 0 || userInputColumn > 2)
                    {
                        feedback = "Sorry but that value is not an option.\nTry something between 0 and 2.\n";
                        continue;
                    }
                    feedback = "";
                }
                else
                {
                    feedback = "Sorry but that value is not an option.\nTry something between 0 and 2.\n";
                    continue;
                }
                if (ticTacToe[userInputRow, userInputColumn] != "-")
                {
                    feedback = "Sorry but it looks like that space is already taken.\nPlease try another spot.\n";
                    continue;
                }
                if (playerSelector == true)
                {
                    playerOutput = "X";
                    playerSelector = false;
                }
                else
                {
                    playerOutput = "O";
                    playerSelector = true;
                }

                ticTacToe[userInputRow, userInputColumn] = playerOutput;

                if (WinCheck(playerOutput, ticTacToe))
                {
                    gamePlaying = false;
                }
            }
            Console.ReadLine();
        }
    }
}