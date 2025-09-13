using System;
using Tyuiu.ChetvertnyhAI.Sprint0.Task4.V0.Lib;
namespace Tyuiu.ChetvertnyhAI.Sprint0.Task4.V0
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(17,6));
            Console.WriteLine(DataService.Subtraction(143, 59));
            Console.WriteLine(DataService.Multiplication(18, 5));
            Console.WriteLine(DataService.Division(7, 7));
            Console.ReadKey();
        }
    }
}