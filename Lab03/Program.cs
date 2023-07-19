using System;
using System.IO;
using System.Linq;

namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Challenge 1
            // Method to calculate the product of three numbers input by the user
            int ProductOfThreeNumbers()
            {
                Console.Write("Please enter 3 numbers: ");
                string[] numbers = Console.ReadLine().Split();
                if (numbers.Length < 3)
                    return 0;

                int product = 1;
                for (int i = 0; i < 3; i++)
                {
                    if (int.TryParse(numbers[i], out int num))
                        product *= num;
                    else
                        product *= 1;
                }

                return product;
            }

            // Test Cases for Challenge 1
            Console.WriteLine(ProductOfThreeNumbers()); // Test 1
            Console.WriteLine(ProductOfThreeNumbers()); // Test 2
            Console.WriteLine(ProductOfThreeNumbers()); // Test 3
            Console.WriteLine(ProductOfThreeNumbers()); // Test 4
        }
    }
}
