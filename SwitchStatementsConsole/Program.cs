using System;

namespace SwitchStatementsConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject");
            string userFavoriteSubject = Console.ReadLine();

            switch (userFavoriteSubject)
            {
                case "math":
                    Console.WriteLine("Thats great, numbers are important!");
                    break;

                case "english":
                    Console.WriteLine("Thats great, proper grammar is important!");
                    break;

                case "history":
                    Console.WriteLine("Thats great, knowledge of history is important!");
                    break;

                case "science":
                    Console.WriteLine("Thats great, scientist are important!");
                    break;

                case "physical education":
                    Console.WriteLine("Thats great, good health is important!");
                    break;

                default:
                    Console.WriteLine("Thats great, all education is important!");
                    break;

            }
        }
    }
}
