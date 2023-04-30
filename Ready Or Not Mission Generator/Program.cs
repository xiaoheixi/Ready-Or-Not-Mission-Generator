// See https://aka.ms/new-console-template for more information
string[] missionArray = { "SULLIVAN'S SLOPE", "VOLL HEALTH HOUSE", "CHERRYESSA FARM", "BRISA COVE", "NEON NIGHTCLUB", "WENDERLY HILLS HOTEL", "4U GAS STATION", "BRIXLEY TALENT TIME",
    "COASTAL GROVE MEDICAL CENTER", "CAESAR'S CARS DEALERSHIP", "PORT HOKAN", "MINDJOT DATACENTER", "213 PARK HOMES", "LOS SUENOS POSTAL SERVICE" };
Console.WriteLine("Welcome to Ready Or Not Mission Generator by Justin Zhao!");
Console.WriteLine("Press 1 to generate a mission.");
Console.WriteLine("Press 0 to exit.");
string input = Console.ReadLine();
while(Convert.ToInt32(input) != 0)
{
    Random rnd = new Random();
    int mission = rnd.Next(0, 13);
    Console.WriteLine(missionArray[mission]);
    if (mission == 2)
    {
        int type = rnd.Next(1, 2);
        Console.WriteLine(type);
    }
    if (mission == 6)
    {
        int type = rnd.Next(1, 5);
        Console.WriteLine(type);
    }
    if (mission == 8)
    {
        int type = rnd.Next(1, 5);
        Console.WriteLine(type);
    }
    if (mission == 9)
    {
        int type = rnd.Next(1, 2);
        Console.WriteLine(type);
    }
    if (mission == 12)
    {
        int type = rnd.Next(1, 2);
        Console.WriteLine(type);
    }
    Console.WriteLine("Press 1 to generate a new mission.");
    Console.WriteLine("Press 0 to exit.");
    input = Console.ReadLine();
}
Console.WriteLine("Thanks for using Ready Or Not Mission Generator by Justin Zhao!");