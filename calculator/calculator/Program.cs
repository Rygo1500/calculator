using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("------------------------");
            Console.WriteLine("Super calculator program");
            Console.WriteLine("------------------------");

            do
            {
                double result = 0;
                Console.WriteLine("Please enter an option: ");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Substract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");
                Console.WriteLine("\t^ : Power");
                Console.WriteLine("\t√ : Square root");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = Suma(result);
                        Console.WriteLine("The result was " + result);
                        break;

                    case "-":
                        result = Resta(result);
                        Console.WriteLine("The result was " + result);
                        break;

                    case "*":
                        result = Multiply(result);
                        Console.WriteLine("The result was " + result);
                        break;

                    case "/":
                        result = Divide(result);
                        Console.WriteLine("The result was " + result);
                        break;

                    case "^":
                        result = Power(result);
                        Console.WriteLine("The result was " + result);
                        break;

                    case "√":
                        result = Square(result);
                        Console.WriteLine("The result was " + result);
                        break;
                    default:
                        Console.WriteLine("Please enter a valid operation");
                        break;

                }
                Console.Write("Would you like to perform another operation? (Y/N)");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Have a nice day");

            Console.ReadKey();
        }
        static double Suma(double result)
        {
            Console.WriteLine("How many number do you want to add?");

            int numbers;
            double sumandos;

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out numbers)) break;
                Console.WriteLine("Please enter a number");
            }

            for (int i = 0; i < numbers; i++)
            {
                Console.WriteLine("Enter the number you want to add");
                
                while (true)
                {
                    if (double.TryParse(Console.ReadLine(), out sumandos)) break;
                    Console.WriteLine("Please enter a number");
                }
                result += sumandos;
            }
            return result;
        }
        static double Resta(double result)
        {
            Console.WriteLine("How many number do you want to substract?");

            int numbers;
            double restas;

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out numbers)) break;
                Console.WriteLine("Please enter a number");
            }

            for (int i = 0; i < numbers; i++)
            {
                Console.WriteLine("Enter the number you want to substract");

                while (true)
                {
                    if (double.TryParse(Console.ReadLine(), out restas)) break;
                    Console.WriteLine("Please enter a number");
                }
                result -= restas;
            }
            return result;
        }
        static double Multiply(double result)
        {
            Console.WriteLine("How many number do you want to add?");

            int numbers;
            double multi;

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out numbers)) break;
                Console.WriteLine("Please enter a number");
            }

            for (int i = 0; i < numbers; i++)
            {
                Console.WriteLine("Enter the number you want to add");

                while (true)
                {
                    if (double.TryParse(Console.ReadLine(), out multi)) break;
                    Console.WriteLine("Please enter a number");
                }
                result *= multi;
            }
            return result;
        }
        static double Divide(double result)
        {
            Console.WriteLine("At the moment, we can only divide two numbers");
            Console.WriteLine("Please enter the dividend: ");
            double dividend;

            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out dividend)) break;
                Console.WriteLine("Please enter a number");
            }

            Console.WriteLine("Please enter the divisor: ");
            double divisor;

            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out divisor)) break;
                Console.WriteLine("Please enter a number");
            }

            result = dividend / divisor;

            return result;
        }
        static double Power(double result)
        {
            Console.WriteLine("At the moment, we can only power two");
            Console.WriteLine("Please enter the base: ");
            double base1;

            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out base1)) break;
                Console.WriteLine("Please enter a number");
            }

            Console.WriteLine("Please enter the exponent: ");
            double exponent;

            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out exponent)) break;
                Console.WriteLine("Please enter a number");
            }

            result = Math.Pow(base1, exponent);

            return result;
        }
        static double Square(double result)
        {
            Console.WriteLine("Please enter the number: ");
            double base1;

            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out base1)) break;
                Console.WriteLine("Please enter a number");
            }
            result = Math.Sqrt(base1);
            return result;
        }
    }
    
}
