using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());

            if (age <= 2)
            {
                Console.WriteLine("Still in Mama's Arms");
            }
            else if (age <= 4)

            {
                Console.WriteLine("Pre School maniac");
            }


            else if (age <= 11)

            {
                Console.WriteLine("Elementary School");
            }

            else if (age <= 14)

            {
                Console.WriteLine("Middle School");
            }


            else if (age <= 18)

            {
                Console.WriteLine("High School");

            }


            else if (age <= 22)

            {
                Console.WriteLine("College");

            }



            else if (age <= 65)

            {
                Console.WriteLine("working for the man");

            }



            else if (age <= 100)

            {
                Console.WriteLine("Golden Years");

            }


            if ((age < 0) || (age > 100))


            {

                Console.WriteLine("this program is for humans");

            }
            //total bill
            //  discount or not
            Console.WriteLine("How many in your party");
            int numberpeople = int.Parse(Console.ReadLine());
            Console.WriteLine("what is the total bill");
            double totalBill = double.Parse(Console.ReadLine());
            double discountTen = (totalBill - (totalBill - .10d));
            double discountFive = (totalBill - (totalBill - .05d));
            double billSplit;

            if (totalBill >= 50)
            {
                Console.WriteLine("you get 10% discount");
            }

            else if (totalBill < 50)
            {
                Console.WriteLine("you get 5% discount");

                Console.WriteLine("your total with discount");

                billSplit = discountTen/(numberpeople +  discountTen); 
































            }




        }


    }

    }






        
    

