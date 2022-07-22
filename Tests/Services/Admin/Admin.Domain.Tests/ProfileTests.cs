using Shouldly;

namespace Admin.Domain.Tests
{
    public class ProfileTests
    {
        [Fact]
        public void Profile_Id()
        {
            //Act
            var obj = new Profile();

            //Assert
            obj.Id.ShouldNotBe(Guid.Empty);
        }

        [Fact]
        public void Profile_Information()
        {
            //Arrange
            var testName = Guid.NewGuid().ToString();
            var testDescription = Guid.NewGuid().ToString();
            var obj = new Profile();

            //Act
            obj.SetInformation(testName, testDescription);

            //Assert
            obj.Name.ShouldBe(testName);
        }

        [Theory]
        [MemberData(nameof(ImageData))]
        public void Profile_Image(string imageUrl)
        {
            //Arrange           
            var obj = new Profile();

            //Act
            obj.SetImageUrl(imageUrl);

            //Assert
            obj.ImageUrl.ShouldBe(imageUrl);
        }

        [Theory]
        [MemberData(nameof(BirthDateData))]
        public void Profile_Birthdate(DateTime? birthDate)
        {
            //Arrange            
            var obj = new Profile();

            //Act
            obj.SetBirthDate(birthDate);

            //Assert
            obj.BirthDate.ShouldBe(birthDate);
        }

        public static TheoryData<DateTime?> BirthDateData =
            new()
        {
                { new DateTime() },
                { null }
        };

        public static TheoryData<string> ImageData =
            new()
        {
                { "" },
                { null },
                { Guid.NewGuid().ToString() }
        };
    }
}
