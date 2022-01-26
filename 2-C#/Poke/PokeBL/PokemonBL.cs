using PokeModel;
using PokeDL;

namespace PokeBL
{
    public class PokemonBL : IPokemonBL
    {
        // dependency injection pattern
        // - this is the manin reason why we created interface first before the class
        // - this will save you time on re-writting code that breakes if you updated a completely separate class
        // - main reason is to prevent us from re-wrtting code that aleady existed on (potentially) 50 files or more without
        // the compiler helps us
        // ****************************************
        private IRepository _repo;
        public PokemonBL(IRepository p_repo)
        {
            _repo = p_repo;
        }
        //******************************************

        public Pokemon AddPokemon(Pokemon p_poke)
        {
            Random rand = new Random();
            //processing data to meet conditions
            //it will either substract or add a range from -5 to 5
            p_poke.Attack += rand.Next(-5,5);
            p_poke.Defence += rand.Next(-5,5);
            p_poke.Health += rand.Next(-5,5);

             //Validation process
            List<Pokemon> listOfPoke = _repo.GetAllPokemon();
            if (listOfPoke.Count < 4)
            {
                _repo.AddPokemon(p_poke);
            }
            else
            {
                throw new Exception("You cannot have more than 4 pokemons!");
            }

            return _repo.AddPokemon(p_poke);
        }
    }
}