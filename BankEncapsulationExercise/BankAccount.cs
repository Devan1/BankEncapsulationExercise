using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulationExercise
{
    public class BankAccount
    {
        private double _balance = 0;
        public double Deposit(double amount)
        {
            return _balance += amount;
        }
        public double GetBalance()
        {
            return _balance;
        }
    }
}
