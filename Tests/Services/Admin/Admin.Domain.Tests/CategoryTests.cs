using Shouldly;

namespace Admin.Domain.Tests
{
    public class CategoryTests
    {
        [Fact]
        public void Category_Id()
        {
            //Act
            var obj = new Category();

            //Assert
            obj.Id.ShouldNotBe(Guid.Empty);
        }

        [Fact]
        public void Category_Information()
        {
            //Arrange
            var testName = Guid.NewGuid().ToString();
            var obj = new Category();

            //Act
            obj.SetInformation(testName);

            //Assert
            obj.Name.ShouldBe(testName);
        }
    }
}
