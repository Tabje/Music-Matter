using Admin.Domain.Common;

namespace Admin.Domain
{
    public class Profile : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? BirthDate { get; set; }
        public string ImageUrl { get; set; }

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
