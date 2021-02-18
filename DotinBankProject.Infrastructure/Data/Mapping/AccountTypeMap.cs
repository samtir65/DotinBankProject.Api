using DotinBankProject.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotinBankProject.Infrastructure.Data.Mapping
{
    public class AccountTypeMap
        : IEntityTypeConfiguration<AccountType>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<DotinBankProject.Core.Entities.AccountType> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("AccountType", "dbo");
            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);


            // relationships
         
            #endregion
        }

       
    }
}
