using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialNetwork.Infrastructure.Entities;

namespace SocialNetwork.Infrastructure.Configurations
{
    public class GroupEntityConfiguration : IEntityTypeConfiguration<GroupEntity>
    {
        public void Configure(EntityTypeBuilder<GroupEntity> builder)
        {
            builder.ToTable("Groups");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.User)
                .WithOne(x => x.Group)
                .HasForeignKey<GroupEntity>(x => x.CreatorId);
        }
    }
}
