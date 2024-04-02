using System;
namespace CsharpString
{
    class Test
    {
        public static void Main(string[] args)
        {
            string text = "Chocolate";
            bool result;

            //checks if text ends with late
            result = text.EndsWith("late");
            Console.WriteLine("Ends with late: " + result);

            //checks if text ends with gate
            result = text.EndsWith("gate");
            Console.WriteLine("Ends with gate: " + result);

            Console.ReadLine();
        }
    }
}