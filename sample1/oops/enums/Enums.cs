using System;

namespace sample1.oops.enums
{
    class EnumsClass
    {
        // Enum to define days of the week.
        enum Weeks
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        // Enum to define customer types.
        public enum CustomerType
        {
            User,
            Admin,
            Blogs,
            Customers
        }

        // Method to display a specific day from the Weeks enum.
        public void DisplayWeek()
        {
            // Creating an object of the Weeks enum and setting it to Saturday.
            Weeks weeksObject = Weeks.Saturday;

            // Displaying the selected day.
            Console.WriteLine($"Selected Day: {weeksObject}");
        }

        // Method to display messages based on CustometType enum values.
        public void GetEnumsValues(CustomerType type)
        {
            // Switch statement to handle enum values.
            switch (type)
            {
                case CustomerType.User:
                    Console.WriteLine("I am user");
                    break;
                case CustomerType.Admin:
                    Console.WriteLine("I am admin");
                    break;
                case CustomerType.Blogs:
                    Console.WriteLine("I am blogs");
                    break;
                case CustomerType.Customers:
                    Console.WriteLine("I am customer");
                    break;
                default:
                    Console.WriteLine("Invalid type");
                    break;
            }
        }
    }
}
