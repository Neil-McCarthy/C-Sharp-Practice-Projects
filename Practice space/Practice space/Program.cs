using System;

namespace Practice_space
{
    class Program
    {
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
            //int userInputRowConverted;
            int userInputColumn;
            //int userInputColumnConverted;
            string playerOutput;
            string output;
            while (gamePlaying)
            {
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

                //MUST COME BACK AND DO USER INPUT CHECKS
                Console.WriteLine("\nPlease enter the row number :");
                userInputRow = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the column number :");
                userInputColumn = Int32.Parse(Console.ReadLine());
                if (playerSelector == true)
                {
                    playerOutput = "X";
                    playerSelector = false;
                } else
                {
                    playerOutput = "O";
                    playerSelector = true;
                }
                ticTacToe[userInputRow, userInputColumn] = playerOutput;

                //MUST COME BACK AND MAKE THIS A FUNCTION
                for (int counter = 0; counter < 3; counter++)
                {
                    if (ticTacToe[counter, 0] == "X" && ticTacToe[counter, 1] == "X" && ticTacToe[counter, 2] == "X" || ticTacToe[0, counter] == "X" && ticTacToe[1, counter] == "X" && ticTacToe[2, counter] == "X")
                    {
                        Console.WriteLine("Player One wins with Xs. Well done!");
                        gamePlaying = false;
                    }
                    if (ticTacToe[counter, 0] == "O" && ticTacToe[counter, 1] == "O" && ticTacToe[counter, 2] == "O" || ticTacToe[0, counter] == "O" && ticTacToe[1, counter] == "O" && ticTacToe[2, counter] == "O")
                    {
                        Console.WriteLine("Player Two wins with Os. Well done!");
                        gamePlaying = false;
                    }
                }
                if (ticTacToe[0, 0] == "X" && ticTacToe[1, 1] == "X" && ticTacToe[2, 2] == "X" || ticTacToe[0, 2] == "X" && ticTacToe[1, 1] == "X" && ticTacToe[2, 0] == "X")
                {
                    Console.WriteLine("Player One wins with Xs. Well done!");
                    gamePlaying = false;
                }
                if (ticTacToe[0, 0] == "O" && ticTacToe[1, 1] == "O" && ticTacToe[2, 2] == "O" || ticTacToe[0, 2] == "O" && ticTacToe[1, 1] == "O" && ticTacToe[2, 0] == "O")
                {
                    Console.WriteLine("Player Two wins with Os. Well done!");
                    gamePlaying = false;
                }

                }
            Console.ReadLine();

        }
    }
}

