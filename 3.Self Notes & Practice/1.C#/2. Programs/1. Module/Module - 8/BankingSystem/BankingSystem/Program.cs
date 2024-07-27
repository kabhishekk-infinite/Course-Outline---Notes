using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Define a namespace for banking system
namespace BankingSystem
{
    // Define a class for Bank Account
    public class BankAccount
    {
        // Private fields (encapsulation)
        private string accountNumber;
        private string ownerName;
        private double balance;

        // Constructor to initialize the account
        public BankAccount(string accountNumber, string ownerName, double initialBalance)
        {
            this.accountNumber = accountNumber;
            this.ownerName = ownerName;
            this.balance = initialBalance;
        }

        // Method to deposit money into the account
        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited {amount} into account {accountNumber}. New balance: {balance}");
        }

        // Method to withdraw money from the account
        public void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn {amount} from account {accountNumber}. New balance: {balance}");
            }
            else
            {
                Console.WriteLine($"Insufficient funds in account {accountNumber}.");
            }
        }

        // Method to check the current balance
        public double GetBalance()
        {
            return balance;
        }

        // Method to get account number (added for demonstration)
        public string GetAccountNumber()
        {
            return accountNumber;
        }
    }

    // Define another class for Bank Customer
    public class BankCustomer
    {
        // Private fields (encapsulation)
        private string name;
        private BankAccount account;

        // Constructor to initialize the customer with a bank account
        public BankCustomer(string name, string accountNumber, double initialBalance)
        {
            this.name = name;
            this.account = new BankAccount(accountNumber, name, initialBalance);
        }

        // Method to perform a deposit
        public void PerformDeposit(double amount)
        {
            account.Deposit(amount);
        }

        // Method to perform a withdrawal
        public void PerformWithdrawal(double amount)
        {
            account.Withdraw(amount);
        }

        // Method to display account information
        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Customer: {name}");
            Console.WriteLine($"Account Number: {account.GetAccountNumber()}"); // Access account number using GetAccountNumber method
            Console.WriteLine($"Current Balance: {account.GetBalance()}");
        }
    }
}

// Main program entry point
class Program
{
    static void Main()
    {
        // Using the BankAccount class from the BankingSystem namespace
        BankingSystem.BankAccount account1 = new BankingSystem.BankAccount("ACC001", "Alice", 1000);
        account1.Deposit(500);
        account1.Withdraw(200);
        Console.WriteLine($"Final Balance: {account1.GetBalance()}");

        // Using the BankCustomer class from the BankingSystem namespace
        BankingSystem.BankCustomer customer1 = new BankingSystem.BankCustomer("Bob", "ACC002", 1500);
        customer1.PerformDeposit(300);
        customer1.PerformWithdrawal(100);
        customer1.DisplayAccountInfo();
    }
}









//Explain
/* The program simulates a simple banking system using object-oriented principles in C#. 
It includes two main classes within the BankingSystem namespace: BankAccount and BankCustomer. */

// 1. 'Bank Account' Class
/* 
namespace BankingSystem
{
    public class BankAccount
    {
        // Private fields (encapsulation)
        private string accountNumber;
        private string ownerName;
        private double balance;

        // Constructor to initialize the account
        public BankAccount(string accountNumber, string ownerName, double initialBalance)
        {
            this.accountNumber = accountNumber;
            this.ownerName = ownerName;
            this.balance = initialBalance;
        }

        // Method to deposit money into the account
        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited {amount} into account {accountNumber}. New balance: {balance}");
        }

        // Method to withdraw money from the account
        public void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn {amount} from account {accountNumber}. New balance: {balance}");
            }
            else
            {
                Console.WriteLine($"Insufficient funds in account {accountNumber}.");
            }
        }

        // Method to check the current balance
        public double GetBalance()
        {
            return balance;
        }

        // Method to get account number (added for demonstration)
        public string GetAccountNumber()
        {
            return accountNumber;
        }
    }
} 
*/
//Explain
/* Namespace `BankingSystem`**: Organizes related classes (`BankAccount` and `BankCustomer`) into a logical group.
  
- **Class `BankAccount`**:
  -**Fields * *: 
    - `accountNumber`: Stores the unique identifier for the bank account (private field).
    - `ownerName`: Stores the name of the account owner (private field).
    - `balance`: Stores the current balance of the account (private field).
  -**Constructor * *: 
    -Initializes the `BankAccount` object with an `accountNumber`, `ownerName`, and an initial `balance`.
  - **Methods**:
    - `Deposit(double amount)`: Adds `amount` to the `balance` of the account.
    - `Withdraw(double amount)`: Subtracts `amount` from the `balance` if sufficient funds are available.
    - `GetBalance()`: Retrieves the current `balance` of the account.
    - `GetAccountNumber()`: Retrieves the `accountNumber` (added for demonstration, respects encapsulation). */

