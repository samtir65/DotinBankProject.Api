using DotinBankProject.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotinBankProject.Infrastructure.Data.Mapping
{
    public class CustomersAccountMap
        : IEntityTypeConfiguration<CustomersAccount>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CustomersAccount> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("CustomersAccount", "dbo");

            // key
            builder.HasKey(t => new{t.AccountId,t.CustomerId});
           
            // properties


            // relationships
            builder.HasOne(a => a.Customers)
                .WithMany(a =>a.CustomersAccounts)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_CustomerAccount_Customer");

            builder.HasOne(a => a.Accounts)
                .WithMany(a => a.CustomersAccounts)
                .HasForeignKey(d => d.AccountId)
                .HasConstraintName("FK_CustomerAccount_Account");
            #endregion
        }


    }
}
