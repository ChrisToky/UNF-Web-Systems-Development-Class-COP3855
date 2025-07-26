/* NFactorial.cs
 * Author: Chris
 * n factorial calculation
*/

using System;
using System.Runtime;
using static System.Console;

namespace NFactorial
{
    class NFactorial
    {
        static void Main(string[] args)
        {
            double result;
            int number;
            string moreNumber;

            DisplayInformation();

            do 
            { 
                number = InputNumber();
                CalculateNFactorial(number, out result);
                DisplayNFactorial(number, result);
                moreNumber = PromptMoreCalculationeNFactorial();
            }while (moreNumber == "y" || moreNumber == "Y");
            //ReadKey();



            //factorial = nNumber;

            //for (int i = 1; i < nNumber; i++)
            //{
            //    factorial = factorial * (nNumber - i) ;
            //    WriteLine($"{i} * {nNumber} * {nNumber - i} * {factorial}");
            //}

        }

        public static void DisplayInformation()
        {
            WriteLine(" n! represents the multiplication of all numbers between 1 and n.");
        }
        public static int InputNumber()
        {
            string inputValue;
            int nNumber;

            WriteLine("\nEnter the number to calculate n!: ");
            inputValue = ReadLine();

            if (int.TryParse(inputValue, out nNumber) == false)
            {
                WriteLine("Invalide entry - 0 used for n!");
            }

            return nNumber;
        }

        public static void CalculateNFactorial(int n, out double result)
        {
            result = 1;
            for (int i = n; i > 0; i--)
            {
                result = result * i;
            }
        }

        public static void DisplayNFactorial(int n, double result)
        {
            WriteLine($"\n{n}! is {result}");
        }
        
        public static string PromptMoreCalculationeNFactorial()
        {
            string moreNumber;
            WriteLine("\nDo you want to calculate again? ");
            WriteLine("\nEnter 'Y' or 'y' to calculate other n! or press any key to exit");
            moreNumber = ReadLine();
            return moreNumber;
        }
    }
}
