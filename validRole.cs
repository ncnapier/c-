string? readResult;
string valueEntered;
string[] validRoles = {"administrator", "manager", "user"};
bool correctRole = false;


Console.WriteLine("Please input user role (Administrator, Manager, or User)");

do
{
    readResult = Console.ReadLine();
    valueEntered = readResult.ToLower().Trim();
    if (validRoles.Contains(valueEntered) == false) 
    {
        Console.WriteLine("The value you entered is not a valid role.");
    }
    else
    {
        correctRole = true;
        Console.WriteLine("The value you entered is a valid role.");
    }
}while (correctRole == false);
readResult = Console.ReadLine();
