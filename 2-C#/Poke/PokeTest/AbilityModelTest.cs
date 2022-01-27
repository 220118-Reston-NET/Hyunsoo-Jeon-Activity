using Xunit;
using PokeModel;

namespace PokeTest
{
    public class AbilityModelTest
{
    /// <summary>
    /// Checks the validation for PP property for vaild data
    /// </summary>
    /// [Fact] is a data annotation in C# and all it means is it will tell the compier that this specific method a unit test
    [Fact]
    public void PPShouldSetValidData()
    {  
        // arrange
        Ability abi = new Ability();
        int validPP = 10;

        // act
        abi.PP = validPP;

        // Assert
        Assert.NotNull(abi.PP); // checks that the property is not null meaning we did set data in this property
        Assert.Equal(validPP, abi.PP); // checks if the property does indeed hold the same value as what we set it as 

    }

    /// <summary>
    /// checks validation for PP property with incorrect data
    /// should throw an exception
    /// </summary>
    [Theory] // changes the unit test to be parameterized and run multiple data and ensure they all passes
    [InlineData(-10)]
    [InlineData(-100)]
    [InlineData(-23231)]
    public void PPShouldFailSetInvalidData(int p_invalidPP)
    {
        // arrange 
        Ability abi = new Ability();

        // act & assert
        Assert.Throws<System.Exception>(
            () => abi.PP = p_invalidPP
        );
    }
}
}

