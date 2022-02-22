using System;

namespace BankEncapsulationExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount();

            Console.Write("What is the amount you would like to deposit?:");
            double amountToDeposit = double.Parse(Console.ReadLine());

            account1.Deposit(amountToDeposit);
            double userBalance = account1.GetBalance();

            Console.WriteLine($"Your balance is ${userBalance}:");

            //Console.Write("Would you like to know your balance?: ");
            //if(Console.ReadLine() == "Yes" || "yes")
            //{
            //    Console.WriteLine($"Your balance is {userBalance}:");
            //}
            
        }
    }
}
