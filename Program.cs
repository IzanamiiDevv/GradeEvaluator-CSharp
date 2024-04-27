using System;
using Grade_Calculator;

namespace Main
{
    class Program : GradeCalc
    {
        public static void Main()
        {
            int grade = RequestGrade();

            Evaluate(grade,(response)=>{
                Console.WriteLine(response);
                return 0;
            });

            RequestLoop();
        }
    }
}