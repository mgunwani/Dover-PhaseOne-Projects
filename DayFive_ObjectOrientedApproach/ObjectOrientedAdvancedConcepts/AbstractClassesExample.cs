/*using System;

namespace ObjectOrientedAdvancedConcepts
{
    abstract class ManageAccount
    {
        public static void showMessage()
        {
            Console.WriteLine("Welcome Everyone Here!!");
        }
        public void welcomeMessage()
        {
            Console.WriteLine("Welcome to ABC Bank!!");
        }
        public abstract void openAccount();
        public abstract void closeAccount();
    }

    abstract class BankAccount: ManageAccount
    {
        public abstract void deposit();
        public abstract void withdraw();
        public abstract void balance();
    }

    class SavingAccount : BankAccount
    {
        public override void balance()
        {
            Console.WriteLine("Balance in Saving Account");
        }

        public override void closeAccount()
        {
            Console.WriteLine("Close Saving Account.");
        }

        public override void deposit()
        {
            Console.WriteLine("Deposit in Saving Account");
        }

        public override void openAccount()
        {
            Console.WriteLine("Opem Saving Account.");
        }

        public override void withdraw()
        {
            Console.WriteLine("Withdraw from Saving Account");
        }
    }

    class CurrentAccount : BankAccount
    {
        public override void balance()
        {
            Console.WriteLine("Balance in Current Account");
        }

        public override void closeAccount()
        {
            Console.WriteLine("Close Current Account.");
        }

        public override void deposit()
        {
            Console.WriteLine("Deposit in Current Account");
        }

        public override void openAccount()
        {
            Console.WriteLine("Open Current Account.");
        }

        public override void withdraw()
        {
            Console.WriteLine("Withdraw from Current Account");
        }
    }

    class AbstractClassesExample
    {
        static void Main(string[] args)
        {
            ManageAccount.showMessage();

            SavingAccount savingAccount = new SavingAccount();
            savingAccount.welcomeMessage();
            savingAccount.openAccount();
            savingAccount.deposit();
            savingAccount.withdraw();
            savingAccount.balance();
            savingAccount.closeAccount();

            CurrentAccount currentAccount = new CurrentAccount();
            currentAccount.openAccount();
            currentAccount.deposit();
            currentAccount.withdraw();
            currentAccount.balance();
            currentAccount.closeAccount();

            Console.ReadKey();
        }
    }
}
*/