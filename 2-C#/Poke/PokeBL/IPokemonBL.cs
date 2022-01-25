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
    }
}