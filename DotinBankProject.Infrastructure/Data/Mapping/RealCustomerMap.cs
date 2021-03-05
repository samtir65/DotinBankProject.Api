using DotinBankProject.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotinBankProject.Data.Data.Mapping
{
    public class RealCustomerMap
        : IEntityTypeConfiguration<RealCustomer>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<RealCustomer> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Customer", "dbo");
           
            builder.Property(t => t.FirstName)
                .IsRequired()
                .HasColumnName("FirstName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.FatherName)
                .IsRequired()
                .HasColumnName("FatherName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.LastName)
                .IsRequired()
                .HasColumnName("LastName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.NationalCode)
                .IsRequired()
                .HasColumnName("NationalCode")
                .HasColumnType("nvarchar(10)")
                .HasMaxLength(10);

            // relationships
           
            #endregion
        }

       
    }
}
