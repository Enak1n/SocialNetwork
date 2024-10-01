using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialNetwork.Infrastructure.Entities;

namespace SocialNetwork.Infrastructure.Configurations
{
    public class PostEntityConfiguration : IEntityTypeConfiguration<PostEntity>
    {
        public void Configure(EntityTypeBuilder<PostEntity> builder)
        {
            builder.ToTable("Posts");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.CreatedDate).HasDefaultValueSql("CURRENT_TIMESTAMP").HasColumnType("timestamp with time zone");
        }
    }
}
