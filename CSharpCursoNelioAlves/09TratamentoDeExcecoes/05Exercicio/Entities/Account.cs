using CSharp._09TratamentoDeExcecoes._05Exercicio.Entities.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._09TratamentoDeExcecoes._05Exercicio.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withdrawLimit) { 
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        { 
            Balance = Balance + amount;
        }

        public void Withdraw(double amount) {
            if (amount > Balance) {
                throw new DomainException("Insufficient funds");
            }
            if (amount > WithdrawLimit) {
                throw new DomainException("Withdrawal exceeding the account withdrawal limit");
            }
            Balance = Balance - amount;
        }
    }
}
