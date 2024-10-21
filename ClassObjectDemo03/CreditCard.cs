namespace ClassObjectDemo03;

public class CreditCard
{
    private const double MaxLimit = 500000;

    private const double DailyCashLimit = 100000;

    private const double PerTransactionLimit = 20000;

    public double CurrentBalance { get; private set; }

    public double WithdrawToday { get; private set; }

    public CreditCard()
    {
        CurrentBalance = 0;
        WithdrawToday = 0;
    }

    public bool WithdrawCash(double amount)
    {
        if (amount > PerTransactionLimit)
        {
            return false; // Transaction exceeds the per-transaction limit
        }

        if (WithdrawToday + amount > DailyCashLimit)
        {
            return false; // Exceeds the daily cash withdrawal limit
        }

        if (CurrentBalance + amount > MaxLimit)
        {
            return false; // Exceeds the overall card limit
        }

        WithdrawToday += amount;
        CurrentBalance += amount;
        return true;
    }

    public bool PayBill(double amount)
    {
        if (CurrentBalance + amount > MaxLimit)
        {
            return false;  // Exceeds the overall card limit
        }
        CurrentBalance += amount;
        return true;
    }

    public void ResetDailyLimit()
    {
        WithdrawToday = 0;
    }
}