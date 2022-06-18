namespace OBS.Core.Entities
{
    public class Classroom : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<User> Members { get; set; }
    }
}
