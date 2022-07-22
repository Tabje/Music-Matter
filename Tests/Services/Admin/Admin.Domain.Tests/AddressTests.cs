using Shouldly;

namespace Admin.Domain.Tests
{
    public class AddressTests
    {
        [Fact]
        public void Address_Id()
        {
            //Act
            var obj = new Address();

            //Assert
            obj.Id.ShouldNotBe(Guid.Empty);
        }

        [Theory]
        [MemberData(nameof(AddressData), parameters: 7)]
        public void Address_Information(string street, string houseNumber, string houseNumberAddition, 
                                        string city, string postalCode, string countryName, string countryCode)
        {
            //Arrange           
            var obj = new Address();

            //Act
            obj.SetInformation(street, houseNumber, houseNumberAddition, city, postalCode, countryName, countryCode);

            //Assert
            obj.Street.ShouldBe(street);
            obj.HouseNumber.ShouldBe(houseNumber);
            obj.HouseNumberAddition.ShouldBe(houseNumberAddition);
            obj.City.ShouldBe(city);
            obj.PostalCode.ShouldBe(postalCode);
            obj.CountryName.ShouldBe(countryName);
            obj.CountryCode.ShouldBe(countryCode);
            obj.FullStreet.ShouldBe(FullStreet(street, houseNumber, houseNumberAddition));
        }

        public static TheoryData<string, string, string, string, string, string, string> AddressData =
            new TheoryData<string, string, string, string, string, string, string>()
        {
                { Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString() }
        };

        private string FullStreet(string street, string houseNumber, string houseNumberAddition)
        {
            return $"{street} {houseNumber}{(!string.IsNullOrWhiteSpace(houseNumberAddition) ? $"-{houseNumberAddition}" : string.Empty)}".Trim();
        }
    }
}