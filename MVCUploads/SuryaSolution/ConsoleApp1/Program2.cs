/*
class Number
{
    private int num1;
    public void SetNumber(int num1)
    {
        this.num1 = num1;
    }
    public void GetNumber()
    {
        Console.WriteLine($"num1 = {num1}");
    }
}


class Program2
{
    static void Main()
    {
        Number n1 = new Number();
        n1.SetNumber(1000);
        n1.GetNumber();
    }
}
*/

/** Subscriber Example

    class Subscriber
    {
        //Data members
        private string uname, pwd;

        //Methods ( member functions )
        public void SignUp()
        {
            Console.Write("Enter user name to register: ");
             string uname = Console.ReadLine();

            Console.Write("Enter password to register: ");
            string pwd = Console.ReadLine();

            Console.WriteLine("User registerd successfully...");
        }
        public void SignIn()
        {
            Console.Write("Enter uname to login: ");
            string uname = Console.ReadLine();

            Console.Write("Enter password: ");
            string pwd = Console.ReadLine();

            if (this.uname == uname && this.pwd == pwd)
                Console.WriteLine("Login success...");
            else
                Console.WriteLine("Login failed...");
        }
    }
    class Program2
    {
        static void Main()
        {
            Subscriber s1 = new Subscriber();
            Subscriber s2 = new Subscriber();
            s1.SignUp();
            s2.SignUp();

            s1.SignIn();
            s2.SignIn();
        }
    }
**/
/**
class BankAccount
{
    //data members
    private int amount, pin, balance;
    private string cname;
    public void RegisterUser()
    {
        Console.Write("Enter uname: ");
        cname = Console.ReadLine();

        Console.Write("Enter initial deposit: ");
        amount = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter pin for security");
        pin = Convert.ToInt32(Console.ReadLine());
    }
    public void CheckBalance()
    {
        Console.Write($"{cname}, Enter pin to check your balanace: ");
        int pin = Convert.ToInt32(Console.ReadLine());
        if (this.pin == pin)
            Console.WriteLine($"{cname} balance is: {amount}");
        else
            Console.WriteLine($"Invalid pin, amount cannot be revealed...");
    }
    public void Deposit()
    {
        Console.WriteLine($"Enter the amount for the deposit:");
        int amount = Convert.ToInt32(Console.ReadLine());
        balance += amount;
    }

}
class Program2
{
    static void Main()
    {
        BankAccount c1 = new BankAccount();
        c1.RegisterUser();
        c1.CheckBalance();
        c1.Deposit();
        c1.CheckBalance();   //final balance not shown//
    }
}
**/
/**
namespace ConsoleApp1
{ 

    class Test
{
    public Test()
    {
        Console.WriteLine("Object initialzation...");
    }
}
class Program2
{
    static void Main()
    {
        Test o1 = new Test();
    }
}
}
**/

/*
constructor:
This is a special method inside the class
    a) Exist with class name
    b) Will be invoked implicity while object creation

Used to intialize class members
Note: Any default values will be set using constructor method

Scenarios like
The default bank balance will be set while opening account
While patient admission into hospital the initial screening will be done using constructor
 */

