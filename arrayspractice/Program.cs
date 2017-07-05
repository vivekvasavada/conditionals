using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayspractice
{
    class Program
    {
        static void Main(string[] args)

        {
            //declaring without initializing
           // int[] myFirstArray;
            //declaring and initializing a second array
          //  string[] myStringArray = { "first", "second", "third", "fourth" };
            //declaring and initializing a char array with last name
            //char[] lastName = { 'v', 'a', 's', 'a', 'v', 'a', 'd', 'a' };
            //Console.WriteLine(lastName[0]);
            //Console.WriteLine(lastName[1]);
            //Console.WriteLine(lastName[2]);
            //create following arrays and print using the correct index numbers
            //Array of Top 10 Vacation spots
            //print the ages of 3 children you know
            //Array of gpa's on a 4.0 scale of 8 students
            //Array of classmates' names who are sitting next to you
            //print all four on the same line

            //string[] vacationSpots = { "Cooperstown", "Bahamas", "Nyc", "Jamaica", "France", "North Carolina", "Austin", "Seattle", "Boston","Toronto" };
            //Console.WriteLine(vacationSpots[0]);
            //Console.WriteLine(vacationSpots[9]);
            int[] childrenAges = {5,3,4};
            Console.WriteLine(childrenAges[0]);
            Console.WriteLine(childrenAges[1]);
            Console.WriteLine(childrenAges[2]);
        }
    }
}
