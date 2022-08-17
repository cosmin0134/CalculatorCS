using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Va rog sa selectati operatia:");
                Console.WriteLine("1. Adunare");
                Console.WriteLine("2. Scadere");
                Console.WriteLine("3. Inmultire");
                Console.WriteLine("4. Impartire");
                Console.WriteLine("5. Iesire aplicatie");
                string input = Console.ReadLine();

                int operation, firstNumber, secondNumber;

                int.TryParse(input, out operation);

                if (operation == 5)
                {
                    return;
                }

                Console.WriteLine("Va rog sa introduceti primul numar:");
                int.TryParse(Console.ReadLine(), out firstNumber);

                Console.WriteLine("Va rog sa introduceti al doilea numar:");
                int.TryParse(Console.ReadLine(), out secondNumber);

                double result = 0;

                switch (operation)
                {
                    case 1:
                        result = Calculator.Sum(firstNumber, secondNumber);
                        break;
                    case 2:
                        result = Calculator.Difference(firstNumber, secondNumber);
                        break;
                    case 3:
                        result = Calculator.Multiply(firstNumber, secondNumber);
                        break;
                    case 4:
                        result = Calculator.Divide(firstNumber, secondNumber);
                        break;
                }
                Console.WriteLine("Rezultatul este:" + result);
            }
            
        }
    }
 }
