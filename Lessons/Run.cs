/*  This is where you can choose what program to run! */
using System;
using Microsoft.VisualBasic;

namespace Learn_CSharp
{
    public class Initializer
    {


        /***** CHOOSE WHICH LESSON TO RUN HERE ******/
        private static int lesson = 0;
        /********************************************/



        private static Dictionary<int, Action> lessonMap = new Dictionary<int, Action>
        {
            { 0, GettingStarted.main },
            // { 1, DataTypesAndVaraibles.main },
            // { 2, LogicAndConditionals.main },
        };

        public static void Main()
        {
            if (lessonMap.TryGetValue(lesson, out Action ?action))
            {
                Console.Write($"Running Lesson {lesson}...");
                Thread.Sleep(2000);
                Console.Clear();
                action();
            }
            else
            {
                Console.WriteLine($"Lesson {lesson} does not exist!");
                Console.ReadKey();
            }
        }
    }
}