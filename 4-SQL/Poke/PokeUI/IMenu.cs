namespace PokeUI
{
    public enum MenuType
    {
        MainMenu,
        Exit,
        GetPokeAbililty,
        SearchPokemon,
        AddPokemon
    }

    // interface are one of the best way to implement abstraction
    // every method is implicity abastract meaning you don't have to write anything
    public interface IMenu
    {
        /// <summary>
        /// will display the menu and user choices in the terminal
        /// </summary>
        void Display();
        /// <summary>
        /// will record the user's choice and change/route your menu based on that choice
        /// </summary>
        /// <returns>return the menu that will change your screen</returns>
        MenuType UserChoice();
    }
}