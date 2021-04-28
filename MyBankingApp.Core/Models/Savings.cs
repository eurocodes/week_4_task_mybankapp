using BankingApp.Core.Models;
using System;
using System.Collections.Generic;

namespace MyBankingApp.Core.Models
{
    public class Savings : AccountAbstract
    {
        // constructor
        public Savings()
        {
            string generated;
            Random generator = new Random();
            generated = AccPrefix + generator.Next(0, 999999).ToString("D8");
            AccountNumber = generated;
            TransactionsHistory = new List<Transactions>();
        }

        // constructor with parameters and channing
        public Savings(string ownerId, string accType) : this()
        {
            AccountOwnerId = ownerId;
        }
    }
}
