using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClasses
{
    class Loan
    {
        private double amount;

        public Loan(double amount)
        {
            this.amount = amount;
        }

        public Loan(Loan l)
        {
            this.amount = l.amount;
        }


        public double GetAmount ()
        { 
            return this.amount; 
        }

        public void SetAmount(double amount)
        {
            this.amount = amount;
        }

        public override string ToString()
        {
            return $"\n\t\t\tLoan Amount: {this.amount}";
        }
    }

    class Customer
    {
        private double balance;
        private string name;
        private Loan[] loans;
        private const int MAX_LOANS = 100;
        private int numLoans;
        public Customer(string name, double balance)
        {
            this.balance = balance;
            this.name = name;
            this.loans = new Loan[MAX_LOANS];
        }

        public Customer(Customer c)
        {
            this.balance = c.balance;
            this.name = c.name;
            this.loans = new Loan[MAX_LOANS];
            for (int i = 0; i < c.numLoans; i++)
            {
                this.AddLoan(c.loans[i]);
            }
        }

        public double GetBalance()
        {
            return this.balance;
        }

        public void SetBalance(double balance)
        {
            this.balance = balance;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void AddLoan(Loan l)
        {
            if (numLoans < MAX_LOANS)
            {
                this.loans[this.numLoans] = new Loan(l);
                this.numLoans++;
            }
                
        }

        public double GetTotalLoans()
        {
            double sum = 0;
            for (int i = 0; i < this.numLoans; i++)
            {
                sum += this.loans[i].GetAmount();
            }
            return sum;
        }

        public override string ToString()
        {
            string str =  $"\n\t\tCustomer Name: {this.name}, Balance: {this.GetBalance()}, Total Loans: {this.GetTotalLoans()}";
            if (this.numLoans > 0)
            {
                str += $"\n\t\t{this.name}'s Loans:";
                for (int i = 0; i < this.numLoans; i++)
                {
                    str += this.loans[i].ToString();
                }
            }
            return str;
        }
    }
    class Branch
    {
        private string name;
        private Customer[] customers;
        private const int MAX_CUSTOMERS = 100;
        private int numCustomers;
        public Branch(string name)
        {
            this.name = name;
            this.customers = new Customer[MAX_CUSTOMERS];
        }

        public Branch(Branch b)
        {
            this.name = b.name;
            this.customers = new Customer[MAX_CUSTOMERS];
            for (int i = 0; i < b.numCustomers; i++)
            {
                this.AddCustomer(b.customers[i]);
            }
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void AddCustomer(Customer c)
        {
            if (numCustomers < MAX_CUSTOMERS)
            {
                this.customers[this.numCustomers] = new Customer(c);
                this.numCustomers++;
            }
        }

        public double GetTotalLoans()
        {
            double sum = 0;
            for (int i = 0; i < this.numCustomers; i++)
            {
                sum += this.customers[i].GetTotalLoans();
            }
            return sum;
        }

        public double GetTotalMoney()
        {
            double sum = 0;
            for (int i = 0; i < this.numCustomers; i++)
            {
                sum += this.customers[i].GetBalance();
            }
            return sum;
        }

        public override string ToString()
        {
            string str = $"\n\tBranch Name: {this.name}, Total Money: {this.GetTotalMoney()}, Total Loans: {this.GetTotalLoans()}";
            if (this.numCustomers > 0)
            {
                str += $"\n\t{this.name}'s Customers:";
                for (int i = 0; i < this.numCustomers; i++)
                {
                    str += this.customers[i].ToString();
                }
            }
            return str;
        }
    }
    class Bank
    {
        private string name;
        private Branch[] branchs;
        private const int MAX_BRANCHS = 100;
        private int numBranchs;
        public Bank(string name)
        {
            this.name = name;
            this.branchs = new Branch[MAX_BRANCHS];
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void AddBranch(Branch b)
        {
            if (numBranchs < MAX_BRANCHS)
            {
                this.branchs[this.numBranchs] = new Branch(b);
                this.numBranchs++;
            }
        }

        public double GetTotalLoans()
        {
            double sum = 0;
            for (int i = 0; i < this.numBranchs; i++)
            {
                sum += this.branchs[i].GetTotalLoans();
            }
            return sum;
        }

        public double GetTotalMoney()
        {
            double sum = 0;
            for (int i = 0; i < this.numBranchs; i++)
            {
                sum += this.branchs[i].GetTotalMoney();
            }
            return sum;
        }

        public override string ToString()
        {
            string str = $"\nBank Name: {this.name}, Total Money: {this.GetTotalMoney()}, Total Loans: {this.GetTotalLoans()}\n";
            if (this.numBranchs > 0)
            {
                str += $"{this.name}'s Branches:";
                for (int i = 0; i < this.numBranchs; i++)
                {
                    str += this.branchs[i].ToString();
                }
            }
            return str;
        }
    }
}
