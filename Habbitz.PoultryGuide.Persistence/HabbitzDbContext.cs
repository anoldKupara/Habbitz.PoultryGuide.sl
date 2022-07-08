using Habbitz.PoultryGuide.Domain.Common;
using Habbitz.PoultryGuide.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Habbitz.PoultryGuide.Persistence
{
    public class HabbitzDbContext : DbContext
    {
        public HabbitzDbContext(DbContextOptions<HabbitzDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(HabbitzDbContext).Assembly);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<BaseDomainEntity>())
            {
                entry.Entity.LastModifiedDate = DateTime.Now;

                if(entry.State == EntityState.Added)
                {
                    entry.Entity.DateCreated = DateTime.Now;
                }
            }
            return base.SaveChangesAsync(cancellationToken);    
        }

        public DbSet<BirdCategory> BirdCategories { get; set; }
        public DbSet<Budget> Budgets { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Feed> Feeds { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Vaccine> Vaccines { get; set; }
    }
}
