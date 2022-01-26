
using PokeUI;
using PokeBL;
using PokeDL;


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
            menu = new SearchPokemonMenu(new PokemonBL(new Repository()));
            break;
        case "AddPokemon":
            menu = new AddPokeMenu(new PokemonBL(new Repository()));
            break;
        case "MainMenu":
            menu = new MainMenu();
            break;
        case "Exit":
            repeat = false;
            break;
        default:
            Console.WriteLine("Page does not exist!");
            break;
    }
}
