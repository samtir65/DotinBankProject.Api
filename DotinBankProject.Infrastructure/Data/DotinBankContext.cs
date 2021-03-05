using DotinBankProject.Data.Data.Mapping;
using DotinBankProject.Domain.Models.Entities;
using DotinBankProject.Domain.Models.Entities.Enums;
using Microsoft.EntityFrameworkCore;

namespace DotinBankProject.Data.Data
{
    public class DotinBankContext : DbContext
    {
        public DotinBankContext(DbContextOptions<DotinBankContext> options)
            : base(options)
        {
        }

        #region Generated Properties
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AccountType> AccountTypes { get; set; }
        public virtual DbSet<AccountingDocument> AccountingDocuments { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
       
        public virtual DbSet<CustomersAccount> CustomersAccounts { get; set; }

        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Generated Configuration
            modelBuilder.Entity<Customer>(b => b.HasDiscriminator(x => x.CustomerType)
            .HasValue<LegalCustomer>(CustomerType.Legal)
            .HasValue<RealCustomer>(CustomerType.Real));

            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new AccountTypeMap());
            modelBuilder.ApplyConfiguration(new RoleMap());
            modelBuilder.ApplyConfiguration(new RealCustomerMap());
            modelBuilder.ApplyConfiguration(new LegalCustomerMap());
            modelBuilder.ApplyConfiguration(new AccountMap());
            modelBuilder.ApplyConfiguration(new AccountingDocumentMap());
            modelBuilder.ApplyConfiguration(new CustomersAccountMap());
            modelBuilder.ApplyConfiguration(new BranchMap());
            modelBuilder.ApplyConfiguration(new CustomersAccountMap());
            modelBuilder.ApplyConfiguration(new CustomerMap());
            #endregion
        }
    }
}
