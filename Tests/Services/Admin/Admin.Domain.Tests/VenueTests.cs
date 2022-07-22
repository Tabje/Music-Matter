using Shouldly;

namespace Admin.Domain.Tests
{
    public class VenueTests
    {
        [Fact]
        public void Venue_Id()
        {
            //Act
            var obj = new Venue();

            //Assert
            obj.Id.ShouldNotBe(Guid.Empty);
        }

        [Fact]
        public void Venue_BasicInformation()
        {
            //Arrange
            var testName = Guid.NewGuid().ToString();
            var testDescription = Guid.NewGuid().ToString();
            var obj = new Venue();

            //Act
            obj.SetBasicInfo(testName, testDescription);

            //Assert
            obj.Name.ShouldBe(testName);
            obj.Description.ShouldBe(testDescription);
        }

        [Theory]
        [MemberData(nameof(AddressData), parameters: 7)]
        public void Venue_Address(Address address)
        {
            //Arrange            
            var obj = new Venue();

            //Act
            obj.SetAddress(address);

            //Assert
            obj.Address.ShouldBe(address);
        }

        public static TheoryData<Address> AddressData =
            new()
        {
                { new Address() },
                { null }
        };

    }
}
