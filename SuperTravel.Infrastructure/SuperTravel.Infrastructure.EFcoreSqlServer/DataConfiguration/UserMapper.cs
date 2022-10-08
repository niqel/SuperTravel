using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SuperTravel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTravel.Infrastructure.EFcoreSqlServer.DataConfiguration
{
    public class UserMapper : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(u => u.UserId);
            builder.Property(u => u.UserId).HasColumnName("userId");
            builder.Property(u => u.Name).HasColumnName("name").IsRequired();
            builder.Property(u => u.Nickname).HasColumnName("nickname").IsRequired().IsUnicode();
            builder.Property(u => u.Password).HasColumnName("password").IsRequired();
            builder.Property(u => u.IsActive).HasColumnName("isActive").IsRequired();
            builder.Property(u => u.UpdatedBy).HasColumnName("updatedBy").IsRequired();
            builder.Property(u => u.UpdatedAt).HasColumnName("updatedAt").IsRequired();
            builder.Property(u => u.CreatedBy).HasColumnName("createdBy").IsRequired();
            builder.Property(u => u.CreatedAt).HasColumnName("createdAt").IsRequired();
        }
    }
}
