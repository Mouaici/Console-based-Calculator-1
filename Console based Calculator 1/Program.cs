using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_based_Calculator_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
          do
          {
               
                
               
            

            int number1 = 0;
            int number2 = 0;
            
            Console.WriteLine("Choose your first number");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose your second number");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            

            Console.WriteLine("Choose your method of calculation");
            Console.WriteLine("\n");
            Console.WriteLine("\ta - " + number1 + " + " + number2);
            Console.WriteLine("\n");
            Console.WriteLine("\ts - " + number1 + " - " + number2);
            Console.WriteLine("\n");
            Console.WriteLine("\tm - " + number1 + " * " + number2);
            Console.WriteLine("\n");
            Console.WriteLine("\td - " + number1 + " / " + number2);
            Console.WriteLine("\n");

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine("Your Result: " + Add (number1 , number2));
                    break;
                case "s":
                    Console.WriteLine("Result: " + Subtract(number1 , number2));
                    break;
                case "m":
                    Console.WriteLine("Result: " + Multiply(number1 , number2));
                    break;
                case "d":
                    if (number2 != 0)
                    {
                        Console.WriteLine("Result: " + Divide(number1 , number2));
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation selected.");
                    break;
                

            }  
                Console.WriteLine("Would you like to continue? (Y = yes, N = No): ");

          } while (Console.ReadLine() .ToUpper() == "Y");
            Console.WriteLine(
                "Thank you for using the calculator. Goodbye!");
            Console.ReadKey();


        }


        static int Add(int number1 , int number2)
        {
        
            return number1 + number2;
        }
        static int Subtract(int number1, int number2)
        {
           
            return number1 - number2;
        }
        static int Multiply(int number1, int number2)
        {
            
            return number1 * number2;
        }
        static int Divide(int number1, int number2)
        {
            if (number2 != 0)
            {
                
                return number1 / number2;
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return 0; // or throw an exception
            }

























        }
}
}



