using System;

namespace ConsoleApplication.Programming
{
    class CountNumbers
    {
        public void ArmstrongNumbers()
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            int count = number.ToString().Length;
            int duplicateNumber = number;

            double sum = 0;
            while (number > 0)
            {
                sum += Math.Pow(number % 10, count);

                number /= 10;
            }
            Console.WriteLine(sum);
            if (duplicateNumber == sum)
            {
                Console.WriteLine("its armstrong number " + duplicateNumber);
            }
            else
            {
                Console.WriteLine("Its not armstrong numner " + duplicateNumber);
            }
        }

        public void SumOfNumbers()
        {
            Console.Write("Enter number: ");
            long number = long.Parse(Console.ReadLine());
            long duplicateValue = number;
            long sum = 0;

            while (number > 9)
            {
                sum = 0;
                while (number > 0)
                {
                    long value = number % 10;
                    sum += value;
                    number /= 10;
                }
                number = sum;
            }
            Console.WriteLine(sum);
        }
    }
}
