using Dashboard.Library.Model.Enums;

namespace Dashboard.Library.Model.Entities
{
    public class User : EntityBase
    {
        public string Username { get; set; }
        public RoleType Role { get; set; }
        public List <Feature> Features{ get; set; }
    }
}
