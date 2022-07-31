using System;

namespace Hakan.ConsoleApp.Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

            Console.Write("Please enter your name: ");
            string Name = Console.ReadLine();

            Console.Write("Please enter your lastname: ");
            string LastName = Console.ReadLine();

            Console.Write("Please enter your occupation: ");
            string Occupation = Console.ReadLine();

            Console.Write("Please enter your age: ");
            byte age = Convert.ToByte(Console.ReadLine());

            Console.Write("Please enter your salary in USD: ");
            string oldSalary = Console.ReadLine();
            string newSalary = oldSalary.Replace(',', '.');
            double Salary = Convert.ToDouble(newSalary);

            Console.Write("Please enter your weight in kgs: ");
            string oldweight = Console.ReadLine();
            string newweight = oldweight.Replace(',', '.');
            double weight = Convert.ToDouble(newweight);

            Console.Write("Please enter your length in centimeters: ");
            byte length = Convert.ToByte(Console.ReadLine());

            double ratio = length / weight;
            //double normalratio = 2;

            Console.WriteLine($"Welcome {Name} {LastName}!");
            Console.WriteLine($"You work as a {Occupation} with a salary of USD {Salary} at the age of {age}.");
            Console.WriteLine($"Your Length/Weight ratio is {ratio}.");
            
            Console.WriteLine(length < weight);
            double lengthfeet = length / 30.48;

            Console.WriteLine($"Your length is equivalent to {lengthfeet} in feet.");
            lengthfeet += 5;
            Console.WriteLine($"If you were to stay on a platform of 5 feet, you would be {lengthfeet} tall. ");
                    
            Console.ReadLine();

            }
            catch (OverflowException)
            {
                Console.WriteLine("Please enter a value between 10-100.");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Unexpected error has occured.");
                Console.ReadLine();
            }


        }
    }
}
