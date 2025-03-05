
namespace ConsoleApp1
{
    class BankAccount
    {
        private int accountBalance;
        private string cname;

        public BankAccount(string cname = "Not Provided", int amount =0)
        {
            this.cname = cname;
            string now = TheNow.GetCurrentDateAndTime();
            accountBalance = 0;
            string day = TheNow.GetToday();
            if (day == "sat")
            {
                this.accountBalance += 1000; ///
                Console.WriteLine($"Congratualtions for the account bonus Mr. {cname}, you recieved a bonus ");
            }


            if (amount > 0)
            {
                accountBalance += amount; ///
                Console.WriteLine($"{cname}, your initial deposit Rs.{amount}/- credited successfully...");
            }
            Console.WriteLine($"{cname} account opened successfully at {now}");
            Console.WriteLine("-----------------------------------------------------------");
            Thread.Sleep(1000);
        }

        public void Deposit(int amount)
        {
            string now = TheNow.GetCurrentDateAndTime();
            Console.WriteLine($"Attempt: {cname} Deposit request of Rs.{amount}/- at {now}");
            string day = TheNow.GetToday();
            if (day == "sat" || day == "sun")
            {
                Console.WriteLine($"Status: deposit request rejected as you cannot deposit on saturday of sunday");
            }
            else if (!TheNow.IsWorkingHours())
            {
                Console.WriteLine($"Status: deposit request rejected as you deposit cannot be done out of office hours");
            }
            else if (amount > 50000)
                Console.WriteLine($"Status: deposit request rejected as you deposit more than 50k, pls talk to manager for further proceedings");
            else
            {
                accountBalance += amount;
                Console.WriteLine($"Status: {cname} Amount deposited Rs.{amount}/- at {now} successfully...");
            }
            Console.WriteLine("=========================================================================");
            Thread.Sleep(1000);
        }

        public void Withdraw(int amount)
        {
            string now = TheNow.GetCurrentDateAndTime();
            Console.WriteLine($"Attempt: {cname} withdraw request of Rs.{amount}/- at {now}");
            string day = TheNow.GetToday();
            if (day == "sat" || day == "sun")
            {
                Console.WriteLine($"Status: withdraw request rejected as you cannot deposit on saturday of sunday");
            }
            else if (!TheNow.IsWorkingHours())
            {
                Console.WriteLine($"Status: withdraw request rejected as you deposit cannot be done out of office hours");
            }
            else if (accountBalance == 0)
                Console.WriteLine($"Status: withdraw request rejected {cname} balance is zero");
            else if (accountBalance < amount)
                Console.WriteLine($"Status: withdraw request rejected {cname} in sufficient funds");
            else
            {
                accountBalance -= amount;
                Console.WriteLine($"Status: {cname} Amount withdraw Rs.{amount}/- at {now} successfully...");
            }
            Console.WriteLine("=========================================================================");
            Thread.Sleep(1000);
        }
           public void CheckBalance()
        {
            Console.WriteLine($"Attempt: Balance request by {cname}... ");
            Console.Write("Enter pin to proceed: ");
            int pin = Convert.ToInt32(Console.ReadLine());
            if (pin == 2018)
                Console.WriteLine($"Status: {cname} account balance is: {accountBalance}");
            else
                Console.WriteLine($"Status: {cname} Invalid ping and balance cannot be exposed...");
            Console.WriteLine("=========================================================================");
            Thread.Sleep(1000);
        }

        public void FundTransfer(BankAccount c, int amount)
        {
            Console.WriteLine($"Attempt: FT request from {cname} to {c.cname} of Rs. {amount}/-");
            if (accountBalance < amount)
                Console.WriteLine($"Status: FT request rejected as insufficent funds...");
            else
            {
                this.accountBalance -= amount;
                Console.WriteLine($"Process: My account {cname} amount {amount} debited successfully...");
                c.accountBalance += amount;
                Console.WriteLine($"Process: {c.cname} amount transfered successfully...");
            }
            Console.WriteLine("=========================================================================");
            Thread.Sleep(1000);
        }

        public static class TheNow
        {
            public static string GetCurrentDateAndTime()
            {
                return DateTime.Now.ToString();
            }
            public static string GetToday()
            {
                string day = DateTime.Now.DayOfWeek.ToString().Substring(0, 3).ToLower();
                return day;
            }
            public static bool IsWorkingHours()
            {

            int hour = DateTime.Now.Hour;
            return ((hour >= 10 && hour <= 13) || (hour >= 14 && hour <= 17));
        }
    }
        class Program2
        {
            static void Main()
            {
                BankAccount c1 = new BankAccount("Nirmala", 20000);
                BankAccount c2 = new BankAccount("Priya");
                c1.Deposit(1000);
                c1.CheckBalance();
                c2.Deposit(25000);
                c2.CheckBalance();

                c1.FundTransfer(c2, 30000);
            }
        }

    }
}
