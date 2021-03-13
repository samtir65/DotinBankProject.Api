using DotinBankProject.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotinBankProject.Data.Data.Mapping
{
    public class AccountMap
        : IEntityTypeConfiguration<Account>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Account> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Account", "dbo");

            // key
            builder.HasKey(t => t.Id);
            
                
                

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                ;

            builder.Property(t => t.AccountNumber)
                .IsRequired()
                .HasColumnName("AccountNumber")
                .HasColumnType("nvarchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.Sheba)
                .HasColumnName("Sheba")
                .HasColumnType("nvarchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.OpeningDate)
                .IsRequired()
                .HasColumnName("OpeningDate")
                .HasColumnType("datetime2");

            builder.Property(t => t.Amount)
                .IsRequired()
                .HasColumnName("Amount")
                .HasColumnType("decimal(18,9)")
                .HasMaxLength(10);

            // relationships
            builder.HasOne(a => a.AccountType)
                .WithMany(a =>a.Accounts)
                .HasForeignKey(d => d.AccountsTypeId)
                .HasConstraintName("FK_Account_AccountType");

            #endregion
        }


    }
}
