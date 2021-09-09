using System;

namespace BankClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create a bank with 2 branches and two customers in each branch!");
            //Create the bank
            Bank b = new Bank("YodAlef Class");
            //Create Yod Aleph2 branch
            Branch br2 = new Branch("Yod Aleph 2");
            //Create and add customers
            Customer c1 = new Customer("Ayala", 1000);
            Loan l1 = new Loan(500);
            c1.AddLoan(l1);
            br2.AddCustomer(c1);

            Customer c2 = new Customer("Koren", 1500);
            Loan l2 = new Loan(1500);
            c2.AddLoan(l2);
            br2.AddCustomer(c2);

            b.AddBranch(br2);

            //Create Yod Aleph2 branch
            Branch br4 = new Branch("Yod Aleph 4");
            //Create and add customers
            c1 = new Customer("Ido", 1700);
            l1 = new Loan(800);
            c1.AddLoan(l1);
            br4.AddCustomer(c1);

            c2 = new Customer("Rom", 5500);
            br4.AddCustomer(c2);

            b.AddBranch(br4);

            Console.WriteLine(b);
        }
    }
}
