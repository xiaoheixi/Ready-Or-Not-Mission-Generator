// See https://aka.ms/new-console-template for more information
string[] missionArray = { "VOLL HEALTH HOUSE", "CHERRYESSA FARM", "BRISA COVE", "NEON NIGHTCLUB", "HOTEL ROOMS", "WENDERLY HILLS HOTEL", "4U GAS STATION", "TEST LEVEL: AGENCY", "CAESAR'S CARS DEALERSHIP", "PORT HOKAN", "TEST LEVEL: FAST FOOD", "213 PARK HOMES" };
Console.WriteLine("Welcome to Ready Or Not Mission Generator by Justin Zhao!");
Console.WriteLine("Press 1 to generate a mission.");
Console.WriteLine("Press 0 to exit.");
string input = Console.ReadLine();
while(Convert.ToInt32(input) != 0)
{
    Random rnd = new Random();
    int mission = rnd.Next(0, 11);
    Console.WriteLine(missionArray[mission]);
    if (mission == 1)
    {
        int type = rnd.Next(1, 2);
        Console.WriteLine(type);
    }
    if (mission == 5)
    {
        int type = rnd.Next(1, 5);
        Console.WriteLine(type);
    }
    if(mission == 6)
    {
        int type = rnd.Next(1, 5);
        Console.WriteLine(type);
    }
    if(mission == 8)
    {
        int type = rnd.Next(1, 2);
        Console.WriteLine(type);
    }
    if(mission == 9)
    {
        int type = rnd.Next(1, 4);
        Console.WriteLine(type);
    }
    if(mission == 10)
    {
        int type = rnd.Next(1, 3);
        Console.WriteLine(type);
    }
    if(mission == 11)
    {
        int type = rnd.Next(1, 2);
        Console.WriteLine(type);
    }
    Console.WriteLine("Press 1 to generate a new mission.");
    Console.WriteLine("Press 0 to exit.");
    input = Console.ReadLine();
}
Console.WriteLine("Thanks for using Ready Or Not Mission Generator by Justin Zhao!");