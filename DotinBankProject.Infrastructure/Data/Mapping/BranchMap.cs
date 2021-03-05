using DotinBankProject.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotinBankProject.Data.Data.Mapping
{
    public class BranchMap
        : IEntityTypeConfiguration<Branch>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Branch> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Branch", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int");

            builder.Property(t => t.BranchName)
                .IsRequired()
                .HasColumnName("BranchName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Address)
                .IsRequired()
                .HasColumnName("Address")
                .HasColumnType("nvarchar(50)");
               
            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "Role";
        }

        public struct Columns
        {
            public const string Id = "Id";
            public const string Title = "Title";
            public const string IsActive = "IsActive";
            public const string IsDeleted = "IsDeleted";
        }
        #endregion
    }
}
