using System;

namespace NumberOfStepsToReduceANumberToZero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1342.
            //int num = 14;
            //int num = 8;
            //int num = 123;
            //int num = 0;

            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            int numberOfSteps = Solution.NumberOfSteps(num);

            Console.WriteLine(numberOfSteps);

            Console.WriteLine("Done processing.");
            Console.ReadLine();
        }
    }
}
