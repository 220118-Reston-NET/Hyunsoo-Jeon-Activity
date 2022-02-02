namespace PokeUI
{
    // mainmenu inherits IMenu interface but since it is a class it needs to give actual implementation details to the methods stated inside of the interface
    public class MainMenu : IMenu
    {
        public void Display()
        {
            Console.WriteLine("Welcome to Pokemon!");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("[2] Search Pokemon");
            Console.WriteLine("[1] Add pokemon to your team");
            Console.WriteLine("[0] Exit");
        }

        public MenuType UserChoice()
        {
            string userInput = Console.ReadLine();

            //Switch cases are just useful if you are doing a bunch of comparison
            switch (userInput)
            {
                case "0":
                    return MenuType.Exit;
                case "1":
                    return MenuType.AddPokemon;
                case "2":
                    return MenuType.SearchPokemon;
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return MenuType.MainMenu;
            }
    }
}
}