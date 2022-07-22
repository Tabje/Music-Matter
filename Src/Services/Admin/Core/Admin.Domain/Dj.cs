using Admin.Domain.Common;

namespace Admin.Domain
{
    public class Dj : EntityBase
    {
        public Profile? Profile { get; set; }
        public Category? Category { get; set; }
        public List<Tag> Tags { get; set; } = new List<Tag>();
    }
}
