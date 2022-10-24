// See https://aka.ms/new-console-template for more information
string[] missionArray = { "213 PARK HOMES", "4U GAS STATION", "BRISA COVE", "CAESAR'S CARS DEALERSHIP", "CHERRYESSA FARM", "CLUB", "FAST FOOD", "HOTEL ROOMS", "PORT HOKEN", "VALLEY OF THE DOLLS", "WENDERLY HILLS HOTEL" };
Console.WriteLine("Welcome to Ready Or Not Mission Generator by Justin Zhao!");
Console.WriteLine("Press 1 to generate a mission.");
Console.WriteLine("Press 0 to exit.");
string input = Console.ReadLine();
while(Convert.ToInt32(input) != 0)
{
    Random rnd = new Random();
    int mission = rnd.Next(0, 10);
    if (mission == 0)
    {
        Console.WriteLine(missionArray[mission]);
        int type = rnd.Next(1, 2);
        Console.WriteLine(type);
    }
}
Console.WriteLine("Thanks for using Ready Or Not Mission Generator by Justin Zhao!");