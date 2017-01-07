using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type Your First Name:");
            String userFirstName = Console.ReadLine();
            Console.WriteLine("Type Your Last Name:");
            String userLastName = Console.ReadLine();
            Console.WriteLine("Type Your Age:");
            String userAge = Console.ReadLine();
            Console.WriteLine("Type Your Gender:");
            String userGender = Console.ReadLine();
            DateTime dt6PM = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 18, 0, 0);
            DateTime dt8AM = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0);
            if (DateTime.Now > dt6PM && DateTime.Now < dt8AM && userGender == "Male")
            {
                Console.WriteLine("Good Evening, Mr." + userLastName + "Age" + userAge);
            }
            if (DateTime.Now < dt6PM && DateTime.Now > dt8AM && userGender == "Male")
            {
                Console.WriteLine("Good Day, Mr." + userLastName + "Age" + userAge);
            }
            if (DateTime.Now > dt6PM && DateTime.Now < dt8AM && userGender == "Female")
            {
                Console.WriteLine("Good Evening, Mrs." + userLastName + "Age" + userAge);
            }
            if (DateTime.Now < dt6PM && DateTime.Now > dt8AM && userGender == "Female")
            {
                Console.WriteLine("Good Day, Mrs." + userLastName + "Age" + userAge);
            }
            else
            {
                Console.WriteLine("Please Type Male or Female in Gender");
            }

        }
    }
}