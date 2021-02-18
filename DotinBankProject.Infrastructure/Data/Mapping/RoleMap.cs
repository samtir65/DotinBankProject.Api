using DotinBankProject.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotinBankProject.Infrastructure.Data.Mapping
{
    public class RoleMap
        : IEntityTypeConfiguration<Role>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Role> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Role", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int");

            builder.Property(t => t.Title)
                .IsRequired()
                .HasColumnName("Title")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.IsActive)
                .IsRequired()
                .HasColumnName("IsActive")
                .HasColumnType("bit")
                .HasDefaultValueSql("((1))");

            builder.Property(t => t.IsDeleted)
                .IsRequired()
                .HasColumnName("IsDeleted")
                .HasColumnType("bit")
                .HasDefaultValueSql("((0))");

            // relationships
            #endregion
        }

    }
}
