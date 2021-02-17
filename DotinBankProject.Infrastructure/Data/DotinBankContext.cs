using Microsoft.EntityFrameworkCore;
using DotinBankProject.Core.Entities;

namespace DotinBank.Data
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
        public virtual DbSet<LegalCustomer> LegalCustomers { get; set; }
        public virtual DbSet<RealCustomer> RealCustomers { get; set; }
        public virtual DbSet<CustomersAccount> CustomersAccounts { get; set; }

        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Generated Configuration
            modelBuilder.ApplyConfiguration(new DotinBank.Data.Mapping.RoleMap());
            modelBuilder.ApplyConfiguration(new DotinBank.Data.Mapping.UserMap());
            #endregion
        }
    }
}
