/* CarpetCalculator.cs
* Author: Christophe Ntidendereza
*/

using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq.Expressions;
using static System.Console;

namespace CarpetCalculatorApp
{
    public class CarpetCalculator
    {
        private double pricePerSqYard;
        private double noOfSqYards;



        // Property of the pricePerSqYard data field
        public double PricePerSqYard
        {
            get
            {
                return pricePerSqYard;
            }
            set
            {
                pricePerSqYard = value;
            }
        }

        // Property for noOfSqYards data field
        public double NoOfSqYards
        {
            get
            {
                return noOfSqYards;
            }
            set
            {
                noOfSqYards = value;
            }
        }

        // Default Constructor
        public CarpetCalculator()
        {
            //empty body
        }

        public CarpetCalculator(double amountNeeded, double price)
        {
            noOfSqYards = amountNeeded;
            pricePerSqYard = price;
        }

        public double DetermineTotalCost()
        {
            return (pricePerSqYard * noOfSqYards);
        }

        // One of the overloaded Mutator methods
        public void SetNoOfSqYards(double length,
                                        double width)
        {
            const int SQ_FT_PER_SQ_YARD = 9;

            noOfSqYards = length * width
                / SQ_FT_PER_SQ_YARD;
        }

        // One of the overloaded Mutator methods
        public void SetNoOfSqYards(double squareYards)
        {
            noOfSqYards = squareYards;
        }

        // Accessor method
        public double GetNoOfSqYards()
        {
            return noOfSqYards;
        }

        public override string ToString()
        {
            return "\nPrice Per Square Yard: " +
                   pricePerSqYard.ToString("C") +
                   "\n\nTotal Square Yards: " +
                   noOfSqYards.ToString("F1") +
                   "\n\nTotal Price: " +
                   DetermineTotalCost().ToString("C");
        }


        static void Main()
        {
            bool runAgain = true;
            string tryAgain;

            const double PRICE_PER_SQYQRD = 17.95;


            while (runAgain) { // To allow application to restart when Press 'Y' or 'y'
                               // and end it when press a key different from 'Y' or 'y'
                CarpetCalculator berber = new CarpetCalculator();

                double roomWidth;
                double roomLength;
              
                DisplayInstructions();

                // Call getDimension( ) to get the length                
                roomLength = GetDimension("Length");
                // Call getDimension( ) again to get the width
                roomWidth = GetDimension("Width");
                berber.PricePerSqYard = PRICE_PER_SQYQRD;
                berber.SetNoOfSqYards(roomLength, roomWidth);

                
                Write(berber);

                //it asks to start over or quit the app
                Write("\n\nPress 'Y' to try again. Or Press any key to end the application: ");
                tryAgain = ReadLine().ToUpper();

                if (tryAgain != "Y")
                {
                    runAgain = false;
                }
                
                Clear();
            }

            ReadKey();
        }

        static void DisplayInstructions()
        {
            WriteLine("This program will "
                + "determine how much "
                + "carpet to purchase.");
            WriteLine();
            WriteLine("You will be asked to enter "
                + "the size of the room ");
            WriteLine("and the price of the carpet, "
                + "in price per square yds.");
            WriteLine();
        }

        static double GetDimension(string side)
        {
            string inputValue;  // local variables
            int feet = 0;           // needed only by this 
            int inches = 0;         // method
            bool inValue = true;
            bool erValue = true;

            while (inValue) //stay running until input is Number
            {
                try //Catch exception if feet are not numbers
                {
                    if (erValue == false)
                    {
                        Write("\nEnter again the {0} in feet: ", side);
                    }
                    else
                    {
                        Write("Enter the {0} in feet: ", side);
                    }

                    inputValue = ReadLine();

                    //Checking if input is Number or not
                    //int i is not used
                    int i = 0;
                    bool result = int.TryParse(inputValue, out i);

                    //changing the state of varible
                    //they are used in While Loop
                    if (result == true)
                    {
                        inValue = false;
                        erValue = true;
                    }
                    else
                    {
                        inValue = true;
                        erValue = false;
                    }

                    feet = int.Parse(inputValue);
                }
                catch (Exception e)
                {
                    feet = 0; //initialize "feet" to 0 until it got the number value
                    erValue = false;
                    WriteLine("\nUse only numbers to input {0} in feet ", side);

                }           
            }

            //same Loop to get inches measurement.
            inValue = true;
            while (inValue)
            {
                try //Catch exception if inches are not numbers
                {
                    if (erValue == false)
                    {
                        Write("\nEnter again the {0} in inches: ", side);
                    }
                    else
                    {
                        Write("Enter the {0} in inches: ", side);
                    }

                    inputValue = ReadLine();

                    int i = 0;
                    bool result = int.TryParse(inputValue, out i);

                    if (result == true)
                    {
                        inValue = false;
                        erValue = true;
                    }
                    else
                    {
                        inValue = true;
                        erValue = false;
                    }

                    inches = int.Parse(inputValue);
                }
                catch (Exception e)
                {
                    inches = 0; //initialize "feet" to 0 until it got the number value
                    erValue = false;
                    WriteLine("\nUse only numbers to input {0} in inches", side);

                }
            }

            // Note: cast required to avoid int division
            return (feet + (double)inches / 12);
        }
    }
}
