using System;
using Main;

namespace Grade_Calculator
{
    class GradeCalc
    {
        public static void Evaluate(int grade, Func<string, int> callback)
        {
            if (grade >= 101) callback("Invalid Grade");
            if (grade <= 100 && grade >= 98) callback("With Highest Honors");
            if (grade <= 97 && grade >= 95) callback("With High Honors");
            if (grade <= 94 && grade >= 90) callback("With Honors");
            if (grade <= 89 && grade >= 75) callback("Passed");
            if (grade <= 74) callback("Failed");
        }

        public static int RequestGrade()
        {
            bool isFirst = true;
            int grade;
            do
            {
                try
                {
                    if(isFirst)
                    {
                        Console.Write("Enter a ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("Number\n");
                        Console.ResetColor();
                    }else
                    {
                        Console.Write("Enter a ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Valid ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("Number\n");
                        Console.ResetColor();
                    }
                    Console.Write("->");
                    grade = Convert.ToInt16(Console.ReadLine());
                }
                catch (Exception)
                {
                    grade = -1;
                    isFirst = false;
                }

            } while (grade < 0);
            return grade;
        }

        public static void RequestLoop()
        {
            Console.Write("Would you like to Evaluate a Grade again?\n");
            Console.Write("Press (y/n): ");
            bool res = Convert.ToChar(
            (Console.ReadKey() + "")
            .ToLower()) == 'y';

            if(res)
            {
                Program.Main();
            }else
            {
                Console.Write("Program exited ");
                Console.Write("Sucessfully");
                Console.Write("Thankyou for using this Program!");
                Console.Write("Follow me for more Content like this1");
            }
            
        }
    }
}