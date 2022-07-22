using Admin.Domain.Common;

namespace Admin.Domain
{
    public class Profile : EntityBase
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime? BirthDate { get; set; }
        public string ImageUrl { get; set; } = string.Empty;

        public void SetInformation(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void SetBirthDate(DateTime? birthDate)
        {
            BirthDate = birthDate;
        }

        public void SetImageUrl(string imageUrl)
        {
            ImageUrl = imageUrl;
        }

    }
}
