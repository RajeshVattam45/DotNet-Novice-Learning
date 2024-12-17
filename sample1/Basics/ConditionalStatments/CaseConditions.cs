using System;

namespace ConsoleApplication.Basics.ConditionalStatments
{
    public class ConditionalExamples
    {
        public void DemonstrateSwitchCase()
        {
            int variable = 100;
            switch (variable)
            {
                case 1:
                    Console.WriteLine(variable);
                    break;
                case 2:
                    Console.WriteLine(variable);
                    break;
                case 100:
                    Console.WriteLine(variable);
                    break;
                default:
                    Console.WriteLine("No matching case for the variable.");
                    break;
            }
        }
    }
}
