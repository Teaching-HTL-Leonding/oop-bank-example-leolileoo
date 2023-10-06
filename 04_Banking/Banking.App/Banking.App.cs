using Banking.Logic;

internal class Program
{
    private static void Main(string[] args)
    {
        Account account = null!;
        System.Console.Write("Type of account ([c]hecking, [b]usiness, [s]avings)  > ");
        bool @continue = true;
        while (@continue)
        {
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.C:
                    System.Console.Write("Checking account");
                    account = new CheckingAccouint();
                    @continue = false;
                    break;
                case ConsoleKey.B:
                    System.Console.Write("Business account");
                    account = new BusinessAccount();
                    @continue = false;
                    break;
                case ConsoleKey.S:
                    System.Console.Write("Savings account");
                    account = new SavingsAccount();
                    @continue = false;
                    break;
            }
        }
        System.Console.WriteLine();
        System.Console.Write("Account number                                       > "); Console.ReadLine();
        System.Console.Write("Account holder                                       > "); Console.ReadLine();
        System.Console.Write("Current balance                                      > "); account.currentBalance = Convert.ToDouble(Console.ReadLine());
        System.Console.Write("Transaction account number                           > "); Console.ReadLine();
        System.Console.Write("Transaction description                              > "); Console.ReadLine();
        System.Console.Write("Transaction amount                                   > "); account.transactionAmount = Convert.ToDouble(Console.ReadLine());
        System.Console.Write("Transaction timestamp                                > ");
        var key = Console.ReadKey(true);
        if (key.Key == ConsoleKey.Spacebar)
        {
            System.Console.WriteLine(DateTime.Now);
        }
        else
        {
            System.Console.Write(key.KeyChar);
            Console.ReadLine();
        }

        if (account.TryToExecute())
            System.Console.WriteLine($"Transaction executed successfully. The new current balance is {account.currentBalance:f2}€.");
        else
            System.Console.WriteLine("Transaction not allowed.");
    }
}