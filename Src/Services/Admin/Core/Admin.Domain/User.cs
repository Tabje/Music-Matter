using Admin.Domain.Common;

namespace Admin.Domain
{
    public class User : EntityBase
    {
        public Profile? Profile { get; set; }
        public List<User> Followers { get; set; } = new List<User>();
        public List<User> Following { get; set; } = new List<User>();
    }
}