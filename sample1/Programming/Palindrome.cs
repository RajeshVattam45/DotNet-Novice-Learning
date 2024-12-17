using System;

namespace ConsoleApplication.Programming
{
    class RecursiveOperations
    {
        // Method to check if the input text is a palindrome.
        public void CheckPalindrome()
        {
            Console.Write("Enter text here: ");
            string inputText = Console.ReadLine().Replace(" ", "").ToLower();

            bool isPalindrome = IsPalindromeRecursive(inputText, 0, inputText.Length - 1);
            Console.WriteLine(isPalindrome
                ? $"The text '{inputText}' is a palindrome."
                : $"The text '{inputText}' is not a palindrome.");
        }

        // Recursive function to check for palindrome.
        private bool IsPalindromeRecursive(string text, int left, int right)
        {
            if (left >= right)
            {
                return true;
            }

            // If characters at left and right don't match, not a palindrome.
            if (text[left] != text[right])
            {
                return false;
            }

            // Check the next set of characters.
            return IsPalindromeRecursive(text, left + 1, right - 1);
        }

        // Method to calculate the factorial of a number.
        public void CalculateFactorial()
        {
            Console.Write("Enter a number here: ");
            int number = int.Parse(Console.ReadLine());

            int result = Factorial(number);
            Console.WriteLine($"Factorial of {number} is: {result}");
        }

        // Recursive function to calculate factorial.
        private int Factorial(int number)
        {
            if (number <= 1)
            {
                return 1;
            }

            return number * Factorial(number - 1);
        }

        // Method to extract the 3rd digit from a given number.
        public void ExtractDigit()
        {
            int number = 98783737;
            string numberString = number.ToString();
            Console.WriteLine("The 3rd digit is: " + numberString[2]);
        }

        // Method to calculate the sum of numbers from 1 to a given number.
        public void CalculateSumOfNumbers()
        {
            Console.Write("Enter a number here: ");
            int number = int.Parse(Console.ReadLine());

            int result = SumUpToNumber(number);
            Console.WriteLine($"The sum of numbers up to {number} is: {result}");
        }

        // Recursive function to calculate sum of numbers from 1 to n.
        private int SumUpToNumber(int number)
        {
            if (number == 0)
            {
                return 0;
            }

            return number + SumUpToNumber(number - 1);
        }
    }

}
