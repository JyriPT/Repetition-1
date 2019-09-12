using System;

namespace Repetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int selection;

            Console.WriteLine("Select the assignment you wish to check:");
            Console.WriteLine("1 checks assignment 1");
            Console.WriteLine("2 checks assignments 2 and 4");
            Console.WriteLine("3 checks assignments 3 and 5");
            Console.WriteLine("Input selection:");
            selection = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (selection == 1)
            {
                Console.WriteLine("Input number for multiplication:");
                number = int.Parse(Console.ReadLine());

                Multiply(number);

            } else if (selection == 2)
            {
                Console.WriteLine("Input number for addition:");
                number = int.Parse(Console.ReadLine());

                Addition(number);

            } else if (selection == 3)
            {
                Console.WriteLine("This section is being worked on, sorry...");

            } else
            {
                Console.WriteLine("Invalid selection, please reboot.");
            }
            
        }

        static void Multiply(int given)
        {
            int number = given;
            int calc = 1;

            if (number == 0)
            {
                Console.WriteLine("Your answer is 1.");
            } else if (number < 0)
            {
                Console.WriteLine("Your answer is undefined");
            } else
            {
                do
                {
                    calc *= number;
                    number -= 1;

                } while (number > 0);

                Console.WriteLine("Your answer is " + calc + ".");
            }
        }

        static void Addition(int given)
        {
            int number = given;
            int calc = 0;

            if (number > 0)
            {
                do
                {
                    calc += number;
                    number -= 1;

                } while (number > 0);

            } else if (number < 0)
            {
                number *= -1;

                do
                {
                    calc += number;
                    number -= 1;

                } while (number > 0);

                calc *= -1;
            }

            Console.WriteLine("Your answer is " + calc + ".");
        }
    }
}
