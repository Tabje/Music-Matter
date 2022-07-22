using Admin.Domain.Common;

namespace Admin.Domain
{
    public class Tag : EntityBase
    {
        public string Name { get; set; }

        public void SetInformation(string name)
        {
            Name = name;
        }
    }
}
