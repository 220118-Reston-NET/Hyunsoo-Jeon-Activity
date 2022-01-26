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
            p_poke.Defense += rand.Next(-5,5);
            p_poke.Health += rand.Next(-5,5);

             //Validation process
            List<Pokemon> listOfPoke = _repo.GetAllPokemon();
            if (listOfPoke.Count < 4)
            {
               return _repo.AddPokemon(p_poke);
            }
            else
            {
                throw new Exception("You cannot have more than 4 pokemons!");
            }

        }

        public List<Pokemon> SearchPokemon(string p_name)
        {
            List<Pokemon> listOfPokemon = _repo.GetAllPokemon();

            //LINQ library
            return listOfPokemon
                        .Where(poke => poke.Name.Contains(p_name)) // where method is designed to filter a collection based on a condition
                        .ToList(); // ToList method just converts into a list collection that our method needs to return
        }
    }
}