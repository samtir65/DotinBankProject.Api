using DotinBankProject.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotinBankProject.Data.Data.Mapping
{
    public class UserMap
        : IEntityTypeConfiguration<User>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<User> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("User", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.RoleId)
                .IsRequired()
                .HasColumnName("RoleId")
                .HasColumnType("int");

            builder.Property(t => t.Email)
                .IsRequired()
                .HasColumnName("Email")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.UserName)
                .IsRequired()
                .HasColumnName("UserName")
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
            builder.HasOne(t => t.Role)
                .WithMany(t => t.Users)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_User_Role");

            builder.HasOne(t => t.Branch)
                .WithMany(t => t.Users)
                .HasForeignKey(d => d.BranchCode)
                .HasConstraintName("FK_User_Branch");
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "User";
        }

        public struct Columns
        {
            public const string Id = "Id";
            public const string RoleId = "RoleId";
            public const string Email = "Email";
            public const string UserName = "UserName";
            public const string IsActive = "IsActive";
            public const string IsDeleted = "IsDeleted";
        }
        #endregion
    }
}
