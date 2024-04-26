using System;
using Grade_Calculator;

class Program : GradeCalc
{
    public static void Main()
    {
        int grade = RequestGrade();

        Evaluate(grade,(response)=>{
            Console.WriteLine(response);
            return 0;
        });

        Console.WriteLine("Good");
    }
}