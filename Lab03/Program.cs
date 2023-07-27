namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 0;
            do
            {
                Console.WriteLine("Enter 1 to run Challenge 1");
                Console.WriteLine("Enter 2 to run Challenge 2");
                Console.WriteLine("Enter 3 to run Challenge 3");
                Console.WriteLine("Enter 4 to run Challenge 4");
                Console.WriteLine("Enter 5 to run Challenge 5");
                Console.WriteLine("Enter 6 to run Challenge 6");
                Console.WriteLine("Enter 7 to run Challenge 7");
                Console.WriteLine("Enter 8 to run Challenge 8");
                Console.WriteLine("Enter 9 to run Challenge 9");
                Console.WriteLine("Enter 10 to exit");
                int action = Convert.ToInt32(Console.ReadLine());

                if (action == 1)
                {
                    Console.WriteLine("Enter in 3 numbers: ");
                    string input = Console.ReadLine();
                    Challenge1(input);
                    Console.ReadLine();
                }
                else if (action == 2)
                {
                    Challenge2();
                    Console.ReadLine();
                }
                else if (action == 3)
                {
                    Challenge3();
                    Console.ReadLine();
                }
                else if (action == 4)
                {
                    Challenge4();
                    Console.ReadLine();
                }
                else if (action == 5)
                {
                    Challenge5();
                    Console.ReadLine();
                }
                else if (action == 6)
                {
                    Challenge6();
                    Console.ReadLine();
                }
                else if (action == 7)
                {
                    Challenge7();
                    Console.ReadLine();
                }
                else if (action == 8)
                {
                    Challenge8();
                    Console.ReadLine();
                }
                else if (action == 9)
                {
                    string[][] result = Challenge9();

                    foreach (string[] countedWords in result)
                    {
                        string word = countedWords[0];
                        string catchCount = countedWords[1];

                        Console.WriteLine($"Word: {word}, Caught Count: {catchCount}");
                    }
                    Console.WriteLine(" ");
                }
                else if (action == 10)
                {
                    start = 1;
                }

            } while (start == 0);

        }

        public static int Challenge1(string input)
        {
            Console.Write("Please enter 3 numbers: ");
            //Initialize the product variable to 1
            int product = 1;


            // Split the input string by spaces to get an array of numbers
            string[] inputArray = input.Split(" ");

            if (inputArray.Length < 3)
            {
                Console.WriteLine(" You entered in less than 3 numbers");
                product = 0;
                return product;
            }

            // iterating over the first 3 numbers in the input array
            for (int i = 0; i < inputArray.Length; i++)
            {
                // If the loop index is greater than or equal to the length of the input array, exit the loop
                if (i >= inputArray.Length)
                {
                    break;
                }
                // Declare a variable 'number' to store the parsed integer value
                // out keyword refers to a param is passed by reference.
                if (int.TryParse(inputArray[i], out int number))
                {
                    // If parsing is successful, multiply the product by the parsed number
                    product *= number;
                }
                else
                {
                    //if parsing isnt successful, mulitple the product by 1
                    product *= 1;
                }
            }
            Console.WriteLine($"The product of 3 numbers is: {product}");
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
                if (userInput >= 0)
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

            while (length < 1 || length > 10)
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

            for (int i = 0; i < nums.Length; i++)
            {
                int count = 0;
                for (int x = 0; x < nums.Length; x++)
                {
                    if (nums[x] == nums[i])
                    {
                        count++;
                    }
                }
                if (count > mostUsedCount)
                {
                    mostUsedCount = count;
                    mostUsedNum = nums[i];
                }
            }
            Console.WriteLine($"Output: {mostUsedNum}");
            return mostUsedNum;
        }

        public static int Challenge5()
        {
            Console.Write("Enter a number between 1 and 10: ");

            int length = Convert.ToInt32(Console.ReadLine());
            while (length < 1 || length > 10)
            {
                Console.Write("Enter a number between 1 and 10: ");
                length = Convert.ToInt32(Console.ReadLine());
            }
            int[] nums = new int[length];
            int userInput;
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{i + 1} of {nums.Length} - Enter a number here: ");
                userInput = Convert.ToInt32(Console.ReadLine());
                nums[i] = userInput;
            }
            int topDogNum = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (topDogNum < nums[i])
                {
                    topDogNum = nums[i];
                }
            }
            Console.WriteLine($"The peak number was {topDogNum}");
            return topDogNum;
        }

        public static void Challenge6()
        {
            Console.Write("Enter a word here: ");
            string? word = Console.ReadLine();

            try
            {
                using (StreamWriter writer = new StreamWriter("C:/Users/Student-16/Documents/GitHub/Dev/401-Lab03/Lab03/Words.txt/", true))
                {
                    writer.WriteLine(word);
                }
                Console.WriteLine(word);
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred while saving the word: " + ex.Message);
            }
        }

        public static void Challenge7()
        {
            if (File.Exists("C:/Users/Student-16/Documents/GitHub/Dev/401-Lab03/Lab03/Words.txt"))
            {
                string fileContent = File.ReadAllText("C:/Users/Student-16/Documents/GitHub/Dev/401-Lab03/Lab03/Words.txt");
                Console.WriteLine(fileContent);
            }

        }

        public static void Challenge8()
        {
            Console.Write("Remove word: ");
            string? wordRemoved = Console.ReadLine();

            string filePath = "C:/Users/Student-16/Documents/GitHub/Dev/401-Lab03/Lab03/Words.txt";

            string[] lines = File.ReadAllLines(filePath);

            bool wordLocated = false;

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Equals(wordRemoved, StringComparison.OrdinalIgnoreCase))
                {
                    lines[i] = string.Empty;
                    wordLocated = true;
                    break;
                }
            }
            if (wordLocated)
            {
                File.WriteAllLines(filePath, lines);
                Console.WriteLine("Your words have been removed and the file has been updated successfully.");
            }
            else
            {
                Console.WriteLine("Word not located in file.");
            }
        }

        public static string[][] Challenge9()
        {
            Console.Write("Start a sentence: ");
            string? sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');

            string[][] countedWords = new string[words.Length][];
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                int catchCount = word.Length;

                countedWords[i] = new string[] { word, catchCount.ToString() };
            }
            return countedWords;
        }
    }
}
