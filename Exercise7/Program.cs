using System;

namespace Exercise7
{
    class ATM
    {
        private int balance = 1000;

        public void CheckBalance()
        {
            Console.Write("Your balance is: ");
            Console.WriteLine(balance);
        }
        public void WithdrawCash(int n)
        {
            if (n > balance)
            {
                Console.WriteLine("You don't have enough money");
                return;
            }
            balance -= n;
            Console.Write("Your new balance is: ");
            Console.WriteLine(balance);
        }
        public void DepositCash(int n)
        {
            balance += n;
            Console.Write("Your new balance is: ");
            Console.WriteLine(balance);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM();
            Console.WriteLine("Enter your PIN number:");
            Console.ReadLine();
            Console.WriteLine("********** Welcome to ATM **********");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Withdraw Cash");
            Console.WriteLine("3. Deposit Cash");
            Console.WriteLine("4. Quit");
            Console.WriteLine("************************************");
            int choice;
            while(true)
            {
                Console.WriteLine("Enter your choice:");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 4)
                    break;
                switch(choice)
                {
                    case 1:
                        atm.CheckBalance();
                        break;
                    case 2:
                        Console.WriteLine("Enter the amount:");
                        atm.WithdrawCash(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 3:
                        Console.WriteLine("Enter the amount:");
                        atm.DepositCash(Convert.ToInt32(Console.ReadLine()));
                        break;
                    default:
                        Console.WriteLine("Wrong input:");
                        break;
                }
            }
        }
    }
}
