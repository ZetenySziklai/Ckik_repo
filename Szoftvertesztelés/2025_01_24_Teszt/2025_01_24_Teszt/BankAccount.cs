using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_01_24_Teszt
{
    internal class BankAccount
    {
        public int Balance { get; set; }
        public BankAccount(int balance)
        {
            Balance = balance;
        }
        public void Deposit(int value)
        {
            Balance += value;
        }
        public void Withdraw(int value)
        {
            Balance -= value;
        }
        public double Interest(int v)
        {
            return (double) Balance * ((double)v/100);
        }
        public double Increase(double v)
        {
            return (double)Balance * (1 + (v / 100));
        }
        public double Decrease(int v) 
        {

            return (double)Balance - Interest(v); 
        }
    }
}
