using Admin.Domain.Common;

namespace Admin.Domain
{
    public class Venue : EntityBase
    {
        public string Name { get; protected set; } = string.Empty;
        public string Description { get; protected set; } = string.Empty;
        public Address? Address { get; set; }

        public void SetBasicInfo(string name, string description)
        {
            Name = name.Trim(); ;
            Description = description.Trim();
        }

        public void SetAddress(Address address)
        {
            Address = address;
        }
    }
}
