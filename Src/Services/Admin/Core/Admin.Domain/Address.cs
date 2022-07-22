using Admin.Domain.Common;

namespace Admin.Domain
{
    public class Address : EntityBase
    {
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string HouseNumberAddition { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }

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
