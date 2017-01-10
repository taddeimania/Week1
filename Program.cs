using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] board = {
                "_","_","_","_","_","_","_","_","_"
            };

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

            var myString = "joel";
            var cleanedString = myString.Replace('o', '0');
            int classSize = int.Parse(Console.ReadLine());
            int[] ages = new int[classSize];

            for (int i = 0; i < classSize; i++)
            {
                Console.WriteLine($"Age of {i} student?");
                ages[i] = int.Parse(Console.ReadLine());

                if (i == 2)
                {
                    Console.WriteLine("MAGIC PERSON!");
                }
                else if (i == 3)
                {
                    Console.WriteLine("UNLUCKY PERSON!");
                }

            }

            foreach (var age in ages)
            {
                string readableDrinkAge;
                bool isLegalToDrink = age >= 21;
                if (isLegalToDrink)
                {
                    readableDrinkAge = "Yes";
                }
                else
                {
                    readableDrinkAge = "No";
                }

                readableDrinkAge = age >= 21 ? "Yes" : "No";
                Console.Write($"{age} is legal to drink? {readableDrinkAge}");
            }
            Console.WriteLine("------");
            Console.WriteLine(ages.Max()); 
            Console.WriteLine(ages.Min());
            Console.WriteLine(ages.Average());

            string[] myArray = new string[9];
            myArray[0] = "X";
            
            Console.WriteLine(myArray);
        }
    }
}
