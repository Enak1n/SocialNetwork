namespace SocialNetwork.Infrastructure.Entities
{
    public class PostEntity : BaseEntity
    {
        public string? Description { get; set; }
        public Guid UserId { get; set; }

        public UserEntity User { get; set; }
    }
}
