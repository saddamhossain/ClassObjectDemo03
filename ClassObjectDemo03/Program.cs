CreditCard creditCard = new CreditCard();

if (creditCard.WithdrawCash(15000))
{
    Console.WriteLine("Successfully withdrew $15,000.");
}
else
{
    Console.WriteLine("Failed to withdraw $15,000. Transaction exceeds limits.");
}

if (creditCard.WithdrawCash(25000))
{
    Console.WriteLine("Successfully withdrew $25,000.");
}
else
{
    Console.WriteLine("Failed to withdraw $25,000. Exceeds per-transaction limit.");
}


if (creditCard.WithdrawCash(90000))
{
    Console.WriteLine("Successfully withdrew $90,000.");
}
else
{
    Console.WriteLine("Failed to withdraw $90,000. Exceeds daily cash limit.");
}

if (creditCard.PayBill(300000))
{
    Console.WriteLine("Successfully paid $300,000 bill.");
}
else
{
    Console.WriteLine("Failed to pay $300,000 bill. Exceeds card limit.");
}

if (creditCard.PayBill(250000))
{
    Console.WriteLine("Successfully paid $250,000 bill.");
}
else
{
    Console.WriteLine("Failed to pay $250,000 bill. Exceeds card limit.");
}

creditCard.ResetDailyLimit();
Console.WriteLine("Daily withdrawal limit has been reset.");