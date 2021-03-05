using DotinBankProject.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotinBankProject.Data.Data.Mapping
{
    public class AccountingDocumentMap
        : IEntityTypeConfiguration<AccountingDocument>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AccountingDocument> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("AccountingDocument", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int");

            builder.Property(t => t.Source)
                .IsRequired()
                .HasColumnName("Source")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Destination)
                .IsRequired()
                .HasColumnName("Destination")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Date)
                .IsRequired()
                .HasColumnName("Date")
                .HasColumnType("datetime2");

            // relationships
            builder.HasOne(a => a.Customers)
                .WithMany(a =>a.AccountingDocuments)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_AccountingDocument_Customer");

            builder.HasOne(a => a.Branch)
                .WithMany(a => a.AccountingDocuments)
                .HasForeignKey(d => d.BranchCode)
                .HasConstraintName("FK_AccountingDocument_Branch");

            #endregion
        }


    }
}
