using Admin.Domain.Common;

namespace Admin.Domain
{
    public class Profile : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? BirthDate { get; set; }

    }
}
