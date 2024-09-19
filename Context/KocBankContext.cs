
using KocBank.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace KocBank.Context
{
    public class KocBankContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<BankInformation> BankInformation { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Model.MoneyTransfer> MoneyTransfers { get; set; }
        public DbSet<Model.OrangeList> OrangeList { get; set; }
        public DbSet<Organisation> Organisations { get; set; }
        public DbSet<MoneyTransferType> MoneyTransferType { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<BankBranch> BankBranches { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<AccountTransaction> AccountTransactions { get; set; }
        public DbSet<TransactionType> TransactionTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server = UGUR; Database = KOCBank; Trusted_Connection = True; TrustServerCertificate = True");
            }

            optionsBuilder.UseLazyLoadingProxies();

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Account>().ToTable("Account");
            modelBuilder.Entity<AccountType>().ToTable("AccountType");
            modelBuilder.Entity<BankInformation>().ToTable("BankInformation");
            modelBuilder.Entity<CreditCard>().ToTable("CreditCard");
            modelBuilder.Entity<Currency>().ToTable("Currency");
            modelBuilder.Entity<Model.MoneyTransfer>().ToTable("MoneyTransfer");
            modelBuilder.Entity<Model.OrangeList>().ToTable("OrangeList");
            modelBuilder.Entity<Organisation>().ToTable("Organisation");
            modelBuilder.Entity<MoneyTransferType>().ToTable("MoneyTransferType");
            modelBuilder.Entity<City>().ToTable("City");
            modelBuilder.Entity<BankBranch>().ToTable("BankBranch");
            modelBuilder.Entity<Employee>().ToTable("Employee");


            modelBuilder.Entity<City>().HasMany<Customer>().WithOne(x => x.City).HasForeignKey(x => x.CityID);
            modelBuilder.Entity<BankInformation>().HasOne<BankBranch>().WithOne(x => x.BankInformation).HasForeignKey<BankBranch>(x => x.BankID);
            modelBuilder.Entity<AccountType>().HasMany<Account>().WithOne(x => x.AccountType).HasForeignKey(x => x.AccountTypeID);
            modelBuilder.Entity<Currency>().HasMany<Account>().WithOne(x => x.Currency).HasForeignKey(x => x.CurrencyID);

            modelBuilder.Entity<Account>()
                        .Property(a => a.Balance)
                        .HasColumnType("decimal(18, 2)"); 

            modelBuilder.Entity<Account>()
                .Property(a => a.CommissionRate)
                .HasColumnType("decimal(5, 2)"); // örn. 999.99

            modelBuilder.Entity<Account>()
                .Property(a => a.InterestRate)
                .HasColumnType("decimal(5, 2)"); 

            modelBuilder.Entity<Model.MoneyTransfer>()
                .Property(mt => mt.Amount)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<AccountTransaction>()
                .Property(at => at.Amount)
                .HasColumnType("decimal(18, 2)");
        }

    }
}
