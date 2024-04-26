using System;

namespace Grade_Calculator
{
    class GradeCalc
    {
        public static void Evaluate(int grade, Func<string, int> callback)
        {
            callback($"Your Grade is {grade}");
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
    }
}