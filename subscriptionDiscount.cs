Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here

if ( daysUntilExpiration <= 10 && daysUntilExpiration > 5)
{
    Console.WriteLine("Your subscription will expire soon.\n Renew now!");
}
else if (daysUntilExpiration <= 5)
{
    discountPercentage = 10;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\n Renew now and save {discountPercentage}%!");
    
}
else if (daysUntilExpiration == 1)
{
    discountPercentage = 20;
    Console.WriteLine($"your subscription expires within a day!\n Renew now and save {discountPercentage}%!");
    
}
else if (daysUntilExpiration <= 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else
{
    Console.WriteLine(" ");
}
