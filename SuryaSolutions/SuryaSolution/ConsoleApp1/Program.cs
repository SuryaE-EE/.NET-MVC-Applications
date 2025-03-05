namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Generate 1 to 10 using while loop...");
            int i = 1;
            while(i<=10)
            {

                Console.Write($"{i}");
                i++;
                
            }

            Console.WriteLine("\n ------------");
            Console.WriteLine("Display 1 to 10 numbers using do while");
            i = 1;
            do
            {
                Console.WriteLine($"{i}");
                i++;
            }while(i<=10);
   
        }

    }
}
