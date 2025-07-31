namespace encapsulations
{
    /* ENCAPSULATION
        * When we private our field/data and access them thorough getters/setters
        - is called Encapsulation
        * Data will be secure

        *** Remember :
        * Encapsulation = private + getters/setters
        * Provide access by hiding data
    */
    public class Account
    {
        private double balance; // private data

        public void SetBalance(double amount)
        {
            if (amount > 0)
            {
                balance = amount;
            }
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}