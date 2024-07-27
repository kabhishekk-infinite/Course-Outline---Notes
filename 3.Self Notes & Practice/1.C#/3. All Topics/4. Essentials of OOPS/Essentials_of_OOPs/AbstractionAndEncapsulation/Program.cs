using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Abstraction :  focuses on hiding the complexity of the system by exposing only the necessary parts of an object.
//Encapsulation : focuses on hiding the internal state and requiring all interaction to be performed through an object's methods.
//It is achieved using access modifiers (like private, public, protected).

/* Q. Example that demonstrates both abstraction and encapsulation using a BankAccount class. Properties : Account Number, Balance. 
      In method : get balance, deposit, withdraw. */

namespace AbstractionAndEncapsulation
{
    public class BankAccount
    {
        //Fields.  (Encapsulation)
        private string accntnumber;
        private double balance;

        //Constructor.  (Abstraction)
        public BankAccount(string accntnumber, double balance)
        {
            this.accntnumber = accntnumber;
            this.balance = balance;
        }

        //Now Get the Accnt no. (Encapsulation)
        public string AccntNumber
        {
            get { return accntnumber; }
        }

        //Method - Balance  (Abstraction)
        public double GetBalance()
        {
            return balance;
        }


        //Method - Deposit  (Abstraction)
        public void Deposit(double amount)
        {
            if(amount>0)
            {
                balance += amount;
                Console.WriteLine($"Sucessfully Deposited amount : {amount}. \nNew Bank Balance : {balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }


        //Method - Withdraw  (Abstraction)
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount<=balance)
            {
                balance -= amount;
                Console.WriteLine($"Sucessfully Withdraw amount : {amount}. \nNew Bank Balance : {balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount.");
            }
        }
    }


    class Program
    {
        public static void Main(string[] args)
        {
            //Instantiating the bank accnt
            BankAccount account = new BankAccount("1234567890", 10000.00);

            Console.WriteLine($" Bank Account Number : {account.AccntNumber}");         // Working with the object - Account Number.
            Console.WriteLine($" Initial Bank Balance : {account.GetBalance():C}");     // Working with the object - Balance.

            //Withdraw
            account.Withdraw(2000);

            //Deposit
            account.Deposit(5000);

            Console.ReadKey();
        }
    }
}
