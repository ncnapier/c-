for(int i = 0; i < 101; i++)
{
    if (i % 3 == 0 && i % 5 == 0) 
{
    Console.WriteLine("FizzBuz");
}else if (i % 3 == 0)
{
    Console.WriteLine("Fizz");
}else if ( i % 5 == 0)
{
    Console.WriteLine("Buzz");
}else
{
    Console.WriteLine(i);
}
}
