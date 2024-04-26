using System;
using Grade_Calculator;

class Program : GradeCalc
{
    public static void Main()
    {
        int grade = 0;
        do
        {
            try
            {
                grade = Convert.ToInt16(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Enter a Valid Grade Number");
                grade = -1;
            }

        } while (grade < 0);

        Evaluate(grade,(response)=>{
            Console.WriteLine(response);
            return 0;
        });

        Console.WriteLine("Good");
    }
}