//// Constructors ////
/*
namespace ConsoleApp1
{
    class BankAccount
    {
        private int accountBalance;
        private int amount = 0;
        public BankAccount(int amount = 0)
        {
            accountBalance = amount;
        }
        public void GetDetails()
        {
            Console.WriteLine($"Axxount balance: {accountBalance}");
        }
    }
    
    class Program2
    {
        static void Main()
        {
            BankAccount c1 = new BankAccount();
            BankAccount c2 = new BankAccount(1000);
            c1.GetDetails();
            c2.GetDetails();
        }
    }

}
*/
/*
namespace ConsoleApp1
{
    class BankAccount
    {
        private string cname;
        private int accountBalance;
        public BankAccount(string cname = "Not Provided", int amount = 0)
        {
            this.cname = cname; accountBalance = amount ;
        }
        public void GetDetails()
        {
            Console.WriteLine($"Name: {cname},Axxount balance: {accountBalance}");
        }
    }

    class Program2
    {
        static void Main()
        {
            BankAccount c1 = new BankAccount();
            BankAccount c2 = new BankAccount("Aravind");
            BankAccount c3 = new BankAccount("Bhaskar", 1000);
            c1.GetDetails();
            c2.GetDetails();
            c3.GetDetails();
        }
    }

}
*/
/*
namespace ConsoleApp1
{
    class BankAccount
    {
        private int accountBalance;
        private string cname;
        public BankAccount(string cname = "Not Provided", int amount = 0)
        {
            string day = DateTime.Now.DayOfWeek.ToString();
            accountBalance = amount;
            if (day == "Thursday")
            {
                this.accountBalance += 1000;
                Console.WriteLine(" Account opened successfully with welcome bonus of 1000 rs");

            }
            this.cname = cname;

        }
        public void GetDetails()
        {
            Console.WriteLine($"Name: {cname},Axxount balance: {accountBalance}");
        }
    }

    class Program2
    {
        static void Main()
        {
            BankAccount c1 = new BankAccount("Bhaskar", 600);
            c1.GetDetails();
            
        }
    }

}
*/
/*
namespace ConsoleApp1
{
    class BankAccount
    {
        private int accountBalance;
        private string cname;
        public BankAccount(string cname = "Not Provided", int amount = 0)
        {
            string day = DateTime.Now.DayOfWeek.ToString();
            accountBalance = amount;
            if (day == "Thursday")
            {
                this.accountBalance += 1000;
                Console.WriteLine(" Account opened successfully with welcome bonus of 1000 rs");

            }
            this.cname = cname;

        }
        public void GetDetails()
        {
            Console.WriteLine($"Name: {cname},Axxount balance: {accountBalance}");
        }
    }

    class Program2
    {
        static void Main()
        {
            BankAccount c1 = new BankAccount("Bhaskar", 600);
            c1.GetDetails();

        }
    }

}
*/
/*

namespace ConsoleApp1
{
    class BankAccount
    {
        public int accountBalance;
        private string cname;

        public BankAccount(string cname = "Not Provided", int amount = 0)
        {
            string day = DateTime.Now.DayOfWeek.ToString();
            accountBalance = amount;
            if (day == "Thursday")
            {
                this.accountBalance += 1000;
                Console.WriteLine("Account opened successfully with a welcome bonus of 1000 rs");
            }
            this.cname = cname;
        }

        public void Deposit(int amount)
        {
            if (amount > 0)
            {
                accountBalance += amount;
                Console.WriteLine($"Amount of {amount} rs deposited successfully. Current balance: {accountBalance} rs.");
            }
            else
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
            }
        }

        public void GetDetails()
        {
            Console.WriteLine($"Name: {cname}, Account balance: {accountBalance}");
        }
    }

    class Program2
    {
        static void Main()
        {
            BankAccount c1 = new BankAccount("Bhaskar", 600);
            c1.GetDetails();
            c1.accountBalance = 500;
            // Testing the Deposit method
            c1.Deposit(500);
            c1.GetDetails();
        }
    }
}
*/
/*
namespace ConsoleApp1
{
    class BankAccount
    {
        private int accountBalance;
        private string cname;

        public BankAccount(string cname = "Not Provided", int amount = 0)
        {
            string day = DateTime.Now.DayOfWeek.ToString();
            accountBalance = amount;
            if (day == "Thursday")
            {
                this.accountBalance += 1000;
                Console.WriteLine("Account opened successfully with a welcome bonus of 1000 rs");
            }
            this.cname = cname;
        }

        public void Deposit(int amount)
        {
            DateTime now = DateTime.Now;
            string day = now.DayOfWeek.ToString();
            int currentHour = now.Hour;

            // Restrict deposit on weekends
            if (day == "Saturday" || day == "Sunday")
            {
                Console.WriteLine("Deposits are not allowed on weekends.");
                return;
            }

            // Restrict deposit outside office hours (9 AM - 5 PM)
            if (currentHour < 9 || currentHour > 17)
            {
                Console.WriteLine("Deposits are only allowed during office hours (9 AM to 5 PM).");
                return;
            }

            // Restrict deposit on amount more than ₹50,000
            if (amount > 50000)
            {
                Console.WriteLine("Deposits greater than ₹50,000 are not allowed.");
                return;
            }

            if (amount > 0)
            {
                accountBalance += amount;
                Console.WriteLine($"Amount of ₹{amount} deposited successfully. Current balance: ₹{accountBalance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
            }
        }

        public void GetDetails()
        {
            Console.WriteLine($"Name: {cname}, Account balance: ₹{accountBalance}");
        }
    }

    class Program2
    {
        static void Main()
        {
            BankAccount c1 = new BankAccount("Bhaskar", 600);
            c1.GetDetails();

            
            c1.Deposit(30000); // Valid deposit during office hours
            c1.Deposit(60000); // Should be restricted due to high amount
        }
    }
}
*/
/*
namespace ConsoleApp1
{
    class BankAccount
    {
        private int accountBalance;
        private string cname;

        public BankAccount(string cname = "Not Provided", int amount = 0)
        {
            this.cname = cname; accountBalance = amount;
        }


        public void Withdraw(int amount)
        {
            DateTime now = DateTime.Now;
            string day = now.DayOfWeek.ToString();
            int currentHour = now.Hour;

            // Restrict withdraw on weekends
            if (day == "Saturday" || day == "Sunday")
            {
                Console.WriteLine("Withdrawals are not allowed on weekends.");
                return;
            }

            // Restrict withdraw outside office hours (9 AM - 5 PM)
            if (currentHour < 9 || currentHour > 17)
            {
                Console.WriteLine("Withdrawals are only allowed during office hours (9 AM to 5 PM).");
                return;
            }

            // Restrict withdraw if there are no funds
            if (accountBalance == 0)
            {
                Console.WriteLine("No funds available for withdrawal.");
                return;
            }

            // Restrict withdraw if funds are less than the requested amount
            if (amount > accountBalance)
            {
                Console.WriteLine($"Insufficient funds. Current balance: ₹{accountBalance}. Requested withdrawal amount: ₹{amount}");
                return;
            }

            if (amount > 0)
            {
                accountBalance -= amount;
                Console.WriteLine($"Amount of {amount} withdrawn successfully. Remaining balance: {accountBalance}");
            }S
            else
            {
                Console.WriteLine("Withdrawal amount must be greater than zero.");
            }
        }

        public void GetDetails()
        {
            Console.WriteLine($"Name: {cname}, Account balance: {accountBalance}");
        }
    }

    class Program2
    {
        static void Main()
        {
            BankAccount c1 = new BankAccount("Bhaskar", 600);
            c1.GetDetails();

            // Testing Withdraw method with various scenarios
            c1.Withdraw(300);  // Valid withdrawal
            c1.Withdraw(400);  // Should be restricted due to insufficient funds
        }
    }
}
*/
/*
namespace ConsoleApp1
{
    class ParkingSlot
    {
        private int type, price, count, amount;
        public ParkingSlot(int type, int count)
        {
            this.type = type; this.count = count;
        }

        public void Display()
        {
            Console.WriteLine($"Type: {type} Vehicle Count:{count}");
        }
    }

    class Program2
    {
        static void Main()
        {
            ParkingSlot tw = new ParkingSlot(2, 30);
            ParkingSlot fw = new ParkingSlot(4, 50);
            tw.Display();
            fw.Display();
        }

    }
}
*/