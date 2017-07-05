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
            //    int[] childrenAges = {5,3,4};
            //    Console.WriteLine(childrenAges[0]);
            //    Console.WriteLine(childrenAges[1]);
            //    Console.WriteLine(childrenAges[2]);


            //datatype[] nameOfArray=new data type[#ofElements];
            //int[] numberOftSeats = new int[21];
            //string[] studentsInClass =new string [21];
            ////nameOfArray[index]= Elememt;
            //studentsInClass[0] = "Jordan";
            //Console.WriteLine("Please enter the name of the next student");
            //studentsInClass[1] = Console.ReadLine();
            //Console.WriteLine("The student in the second seat is {0}", studentsInClass [1]);
            //int[] ageofStudentInClass = new int[21];
            //ageofStudentInClass[0] = int.Parse(Console.ReadLine());
            //Console.WriteLine("the age of the first student in the first seat is " + ageofStudentInClass[0]);
            //string firstIndex = ageofStudentInClass[0].ToString();


            //  string[] restaurantsInMall = { "Subway", "Saki", "Dunkin Donuts", "Red Lobster", "Chick Fil-A" };

            //  Console.WriteLine(restaurantsInMall.Length);
            //declare and init an array when I don't know elements but I know how many
            //string[] variableName = new string[42];

            //char[] lettersInMiddleName = { 'a', 's', 'h' };
            //Console.WriteLine(lettersInMiddleName.Length);

            //Declare and initialize a string array
            //using length property, print second to last eleement

            //string[] ballTeams= { "Cavs", "Spurs", "Nuggets" };
            //int numBall = ballTeams.Length;
            //Console.WriteLine(ballTeams[ballTeams.Length - 2]); 


            //IndexOf is amethod to search an array of the for a specified value and returns

            //the index position first matching value found

          //  int[] bestYearsEver = { 1985, 1999, 1998, 1991 };
         //   Console.WriteLine(Array.IndexOf(bestYearsEver, 1985));

            //reverse method

            int[] palindromeNumbers = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine(palindromeNumbers[0]);
            Array.Reverse(palindromeNumbers);
            Console.WriteLine(palindromeNumbers[0]);
            











        }
    }
        }