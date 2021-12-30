using System;

namespace SelectionStatementsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.NextDouble();

            Console.WriteLine("Try to guess my favorite number");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("Too Low");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too High");
            }
            else if (userInput == favNumber)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }

            string subject = "Math";

            Console.WriteLine("What is your favorite subject?");
            string userSubject = Console.ReadLine();

            switch (userSubject)
            {
                case "Math":
                    Console.WriteLine("Math is the bees knees");
                    break;
                case "English":
                    Console.WriteLine("English is for fools");
                    break;
                case "History":
                    Console.WriteLine("History takes me back");
                    break;
                case "Science":
                    Console.WriteLine("Science is second to Math");
                    break;
                default:
                    Console.WriteLine("Math Rules");
                    break;

            }
        }
    }
}
