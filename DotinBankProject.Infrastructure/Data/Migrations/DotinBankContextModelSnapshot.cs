﻿// <auto-generated />

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DotinBankProject.Data.Data.Migrations
{
    [DbContext(typeof(DotinBankContext))]
    partial class DotinBankContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DotinBankProject.Core.Entities.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("AccountNumber");

                    b.Property<int>("AccountsTypeId")
                        .HasColumnType("int");

                    b.Property<decimal>("Amount")
                        .HasMaxLength(10)
                        .HasColumnType("decimal(18,9)")
                        .HasColumnName("Amount");

                    b.Property<DateTime>("OpeningDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("OpeningDate");

                    b.Property<string>("Sheba")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Sheba");

                    b.HasKey("Id");

                    b.HasIndex("AccountsTypeId");

                    b.ToTable("Account", "dbo");
                });

            modelBuilder.Entity("DotinBankProject.Core.Entities.AccountType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("AccountType", "dbo");
                });

            modelBuilder.Entity("DotinBankProject.Core.Entities.AccountingDocument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountingDocumentType")
                        .HasColumnType("int");

                    b.Property<int>("BranchCode")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2")
                        .HasColumnName("Date");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Destination");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Source");

                    b.HasKey("Id");

                    b.HasIndex("BranchCode");

                    b.HasIndex("CustomerId");

                    b.ToTable("AccountingDocument", "dbo");
                });

            modelBuilder.Entity("DotinBankProject.Core.Entities.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Address");

                    b.Property<string>("BranchName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("BranchName");

                    b.HasKey("Id");

                    b.ToTable("Branch", "dbo");
                });

            modelBuilder.Entity("DotinBankProject.Core.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Address");

                    b.Property<int>("CustomerType")
                        .HasColumnType("int");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("MobileNumber");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("PhoneNumber");

                    b.HasKey("Id");

                    b.ToTable("Customer", "dbo");

                    b.HasDiscriminator<int>("CustomerType");
                });

            modelBuilder.Entity("DotinBankProject.Core.Entities.CustomersAccount", b =>
                {
                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("AccountId", "CustomerId");

                    b.HasIndex("CustomerId");

                    b.ToTable("CustomersAccount", "dbo");
                });

            modelBuilder.Entity("DotinBankProject.Core.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("IsActive")
                        .HasDefaultValueSql("((1))");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("IsDeleted")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Title");

                    b.HasKey("Id");

                    b.ToTable("Role", "dbo");
                });

            modelBuilder.Entity("DotinBankProject.Core.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BranchCode")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Email");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("IsActive")
                        .HasDefaultValueSql("((1))");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("IsDeleted")
                        .HasDefaultValueSql("((0))");

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("RoleId");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("UserName");

                    b.HasKey("Id");

                    b.HasIndex("BranchCode");

                    b.HasIndex("RoleId");

                    b.ToTable("User", "dbo");
                });

            modelBuilder.Entity("DotinBankProject.Core.Entities.LegalCustomer", b =>
                {
                    b.HasBaseType("DotinBankProject.Core.Entities.Customer");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("CompanyName");

                    b.Property<string>("CompanyNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("CompanyNumber");

                    b.ToTable("Customer", "dbo");

                    b.HasDiscriminator().HasValue(1);
                });

            modelBuilder.Entity("DotinBankProject.Core.Entities.RealCustomer", b =>
                {
                    b.HasBaseType("DotinBankProject.Core.Entities.Customer");

                    b.Property<string>("FatherName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("FatherName");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("FirstName");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("LastName");

                    b.Property<string>("NationalCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("NationalCode");

                    b.ToTable("Customer", "dbo");

                    b.HasDiscriminator().HasValue(0);
                });

            modelBuilder.Entity("DotinBankProject.Core.Entities.Account", b =>
                {
                    b.HasOne("DotinBankProject.Core.Entities.AccountType", "AccountType")
                        .WithMany("Accounts")
                        .HasForeignKey("AccountsTypeId")
                        .HasConstraintName("FK_Account_AccountType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccountType");
                });

            modelBuilder.Entity("DotinBankProject.Core.Entities.AccountingDocument", b =>
                {
                    b.HasOne("DotinBankProject.Core.Entities.Branch", "Branch")
                        .WithMany("AccountingDocuments")
                        .HasForeignKey("BranchCode")
                        .HasConstraintName("FK_AccountingDocument_Branch")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DotinBankProject.Core.Entities.Customer", "Customers")
                        .WithMany("AccountingDocuments")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_AccountingDocument_Customer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");

                    b.Navigation("Customers");
                });

            modelBuilder.Entity("DotinBankProject.Core.Entities.CustomersAccount", b =>
                {
                    b.HasOne("DotinBankProject.Core.Entities.Account", "Accounts")
                        .WithMany("CustomersAccounts")
                        .HasForeignKey("AccountId")
                        .HasConstraintName("FK_CustomerAccount_Account")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DotinBankProject.Core.Entities.Customer", "Customers")
                        .WithMany("CustomersAccounts")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_CustomerAccount_Customer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Accounts");

                    b.Navigation("Customers");
                });

            modelBuilder.Entity("DotinBankProject.Core.Entities.User", b =>
                {
                    b.HasOne("DotinBankProject.Core.Entities.Branch", "Branch")
                        .WithMany("Users")
                        .HasForeignKey("BranchCode")
                        .HasConstraintName("FK_User_Branch")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DotinBankProject.Core.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_User_Role")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("DotinBankProject.Core.Entities.Account", b =>
                {
                    b.Navigation("CustomersAccounts");
                });

            modelBuilder.Entity("DotinBankProject.Core.Entities.AccountType", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("DotinBankProject.Core.Entities.Branch", b =>
                {
                    b.Navigation("AccountingDocuments");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("DotinBankProject.Core.Entities.Customer", b =>
                {
                    b.Navigation("AccountingDocuments");

                    b.Navigation("CustomersAccounts");
                });

            modelBuilder.Entity("DotinBankProject.Core.Entities.Role", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
