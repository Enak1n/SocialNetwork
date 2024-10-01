namespace SocialNetwork.Infrastructure.Entities
{
    public class GroupEntity : BaseEntity
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public Guid CreatorId { get; set; }

        public UserEntity User { get; set; }
    }
}
