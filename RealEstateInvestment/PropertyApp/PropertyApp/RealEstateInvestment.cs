using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PropertyApp
{
    class RealEstateInvestment
    {
        private int yearBuilt;
        private double purchasePrice;
        private string streetAddress;
        private double monthlyExpense;
        private double incomeFromRent;

        public RealEstateInvestment()
        {

        }
        public RealEstateInvestment(int yBuilt, double pPrice, string sAddress)
        {
            yearBuilt = yBuilt;
            purchasePrice = pPrice;
            streetAddress = sAddress;
        }

        public int YearBuilt
        {
            get
            {
                return yearBuilt;
            }

            set
            {
                yearBuilt = value;
            }
        }

        public double PurchasePrice
        {
            get
            {
                return purchasePrice;
            }

            set
            {
                purchasePrice = value;
            }
        }

        public String StreetAddress
        {
            get
            {
                return streetAddress;
            }

            set
            {
                streetAddress = value;
            }
        }

        public double MonthlyExpense
        {
            get
            {
                return monthlyExpense;
            }

            set
            {
                monthlyExpense = value;
            }
        }

        public double IncomeFromRent
        {
            get
            {
                return incomeFromRent;
            }

            set
            {
                incomeFromRent = value;
            }
        }

        public double DetermineMonthlyEarnings()
        {
            return ( incomeFromRent - monthlyExpense );
        }
    }    
}
