/*LoanApp.cs
/** Used for testing Loan class.
* Prompts user for loan amount,
* interest rate, and time period
* for loan. Calls method to display
* payment amount and amortization
* schedule. Allows more than
* one loan calculation.
* */
using System;
using static System.Console;

namespace LoanApp
{
    class LoanApp
    {
        static void Main()
        {
            int years;
            double loanAmount;
            double interestRate;
            string inValue;
            char anotherLoan = 'N';

            do
            {
                GetInputValues(out loanAmount, out interestRate,
                               out years);

                Loan ln = new Loan(loanAmount, interestRate, years);
                WriteLine();

                Clear();
                WriteLine(ln);
                WriteLine();

                WriteLine(ln.ReturnAmortizationSchedule());
                ln.DetermineTotalInterestPaid();
                WriteLine("Payment Amount: {0:C}", ln.PaymentAmount);
                WriteLine("Interest Paid over Life of Loan: {0:C}",
                                  ln.TotalInterestPaid);
                Write("Do another Calculation? (Y or N)");
                inValue = ReadLine();
                anotherLoan = Convert.ToChar(inValue);
            }
            while ((anotherLoan == 'Y') || (anotherLoan == 'y'));
        }

        // Prompts user for loan data
        static void GetInputValues(out double loanAmount,
                                   out double interestRate,
                                   out int years)
        {
            Clear();
            loanAmount = GetLoanAmount();
            interestRate = GetInterestRate();
            years = GetYears();
        }

        static double GetLoanAmount()
        {
            string sValue;
            double loanAmount;

            Write("Enter the loan amount: ");
            sValue = ReadLine();
            while ((double.TryParse(sValue, out loanAmount) == false)
                        || loanAmount < 1 || loanAmount > 500000)
            {
                WriteLine("Invalid data entered " +
                    "for loan amount");
                Write("\nPlease re-enter the loan amount (less than 500,000): ");
                sValue = ReadLine();
            }
            return loanAmount;
        }

        static double GetInterestRate()
        {
            string sValue;
            double interestRate;

            Write("Enter interest rate (as a decimal value " +
                    "- i.e. .06): ");
            sValue = ReadLine();
            while ((double.TryParse(sValue, out interestRate) == false)
                        || interestRate < 0 || interestRate > 1)
            {
                Write("\nInvalid data entered " +
                    "for interest rate (decimal value - i.e. 0.06):");
                Write("\nPlease re-enter the interest rate: ");
                sValue = ReadLine();
            }
            return interestRate;
        }

        static int GetYears()
        {
            string sValue;
            int years;

            Write("Enter the number of years for the loan: ");
            sValue = ReadLine();
            while ((int.TryParse(sValue, out years) == false)
                        || years < 1 || years > 30)
            {
                Write("\nInvalid data entered " +
                    "for years");
                Write("\nPlease re-enter the years (1-30): ");
                sValue = ReadLine();
            }
            return years;
        }

    }
}
