using System;

namespace _001_BMIConsole // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // BMI계산기를 만든다
            // bmi = 체중/키의제곱

            Console.WriteLine("키를 입력(cm) : ");
            string s = Console.ReadLine();
            float h = float.Parse(s) / 100;

            Console.WriteLine("체중을 입력(kg) : ");
            s = Console.ReadLine();
            float w = float.Parse(s);

            float bmi = w / (h * h);
            Console.WriteLine("bmi = " + bmi);
        }
    }
}