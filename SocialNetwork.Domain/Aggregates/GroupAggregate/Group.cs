namespace SocialNetwork.Domain.Aggregates.GroupAggregate
{
    public class Group : BaseModel
    {
        public string Name { get; private set; }
        public string? Description { get; private set; }
        public DateTime CreatedDate { get; private set; }

        private Group(Guid id, string name, string? description, DateTime createdDate)
        {
            Id = id;
            Name = name;
            Description = description;
            CreatedDate = createdDate;
        }
    }
}
