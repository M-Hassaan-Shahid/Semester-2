using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1pd3.BL;

namespace task2pd3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double newNum1;
            double newNum2;
            Calculater calculater = new Calculater(); ;

            int choice;
            do
            {
                Console.WriteLine("\nMenu Options:");
                Console.WriteLine("1. Create a Single Object of Calculator");
                Console.WriteLine("2. Change Values of Attributes");
                Console.WriteLine("3. Add");
                Console.WriteLine("4. Subtract");
                Console.WriteLine("5. Multiply");
                Console.WriteLine("6. Divide");
                Console.WriteLine("7. Modulo");
                Console.WriteLine("8. Exit");

                Console.Write("Enter your choice (1-8): ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // Create a single object of Calculator
                        Console.WriteLine("Calculator object created.");
                        break;

                    case 2:

                        Console.Clear();
                        // Change values of attributes
                        if (calculater != null)
                        {
                            Console.Write("Enter new value for Number1: ");
                            newNum1 = double.Parse(Console.ReadLine());
                            Console.Write("Enter new value for Number2: ");
                            newNum2 = double.Parse(Console.ReadLine());
                            calculater.setValue(newNum1, newNum2);
                            Console.WriteLine("Values updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Error: Calculator object not created. ");
                        }
                        break;

                    case 3:

                        Console.Clear();
                        // Add
                        if (calculater != null)
                        {
                            Console.WriteLine($"Result of addition: {calculater.Add()}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Calculator object not created. ");
                        }
                        break;

                    case 4:

                        Console.Clear();
                        // Subtract
                        if (calculater != null)
                        {
                            Console.WriteLine($"Result of subtraction: {calculater.Sub()}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Calculator object not created. ");
                        }
                        break;

                    case 5:

                        Console.Clear();
                        // Multiply
                        if (calculater != null)
                        {
                            Console.WriteLine($"Result of multiplication: {calculater.Mul()}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Calculator object not created. ");
                        }
                        break;

                    case 6:
                        Console.Clear();
                        // Divide
                        if (calculater != null)
                        {
                            Console.WriteLine($"Result of division: {calculater.Div()}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Calculator object not created. ");
                        }
                        break;

                    case 7:
                        Console.Clear();
                        // Modulo
                        if (calculater != null)
                        {
                            Console.WriteLine($"Result of modulo operation: {calculater.Mod()}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Calculator object not created. ");
                        }
                        break;

                  
                    case 8:

                        // Exit
                        Environment.Exit(0);
                        break;


                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 8.");
                        break;
                }

            } while (choice != 8);
            Console.ReadKey();
        }
    }
}