double hero = 50;
double heroMana = 20;
double monster = 50;
double potions = 4;
double weakToFire = 2;
double heroIntelligence = 2;
double heroDefense = 0.7;
double heroStrength = 1.5;
Random dice = new Random();
int roll = dice.Next(1,11);
do 
{
    Console.WriteLine("What will you do?");
    string? answer = Console.ReadLine();
    if (answer == "heal")
    {
        if (heroMana > 2)
        {
            heroMana -= 4;
            double heal = (heroIntelligence * 4);
            hero += heal;
            Console.WriteLine($"Hero used Heal and received {heal} health points!");
        }
    }
    if (answer == "fireball")
    {
        if (heroMana > 2)
        {
            heroMana -= 2;
            double fireHit = roll * weakToFire * heroIntelligence;
            monster -= fireHit;
            Console.WriteLine($"Monster was hit with fireball for {fireHit} health points!");
        }
    }
    if (answer == "potion")
    {
        if (potions > 0)
        {
        hero += 2;
        potions -= 1;
        Console.WriteLine($"Healed! You received 2 health points! Hero has {hero} health.");
        }else
        {
            Console.WriteLine("Out of potions!");
        }
    }
    if (answer == "attack")
    {
    double attack = heroStrength * roll;
    monster -= attack;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");
    }
    if (monster <= 0) continue;

    roll = dice.Next(1,11);
    double monsterHit = roll * heroDefense;
    hero -=  monsterHit;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");
    
} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero Wins!" : "Monster Wins!");