// 2. 'BankCustomer' Class
/*
namespace BankingSystem
{
    public class BankCustomer
    {
        // Private fields (encapsulation)
        private string name;
        private BankAccount account;

        // Constructor to initialize the customer with a bank account
        public BankCustomer(string name, string accountNumber, double initialBalance)
        {
            this.name = name;
            this.account = new BankAccount(accountNumber, name, initialBalance);
        }

        // Method to perform a deposit
        public void PerformDeposit(double amount)
        {
            account.Deposit(amount);
        }

        // Method to perform a withdrawal
        public void PerformWithdrawal(double amount)
        {
            account.Withdraw(amount);
        }

        // Method to display account information
        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Customer: {name}");
            Console.WriteLine($"Account Number: {account.GetAccountNumber()}"); // Access account number using GetAccountNumber method
            Console.WriteLine($"Current Balance: {account.GetBalance()}");
        }
    }
}
*/
//Explain
/*- **Class `BankCustomer`**:
  - **Fields**:
    - `name`: Stores the name of the bank customer (private field).
    - `account`: Stores an instance of `BankAccount` associated with the customer (private field).
  - **Constructor**: 
    - Initializes the `BankCustomer` object with a `name`, `accountNumber`, and `initialBalance`. It creates a new `BankAccount` instance for the customer.
  - **Methods**:
    - `PerformDeposit(double amount)`: Delegates the deposit operation to the associated `BankAccount` instance.
    - `PerformWithdrawal(double amount)`: Delegates the withdrawal operation to the associated `BankAccount` instance.
    - `DisplayAccountInfo()`: Displays the customer's name, account number (via `GetAccountNumber()` method), and current balance (via `GetBalance()` method).
 */
/*
class Program
{
    static void Main()
    {
        // Using the BankAccount class from the BankingSystem namespace
        BankingSystem.BankAccount account1 = new BankingSystem.BankAccount("ACC001", "Alice", 1000);
        account1.Deposit(500);
        account1.Withdraw(200);
        Console.WriteLine($"Final Balance: {account1.GetBalance()}");

        // Using the BankCustomer class from the BankingSystem namespace
        BankingSystem.BankCustomer customer1 = new BankingSystem.BankCustomer("Bob", "ACC002", 1500);
        customer1.PerformDeposit(300);
        customer1.PerformWithdrawal(100);
        customer1.DisplayAccountInfo();
    }
}
*/
// Explain
/* **Class `Program`**:
  - **Main Method**:
    - Demonstrates the usage of `BankAccount` and `BankCustomer` classes:
      - Creates an instance of `BankAccount` (`account1`) and performs operations like depositing and withdrawing money.
      - Creates an instance of `BankCustomer` (`customer1`) associated with a `BankAccount` and performs operations through `BankCustomer` methods.
      - Displays final balance after operations using `GetBalance()` method and displays customer's account information using `DisplayAccountInfo()` method.
 */

/* Summary

This program exemplifies:
- **Encapsulation**: Fields (`accountNumber`, `ownerName`, `balance`, `name`, `account`) are encapsulated within their respective classes, ensuring data integrity and controlled access.
- **Object instantiation**: Objects (`account1`, `customer1`) are instantiated using constructors (`BankAccount` and `BankCustomer` constructors).
- **Method invocation**: Methods (`Deposit`, `Withdraw`, `PerformDeposit`, `PerformWithdrawal`, `DisplayAccountInfo`) are invoked to perform operations and display information, demonstrating interaction between classes.
  
The program showcases fundamental object-oriented programming concepts such as encapsulation, constructor usage, method invocation, and class interaction within a structured namespace (`BankingSystem`).*/