using System.ComponentModel.DataAnnotations;

namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test Cases for all Challenges 
            Challenge1();
            //Challenge2();
            //Challenge3();
            //Challenge4();

        }

        public static int Challenge1()
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

        public static decimal Challenge2()
        {
            Console.WriteLine("Please enter a number between 2 - 10: ");

            int length = Convert.ToInt32(Console.ReadLine());
            while (length < 2 || length > 10)
            {
                Console.Write("Enter a number between 2 - 10: ");
                length = Convert.ToInt32(Console.ReadLine());
            }
            decimal[] range = new decimal[length];
            decimal sum = 0;
            for (int i = 0; i < range.Length; i++)
            {
                Console.Write($"{i + 1} of {range.Length} - Enter number here: ");
                decimal userInput = Convert.ToInt32(Console.ReadLine());
                if(userInput >= 0)
                {
                    sum += userInput;
                }
                else
                {
                    sum += 0;
                    Console.WriteLine("Input was not a number. Defualt Value: 0");
                }
            }
            decimal average = sum / Convert.ToDecimal(range.Length);
            Console.WriteLine($"Your average for these {range.Length} numbers is: {average}");
            return average;
        }

        public static void Challenge3()
        {
            int n = 5; // Number of rows in the pattern

            // Upper half of the pattern
            for (int i = 1; i <= n; i++)
            {
                // Print spaces before the stars
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                // Print stars
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            // Lower half of the pattern
            for (int i = n - 1; i >= 1; i--)
            {
                // Print spaces before the stars
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                // Print stars
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        public static int Challenge4()
        {
            Console.Write("Enter a number between 1 - 10:");
            int length = Convert.ToInt32(Console.ReadLine());

            while(length < 1 || length > 10)
            {
                Console.Write("Enter a number between 1 - 10: ");
                length = Convert.ToInt32(Console.ReadLine());
            }

            int[] nums = new int[length];
            int userInput;
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{i + 1} of {nums.Length} - Enter a number: ");
                userInput = Convert.ToInt32(Console.ReadLine());
                nums[i] = userInput;
            }

            int mostUsedNum = nums[0];
            int mostUsedCount = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                int count = 0;
                for(int x = 0; x < nums.Length; x++)
                {
                    if (nums[x] == nums[i])
                    {
                        count++;
                    }
                }
                if(count > mostUsedCount)
                {
                    mostUsedCount = count;
                    mostUsedNum = nums[i];
                }
            }
            Console.WriteLine($"Output: {mostUsedNum}");
            return mostUsedNum;
        }

        //public static int Challenge5()
        //{
        //    Console.Write("Enter a number between 1 and 10: ");

        //    int length = Convert.ToInt32(Console.ReadLine());
        //    while( length < 1 || length > 10)
        //    {
        //        Console.Write("Enter a number between 1 and 10: ");
        //        length = Convert.ToInt32(Console.ReadLine());
        //    }
        //    int[] nums = new int[length];
        //    int userInput;
        //    for(int i = 0; i < nums.Length; i++)
        //    {
        //        Console.Write($"{i + 1} of {nums.Length} - Enter a number here: ");
        //        userInput = Convert.ToInt32(Console.ReadLine());
        //        nums[i] = userInput;
        //    }
        //    int topDogNum = nums[0];
        //    for(int i = 0; i < nums.Length; i++)
        //    {
        //        if(topDogNum = )
        //    }
        //}
    }
}
