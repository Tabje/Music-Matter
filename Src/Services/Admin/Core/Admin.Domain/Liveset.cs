using Admin.Domain.Common;

namespace Admin.Domain
{
    public class Liveset : EntityBase
    {
        public Venue? Venue { get; set; }
        public DateTime DatePlayed { get; set; }
        public string Url { get; set; } = string.Empty;
        public Category? Category { get; set; } 
        public List<Tag> Tags { get; set; } = new List<Tag>();
    }
}
