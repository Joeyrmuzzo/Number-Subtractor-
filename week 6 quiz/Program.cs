using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_6_quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int value;
            double[] numbers = new double[5];
            for (int index = 0; index < 5; index++) 
            {
                Console.WriteLine("Please enter a number: ");
                numbers[index] = Convert.ToDouble(Console.ReadLine());
            }
            {
                Console.WriteLine("Please enter a number to subtract by: ");
                value = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("After subtracting by : " + value + " the numbers are :");
            }
            
            for(int index = 0; index <5;index++)
                {
                numbers[index] = numbers[index] - value;
                Console.WriteLine(numbers[index]);
                }
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
            
        }
    }
}
