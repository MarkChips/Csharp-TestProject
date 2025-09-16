Random random = new();

int hero = 10, monster = 10;

do
{
    int attack = random.Next(1, 11);

    monster -= attack;
    Console.WriteLine($"Monster was damaged and lost {attack} health and now has {monster} health.");

    if (monster <= 0) break;

    hero -= attack;
    Console.WriteLine($"Hero was damaged and lost {attack} health and now has {hero} health.");
} while (hero > 0);

Console.WriteLine(hero > 0 ? "Hero wins!🤺" : "Monster wins!👹");