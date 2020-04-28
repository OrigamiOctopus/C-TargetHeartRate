using System;

namespace HealthApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string first;
            string last;
            int birth;
            int curYear;
           

            Console.WriteLine("Please enter first name.");
            first = Console.ReadLine();
            Console.WriteLine("Please enter last name.");
            last = Console.ReadLine();
            Console.WriteLine("Please enter birth year (ie 1986).");
            birth = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the current year (ie 2019).");
            curYear = Int32.Parse(Console.ReadLine());

            HeartRates firstPerson = new HeartRates(first, last, birth, curYear);

            Console.WriteLine($"\n{firstPerson.FirstName} {firstPerson.LastName} is {firstPerson.FindAge()}," +
                $" has a maximum heart rate of {firstPerson.MaxHeartRate()}," +
                $" a minimum target heart rate of {firstPerson.MinTargetHeartRate()}," +
                $" and a maximum target heart rate of {firstPerson.MaxTargetHeartRate()}.");
            


        }
    }
}
