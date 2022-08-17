﻿using System;

namespace ConsoleApp3
{
    static class Calculator
    {
        public static int Sum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static double Divide(int firstNumber, int secondNumber)
        {
            try
            {
                // Incearca
                return (double) firstNumber / secondNumber;
            }
            catch (DivideByZeroException)
            {
                // Daca se arunca DivideByZeroException fa asta
                Console.WriteLine("Diviziunea nu a fost posibila, secondNumber a fost 0.");
                return 0;
            }
        }

        public static int Multiply(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public static int Difference (int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }
    }
}
