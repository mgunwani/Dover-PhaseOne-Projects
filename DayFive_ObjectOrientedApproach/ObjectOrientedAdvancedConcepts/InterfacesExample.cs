﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedAdvancedConcepts
{
    interface ManageAccount
    {
        void openAccount();
        void closeAccount();
    }
    interface BankAccount
    {
        void deposit();
        void withdraw();
        void balance();
    }

    class SavingAccount : BankAccount, ManageAccount
    {
        public void balance()
        {
            Console.WriteLine("Balance in Saving Account");
        }

        public void closeAccount()
        {
            Console.WriteLine("Close Saving Account.");
        }

        public void deposit()
        {
            Console.WriteLine("Deposit in Saving Account");
        }

        public void openAccount()
        {
            Console.WriteLine("Opem Saving Account.");
        }

        public void withdraw()
        {
            Console.WriteLine("Withdraw from Saving Account");
        }
    }
    class InterfacesExample
    {
        static void Main(string[] args)
        {
            SavingAccount savingAccount = new SavingAccount();
            savingAccount.openAccount();
            savingAccount.deposit();
            savingAccount.withdraw();
            savingAccount.balance();
            savingAccount.closeAccount();
        }
    }
}
