// See https://aka.ms/new-console-template for more information
string[] missionArray = { "THANK YOU, COME AGAIN", "23 MEGABYTES A SECOND", "TWISTED NERVE", "THE SPIDER", "A LETHAL OBSESSION", "IDES OF MARCH", "SINUOUS TRAIL", "ENDS OF THE EARTH", "GREASED PALMS", "VALLEY OF THE DOLLS", "ELEPHANT", "RUST BELT", "SINS OF THE FATHER", "NEON TOMB", "BUY CHEAP, BUY TWICE", "CARRIERS OF THE VINE", "RELAPSE", "HIDE AND SEEK", "DORMS", "NARCOS", "LAWMAKER", "MIRAGE AT SEA", "LEVIATHAN", "3 LETTER TRIAD" };
Console.WriteLine("Welcome to Ready Or Not Mission Generator by Justin Zhao!");
Console.WriteLine("Press 1 to generate a mission.");
Console.WriteLine("Press 0 to exit.");
string input = Console.ReadLine();
while(Convert.ToInt32(input) != 0)
{
    Random rnd = new Random();
    int mission = rnd.Next(0, 24);
    Console.WriteLine(missionArray[mission]);
    if (mission == 2)
    {
        int spawn = rnd.Next(1, 2);
        Console.WriteLine(spawn);
    }
    if (mission == 6)
    {
        int spawn = rnd.Next(1, 5);
        Console.WriteLine(spawn);
    }
    if (mission == 8)
    {
        int spawn = rnd.Next(1, 5);
        Console.WriteLine(spawn);
    }
    if (mission == 9)
    {
        int spawn = rnd.Next(1, 2);
        Console.WriteLine(spawn);
    }
    if (mission == 12)
    {
        int spawn = rnd.Next(1, 2);
        Console.WriteLine(spawn);
    }
    Console.WriteLine("Press 1 to generate a new mission.");
    Console.WriteLine("Press 0 to exit.");
    input = Console.ReadLine();
}
Console.WriteLine("Thanks for using Ready Or Not Mission Generator by Justin Zhao!");