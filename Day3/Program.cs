using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program
    {
        static string AyStyle(string myString)
        {
            return $"{myString}ay";
        }

        static void DrawBoard(string[] board)
        {
            int counter = 0;
            foreach (string place in board)
            {
                Console.Write(" " + place);
                if (counter == 2)
                {
                    Console.WriteLine("");
                    counter = 0;
                }
                else
                {
                    counter++;
                }
            }
        }

        static string Input(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        static void Main(string[] args)
        {

            string data = Input("Please give me some data");

            string[] board = {
                "_","_","_","_","_","_","_","_","_"
            };

            while(true)
            {
                DrawBoard(board);
                int location = int.Parse(Console.ReadLine());
                //board[location] = "X";
            }


            string myName = Console.ReadLine();
            Console.WriteLine(AyStyle(myName));
            /* 
            bool playAgain = true;
            string player = "joel";
            int guess;

            while (playAgain)
            {
                Console.WriteLine($"{player} guess a number: ");
                guess = int.Parse(Console.ReadLine());

                if (guess <= 5)
                {
                    playAgain = false;
                }
                else
                {
                    player = player == "joel" ? "sarah" : "joel";
                }


            }
            Console.WriteLine($"{player} LOST!!!!");
            */
        }
    }
}
