using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStatementExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int favoriteNumber = 42;
            Console.WriteLine("Guess the favorite number. Hint: my age");
            int userGuess = int.Parse(Console.ReadLine());

            if (userGuess < favoriteNumber)
            {
                Console.WriteLine("Too LOW!!!");

            }
            else if (userGuess > favoriteNumber)
            {
                Console.WriteLine("Too HIGH!!!");

            }
            else if (userGuess == favoriteNumber)
            {
                Console.WriteLine("You were CORRECT!!!");

            }
            else
            {
                Console.WriteLine("Nevermind");

            }

            string subject  = "c#";

            Console.WriteLine("Choose a subject");
            string userSubject = Console.ReadLine();

            switch (userSubject)
            {
                case "c#":
                    Console.WriteLine("You are in the right class!");
                    break;
                case "Java":
                    Console.WriteLine("C# is better than Java");
                    break;
                    

                default:
                    Console.WriteLine("We teach coding here!");
                    break;
            }
        }   
       

    }
}
