using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TcaSolutions.Entities;

namespace TcaSolutions.Data.Configurations
{
    internal class LoginConfiguration : IEntityTypeConfiguration<Login>
    {
        public void Configure(EntityTypeBuilder<Login> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("login");

            entityTypeBuilder.HasKey(x => x.Id);

            entityTypeBuilder.Property(a => a.Id)
                .HasColumnName("id")
                .IsRequired();

            entityTypeBuilder.Property(a => a.User)
              .HasColumnName("user")
              .IsRequired();

            entityTypeBuilder.Property(a => a.Password)
              .HasColumnName("Password")
              .IsRequired();

            entityTypeBuilder.Property(a => a.UpdatedAt)
               .HasColumnName("updated_at")
               .IsRequired();

            entityTypeBuilder.Property(a => a.CreatedAt)
               .HasColumnName("created_at")
               .IsRequired();
        }
    }
}
