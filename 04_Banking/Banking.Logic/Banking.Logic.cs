namespace Banking.Logic;

public abstract class Account 
{
    public double currentBalance { get; set; }
    public double transactionAmount { get; set; }

    public abstract bool TryToExecute();
}

public class CheckingAccouint : Account
{
    public override bool TryToExecute()
    {
        if (transactionAmount <= 100000)
        {
            var newBalance = currentBalance + transactionAmount;

            if (10000000 > newBalance && newBalance > -10000)
            {
                currentBalance = newBalance;
                return true;
            }
        }

        return false;
    }
}

public class BusinessAccount : Account
{
    public override bool TryToExecute()
    {
        if (transactionAmount <= 100000)
        {
            var newBalance = currentBalance + transactionAmount;

            if (100000000 >= newBalance && newBalance >= -1000000)
            {
                currentBalance = newBalance;
                return true;
            }
        }

        return false;
    }
}

public class SavingsAccount : Account
{
    public override bool TryToExecute()
    {
        if (transactionAmount <= 100000)
        {
            var newBalance = currentBalance + transactionAmount;

            if (10000000 >= newBalance && newBalance >= 0)
            {
                currentBalance = newBalance;
                return true;
            }
        }

        return false;
    }
}