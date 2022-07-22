using Admin.Domain.Common;

namespace Admin.Domain
{
    public class Playlist : EntityBase
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public List<Liveset> Livesets { get; set; } = new List<Liveset>();
    }
}
