using DivineAccounts.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivineAccounts.Model
{
    public class DAContext : DbContext
    {
        public DAContext() : base("DAContext")
        {

        }

        public DbSet<Deity> Deities { get; set; }
        public DbSet<IncomeHead> IncomeHead { get; set; }
        public DbSet<ExpenseHead> ExpenseHead { get; set; }

        public DbSet<Offering> Offerings { get; set; }

        public DbSet<OfferingPreBooking> OfferingPreBookings { get; set; }

        public DbSet<OfferingTransaction> OfferingTransactions { get; set; }

        public DbSet<StarSign> StarSigns { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
