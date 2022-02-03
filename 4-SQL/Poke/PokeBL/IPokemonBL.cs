using PokeModel;

namespace PokeBL
{   
    /// <summary>
    /// business layer is responsible for further validation or processing of data obtained from either the database or the user
    /// what kind of processing? that all depends on the type of functionality you will be doing
    /// </summary>
    public interface IPokemonBL
    {   
        /// <summary>
        /// will add a pokemon data to the database
        /// inital addition of a pokemon will give it some sort of a randomize stats
        /// can only have the total of 4 pokemons in the database
        /// </summary>
        /// <param name="p_poke"></param>
        /// <returns></returns>
        Pokemon AddPokemon(Pokemon p_poke);

        /// <summary>
        /// will give a list of pokemon ojects that are related to the searched name
        /// </summary>
        /// <param name="p_name">Name parameter being used to filter our pokemon</param>
        /// <returns>gives a filtered list of pokemon via the name</returns>
        List<Pokemon> SearchPokemon(string p_name);

        /// <summary>
        /// Will give a list of abilities from a pokemon
        /// </summary>
        /// <param name="p_pokeId">The Id of the pokemon it will search</param>
        /// <returns>list collection that holds ability objects</returns>
        List<Ability> GetAbilitiesByPokeId(int p_pokeId);
        List<Pokemon> GetAllPokemon();
    }
}