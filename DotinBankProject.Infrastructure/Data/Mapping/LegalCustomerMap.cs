using DotinBankProject.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotinBankProject.Infrastructure.Data.Mapping
{
    public class LegalCustomerMap
        : IEntityTypeConfiguration<LegalCustomer>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<DotinBankProject.Core.Entities.LegalCustomer> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Customer", "dbo");
          
            builder.Property(t => t.CompanyNumber)
                .IsRequired()
                .HasColumnName("CompanyNumber")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.CompanyName)
                .IsRequired()
                .HasColumnName("CompanyName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);
            // relationships

            #endregion
        }

       
    }
}
