global using Serilog; // global using will implicitly import that namespace to the rest of your C# files inside of this project
using PokeUI;
using PokeBL;
using PokeDL;
using Microsoft.Extensions.Configuration;


// creating and configuring our logger
Log.Logger = new LoggerConfiguration()
        .WriteTo.File("./logs/user.txt") //we configure our logger to save in this file
        .CreateLogger();

var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

string _connectionString = configuration.GetConnectionString("Reference2DB");

bool repeat = true;
IMenu menu = new MainMenu();

while (repeat)
{
    Console.Clear();
    menu.Display();
    string ans = menu.UserChoice();
    
    switch (ans)
    {
        case "SearchPokemon":
            Log.Information("Displaying Search Pokemon menu to user");
            menu = new SearchPokemonMenu(new PokemonBL(new SQLRepository(_connectionString)));
            break;
        case "AddPokemon":
            Log.Information("Displaying Add Pokemon menu to user");
            menu = new AddPokeMenu(new PokemonBL(new SQLRepository(_connectionString)));
            break;
        case "MainMenu":
            Log.Information("Displaying Main menu to user");
            menu = new MainMenu();
            break;
        case "Exit":
            Log.Information("Exiting application");
            Log.CloseAndFlush(); // to close our logger resource
            repeat = false;
            break;
        default:
            Console.WriteLine("Page does not exist!");
            Console.WriteLine("Please press enter to continue");
            Console.ReadLine();
            break;
    }
}
