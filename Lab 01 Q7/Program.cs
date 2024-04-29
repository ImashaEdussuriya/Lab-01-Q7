using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_Q7
{
    class Program
    {
        static double balance = 0;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("ATM Simulator");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Exit");

                Console.WriteLine("Enter your choice:");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CheckBalance();
                        break;
                    case 2:
                        DepositMoney();
                        break;
                    case 3:
                        WithdrawMoney();
                        break;
                    case 4:
                        Console.WriteLine("Thank you for using the ATM. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void CheckBalance()
        {
            Console.WriteLine($"Your balance: ${balance}");
        }

        static void DepositMoney()
        {
            Console.WriteLine("Enter the amount to deposit:");
            double amount = Convert.ToDouble(Console.ReadLine());
            balance += amount;
            Console.WriteLine($"${amount} deposited successfully. New balance: ${balance}");
        }

        static void WithdrawMoney()
        {
            Console.WriteLine("Enter the amount to withdraw:");
            double amount = Convert.ToDouble(Console.ReadLine());
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"${amount} withdrawn successfully. New balance: ${balance}");
            }
            else
            {
                Console.WriteLine("Insufficient balance. Withdrawal failed.");
            }
        }
    }
}
