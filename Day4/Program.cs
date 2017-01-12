using System;
using System.Text;
using System.Collections.Generic;
using System.IO;

namespace Day4
{
    class Program
    {

        static List<string> ReadFile()
        {
            StreamReader sr = new StreamReader(@"..\..\name.txt");
            List<string> myContents = new List<string>();
            string line = sr.ReadLine();
            while (!string.IsNullOrEmpty(line))
            {
                myContents.Add(line);
                line = sr.ReadLine();

            }
            sr.Close();
            return myContents;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the program");
            string[] contents = File.ReadAllLines(@"..\..\name.txt");
            Console.WriteLine(string.Join("@@@@@@", contents));

            // ***************************
            List<string> myOtherList = ReadFile();

            // ***************************

            var myList = new List<string>()
            {
                "sarah", "gayle", "ann"
            };
            myList.Add("joel");
            myList.Add("peanut");
            myList.Add("abraham lincoln");
            string myString = myList.Find(x => x.StartsWith("j"));
            List<string> myOtherString = myList.FindAll(x => x.Length > 4);
            Console.WriteLine(myString);

            var rng = new Random();
            int randomNumber = rng.Next(myList.Count);
            Console.WriteLine(myList[randomNumber]);
            Console.WriteLine(rng.Next(100, 400));
            // TryParse?
            /*
              Topics to cover today
                - List
                - Reading from a file
                - Random number generation 
            */
        }
    }
}
