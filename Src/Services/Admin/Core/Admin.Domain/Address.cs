using Admin.Domain.Common;

namespace Admin.Domain
{
    public class Address : EntityBase
    {
        public string Street { get; set; } = string.Empty;
        public string HouseNumber { get; set; } = string.Empty;
        public string HouseNumberAddition { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string CountryName { get; set; } = string.Empty;
        public string CountryCode { get; set; } = string.Empty;

        public string FullStreet =>
            $"{Street} {HouseNumber}{(!string.IsNullOrWhiteSpace(HouseNumberAddition) ? $"-{HouseNumberAddition}" : string.Empty)}".Trim();
    
        public void SetInformation(string street, string houseNumber, string houseNumberAddition, string city, string postalCode, string countryName, string countryCode)
        {
            Street = street;
            HouseNumber = houseNumber;
            HouseNumberAddition = houseNumberAddition;
            City = city;
            PostalCode = postalCode;
            CountryName = countryName;
            CountryCode = countryCode;
        }
    }
}
