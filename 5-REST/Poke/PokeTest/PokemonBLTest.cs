using System.Collections.Generic;
using Moq;
using PokeModel;
using PokeDL;
using PokeBL;
using Xunit;

namespace PokeTest
{
    public class PokemonBLTest
    {
        [Fact]
        public void Should_Get_All_Pokemon()
        {
            //arrange
            string pokeName ="Wasp";
            int pokeLevel = 5;
            int pokeHealth = 100;

            Pokemon poke = new Pokemon(){
                Name = pokeName,
                Level = pokeLevel,
                Health = pokeHealth
            };

            List<Pokemon> expectedListOfPoke = new List<Pokemon>();
            expectedListOfPoke.Add(poke);

            // we are mocking one of the required dependencies of PokeBL which is IRepository.
            Mock<IRepository> mockRepo = new Mock<IRepository>();

            // We change that if our IRepository.GetAllPokemon() is called, it will always return our expectedListOfPoke
            // in this way, we guranteed that our dependency will always work so if something goes wrong it is the business layer's fault
            mockRepo.Setup(repo => repo.GetAllPokemon()).Returns(expectedListOfPoke);

            // we passed in the mock version of IRepository
            IPokemonBL pokeBL = new PokemonBL(mockRepo.Object);

            //act
            List<Pokemon> actualListOfPoke = pokeBL.GetAllPokemon();

            //assert
            Assert.Same(expectedListOfPoke, actualListOfPoke);
            Assert.Equal(pokeName, actualListOfPoke[0].Name);
            Assert.Equal(pokeLevel, actualListOfPoke[0].Level);
            Assert.Equal(pokeHealth, actualListOfPoke[0].Health);
            
        }
    }
}