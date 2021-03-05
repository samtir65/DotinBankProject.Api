using DotinBankProject.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotinBankProject.Data.Data.Mapping
{
    public class CustomerMap
        : IEntityTypeConfiguration<Customer>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Customer> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Customer", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Address)
                .IsRequired()
                .HasColumnName("Address")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.MobileNumber)
                .IsRequired()
                .HasColumnName("MobileNumber")
                .HasColumnType("nvarchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.PhoneNumber)
                .IsRequired()
                .HasColumnName("PhoneNumber")
                .HasColumnType("nvarchar(20)")
                .HasMaxLength(20);

            // relationships

            #endregion
        }


    }
}
