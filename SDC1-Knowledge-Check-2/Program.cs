using SDC1_Knowledge_Check_2.Games;
using System.Text.Json;

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<VideoGame>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var videoGame = new VideoGame();

    Console.WriteLine("Enter the name of the game: ");
    videoGame.Name = Console.ReadLine();
    Console.WriteLine("Enter the type of video game console: ");
    videoGame.GameConsole = Console.ReadLine();
    Console.WriteLine("Enter the description of the game: ");
    videoGame.Description = Console.ReadLine();
    Console.WriteLine("Enter the number of max players: ");
    videoGame.PlayerCount = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter 'true' if internet is required, otherwise enter 'false': ");
    videoGame.NeedsInternet = Convert.ToBoolean(Console.ReadLine());
    Console.WriteLine("Enter the price of the game: ");
    videoGame.Price = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("Enter the quantity of copies you have: ");
    videoGame.Quantity = Convert.ToInt32(Console.ReadLine());



    recordList.Add(videoGame);
    recordList.ToString();

}

// Print out the list of records using Console.WriteLine()
Console.WriteLine($"You have {numberOfRecords} records. {JsonSerializer.Serialize(recordList)}.");

Console.ReadKey();