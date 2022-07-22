using Shouldly;

namespace Admin.Domain.Tests
{
    public class TagTests
    {
        [Fact]
        public void Tag_Id()
        {
            //Act
            var obj = new Tag();

            //Assert
            obj.Id.ShouldNotBe(Guid.Empty);
        }

        [Fact]
        public void Tag_Information()
        {
            //Arrange
            var testName = Guid.NewGuid().ToString();
            var obj = new Tag();

            //Act
            obj.SetInformation(testName);

            //Assert
            obj.Name.ShouldBe(testName);
        }
    }
}
