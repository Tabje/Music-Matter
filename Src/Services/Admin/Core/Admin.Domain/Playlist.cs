using Admin.Domain.Common;

namespace Admin.Domain
{
    public class Playlist : EntityBase
    {
        public string Name { get; protected set; } = string.Empty;
        public string Description { get; protected set; } = string.Empty;

        public List<Liveset> Livesets { get; set; } = new List<Liveset>();
    }
}
