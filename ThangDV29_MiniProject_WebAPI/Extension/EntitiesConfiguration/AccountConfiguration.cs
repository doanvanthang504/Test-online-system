using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ThangDV29_MiniProject_WebAPI.Models.Configuration
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasKey(k => k.ID);

            builder.HasIndex(e => e.Username).IsUnique();
            builder.HasIndex(d => d.Email).IsUnique();
        }
    }
}
