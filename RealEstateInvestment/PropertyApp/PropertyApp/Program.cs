
using System;
using static System.Console;

namespace PropertyApp
{
    internal class Program
    {
        const double RENTAL_AMOUNT = 1000.00;
        private static RealEstateInvestment realEstateInvestment;
        static void Main(string[] args)
        {
            int yearBuilt = 2004;
            double purchasePrice = 150000.00;
            string streetAddress = "65th Street";


            realEstateInvestment = new RealEstateInvestment(yearBuilt, purchasePrice, streetAddress);
            realEstateInvestment.MonthlyExpense = GetExpenses();
            realEstateInvestment.IncomeFromRent = RENTAL_AMOUNT;

            Console.WriteLine("Poperty address {0} ", realEstateInvestment.StreetAddress);
            Console.WriteLine("Earning per Month {0:F2} ", realEstateInvestment.DetermineMonthlyEarnings());
        }
           public static string InputYearBuilt()
           {
               string sNumber;
               Write("Enter the Year Built: ");
               sNumber = ReadLine();
               return sNumber;
           }

        public static double GetExpenses()
        {
            double insurance, taxes, utilities;

            Write("Enter Purchase Insurance: ");
            insurance = double.Parse(ReadLine());

            Write("Enter Purchase Taxes: ");
            taxes = double.Parse(ReadLine());

            Write("Enter Purchase Utilities: ");
            utilities = double.Parse(ReadLine());

            return ( insurance/12) + (taxes/12) + utilities;

        }
    }
}
