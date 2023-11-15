namespace Dashboard.Library.Model.Entities
{
    public class Feature : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartOn { get; set; }
        public DateTime? EndOn { get; set; }
        public User User { get; set; }
    }
}
