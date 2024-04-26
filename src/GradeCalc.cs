using System;

namespace Grade_Calculator
{
    class GradeCalc
    {
        public static void Evaluate(int grade, Func<string, int> callback)
        {
            callback($"Your Grade is {grade}");
        }
    }
}