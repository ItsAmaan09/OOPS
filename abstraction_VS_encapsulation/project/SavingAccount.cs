namespace oops_abstraction_encapsulation
{
    public class SavingAccount : Account
    {
        private double balance;  // Encapsulation : hidden data
        public override void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited : {amount}");
            }
        }
        public override void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn : {amount}");
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
        }

        public double GetBalance() // controlled access
        {
            return balance;
        }
    }
}