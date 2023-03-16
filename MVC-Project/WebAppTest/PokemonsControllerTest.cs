using MVC_Project.Controllers;

namespace WebAppTest
{
    public class PokemonsControllerTest
    {
        [Fact]
        public void ShouldReturnListOfPokemon()
        {
            // Arrange
            var controller = new PokemonsController();

            // Act
            var result = controller.Get();

            // Assert
            Assert.NotNull(result);
            //Assert.True(result.GetEnumerator().MoveNext());
        }
    }
}