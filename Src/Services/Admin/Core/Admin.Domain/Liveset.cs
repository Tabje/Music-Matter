using Admin.Domain.Common;

namespace Admin.Domain
{
    public class Liveset : EntityBase
    {
        public Venue Venue { get; set; }
        public DateTime DatePlayed { get; set; }
    }
}
