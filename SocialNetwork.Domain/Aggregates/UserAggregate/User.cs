namespace SocialNetwork.Domain.Aggregates.UserAggregate
{
    public class User : BaseModel
    {
        public string Username { get; private set; }
        public string? Name { get; private set; }
        public string? Surname { get; private set; }
        public string PasswordHash { get; private set; }
        public DateTime DateOfCreation { get; private set; }
        public string Email { get; private set; }
        public string? Avatar { get; private set; }

        private User(Guid id, string username, string? name, string? surname, string passwordHash,
            DateTime dateOfCreation, string email, string? avatar)
        {
            Id = id;
            Username = username;
            Name = name;
            Surname = surname;
            PasswordHash = passwordHash;
            DateOfCreation = dateOfCreation;
            Email = email;
            Avatar = avatar;
        }
    }
}
