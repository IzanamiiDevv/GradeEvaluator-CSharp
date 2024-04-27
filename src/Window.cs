using System;

namespace Window
{
    class Window_GUI
    {
        public static void Load()
        {
            Console.Title = "Grade Evaluator In C#";
            Console.WriteLine(Console.WindowWidth);
            Console.WriteLine(Console.WindowHeight);
            Console.WriteLine(Console.WindowTop);
            Console.WriteLine(Console.WindowLeft);
        }
    }
}