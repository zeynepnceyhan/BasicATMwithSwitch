
namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = 1000;

            Console.WriteLine("Your balance: " + budget);
            Console.WriteLine("\n *********TRANSACTIONS********** \n");
            Console.WriteLine("1. WITHDRAWAL");
            Console.WriteLine("2. TO DEPOSIT MONEY");
            Console.WriteLine("3. ASK YOUR BALANCE");
            Console.WriteLine("4. CARS RETURN");

            Console.Write("\n PLEASE CHOOSE A TRANSACTION: ");
            int islem = Convert.ToInt32(Console.ReadLine());

            switch (islem)
            {
                case 1:
                    Console.WriteLine("YOUR BALANCE: " + budget);
                    Console.Write("Enter the amount you want to withdraw: ");
                    int tutar = Convert.ToInt32(Console.ReadLine());
                    if (tutar > budget)
                    {
                        Console.WriteLine("Your balance is not enough!");
                        tutar = Convert.ToInt32(Console.ReadLine());

                    }
                    budget = budget - tutar;
                    Console.WriteLine("Your withdrawal is completed. Your new balance: " + budget);
                    break;

                case 2:
                    Console.WriteLine("Your balance: " + budget);
                    Console.Write("Enter the amount you want to deposit: ");
                    tutar = Convert.ToInt32(Console.ReadLine());
                    budget += tutar;
                    Console.WriteLine("Your deposit is completed. Your new balance: " + budget);
                    break;

                case 3:
                    Console.WriteLine("Your balance: " + budget);
                    break;

                case 4:
                    Console.WriteLine("Do not forget your card!");
                    break;
                default:
                    Console.WriteLine("This transaction is not available.");
                    break;

            }
            Console.ReadLine();

        }
    }
}

