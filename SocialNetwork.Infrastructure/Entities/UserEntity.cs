namespace SocialNetwork.Infrastructure.Entities
{
    public class UserEntity : BaseEntity
    {
        public string Username { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public string? Avatar { get; set; }

        public ICollection<PostEntity> Posts { get; set; }
        public GroupEntity? Group { get; set; }
    }
}
