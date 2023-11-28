int monsterHealth = 10;
int heroHealth = 10;



do
{
    Random random = new Random();
int monsterAttack = random.Next(1,10);
int heroAttack = random.Next(1, 10);
    if (heroHealth > 0)
    {
        monsterHealth -= monsterAttack;
        Console.WriteLine($"Monster was damaged and lost {heroAttack} health and now has {monsterHealth} health.");
    }
    if ( monsterHealth > 0)
    {
        heroHealth -= monsterAttack;
        Console.WriteLine($"Hero was damaged and lost {monsterAttack} health and now has {heroHealth} health.");
    } 
}while (heroHealth > 0 && monsterHealth >0);
