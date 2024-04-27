using System;
using Main;
using Window;

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
            Window_GUI.Refresh();
            Console.Write("Would you like to Evaluate a Grade again?\n");
            Console.Write("Press (y/n): ");
            bool res = char.ToLower(
                Convert.ToChar(Console.ReadKey().KeyChar)
            ) == 'y';


            if(res)
            {
                Console.Write('\n');
                Program.Main();
            }else
            {
                Console.Write('\n');
                Console.Write("Program exited ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Sucessfully\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Thankyou for using this Program\n");
                Console.Write("Follow me for more Content like this!");
                Console.ResetColor();
            }
            
        }
    }
}