using System;
using Grade_Calculator;
using Window;

namespace Main
{
    class Program : GradeCalc
    {
        public static void Main()
        {
            Window_GUI.Load();
            
            int grade = RequestGrade();

            Evaluate(grade,(response)=>{
                Console.WriteLine(response);
                return 0;
            });

            RequestLoop();
        }
    }
}