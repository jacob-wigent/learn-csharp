/*  Welcome to Learn C# lesson 0: Getting Started.
    In this lesson, you will learn how to run programs and interact with the terminal.

    If you need help at any point, please let one of the instructors know!
*/
using System;

/*This is a namespace, which acts as a folder to contain classes.*/
namespace Learn_CSharp
{
    /*This is a class, which contains methods/functions and variables (you'll learn about these later!!)*/
    public class GettingStarted_Solution
    {
        public static void main()
        {
            /* This is where all your code goes! :) */

            Console.WriteLine("Hello World");

            /*  Here you can customize the console!
                Try using:
                Console.Title = "Title"
                Console.ForegroundColor = ConsoleColor.Green
                Console.WindowHeight = 40
            */

            Console.Title = "Conversation";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WindowHeight = 30;

            /*Try creating your own conversation below using `Console.WriteLine()` and `Console.ReadLine()`:*/

            Console.WriteLine("Hello user, what is your name?");
            Console.ReadLine();
            Console.WriteLine("What is your favorite video game?");
            Console.ReadLine();
            Console.WriteLine("Cool! Mine is Tetris!");
            Console.ReadKey();

            /**/
            Console.ReadKey();
        }
    }
}