namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("ACC1001", 1000);

            Console.WriteLine($"Account Number: {account.AccountNumber}");
            Console.WriteLine($"Initial Balance: {account.Balance}");

            account.Deposit(500);
            account.Withdraw(300);

            Console.WriteLine($"Final Balance: {account.Balance}");
        }
    }
}
