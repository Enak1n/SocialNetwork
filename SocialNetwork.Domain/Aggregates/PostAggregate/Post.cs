using SocialNetwork.Domain.Aggregates.UserAggregate;

namespace SocialNetwork.Domain.Aggregates.PostAggregate
{
    public class Post : BaseModel
    {
        public string? Description { get; private set; }
        public User User { get; private set; }

        private Post(Guid id, string? description, User user)
        {
            Id = id;
            Description = description;
            User = user;
        }
    }
}
