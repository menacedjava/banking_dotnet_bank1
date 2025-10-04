// Banking & Finance App (skeleton)
// Modules: accounts, transactions, auth, 2FA stub, statements
using System;
using System.Collections.Generic;

namespace FinanceApp {
    class Account {
        public int Id;
        public decimal Balance;
    }

    class BankingApp {
        static List<Account> accounts = new List<Account>();
        static void Main(string[] args) {
            Console.WriteLine("Banking app started");
            accounts.Add(new Account { Id = 1, Balance = 1000m });
        }
    }

    // TransactionService.cs (transfer/ledger)
    // AuthService.cs (login/2FA stub)
}
