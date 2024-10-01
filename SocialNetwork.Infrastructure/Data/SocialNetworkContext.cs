using Microsoft.EntityFrameworkCore;
using SocialNetwork.Infrastructure.Configurations;
using SocialNetwork.Infrastructure.Entities;

namespace SocialNetwork.Infrastructure.Data
{
    public class SocialNetworkContext : DbContext
    {
        public SocialNetworkContext(DbContextOptions<SocialNetworkContext> options) : base(options) { }

        public DbSet<UserEntity> Users => Set<UserEntity>();
        public DbSet<PostEntity> Posts => Set<PostEntity>();    
        public DbSet<GroupEntity> Groups => Set<GroupEntity>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserEntityConfiguration());
            modelBuilder.ApplyConfiguration(new PostEntityConfiguration());
            modelBuilder.ApplyConfiguration(new GroupEntityConfiguration());
        }
    }
}
