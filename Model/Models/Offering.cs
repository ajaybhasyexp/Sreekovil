using DivineAccounts.Model.Models.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DivineAccounts.Model.Models
{
    public class Offering : DbEntity, IEntity
    {
        #region Properties 

        public int OfferingId { get; set; }

        public string OfferingName { get; set; }

        public decimal Price { get; set; }

        public int MaxPerDay { get; set; }

        public int DeityID { get; set; }

        public int Code { get; set; }

        public bool IsBookable { get; set; }

        #endregion

        #region Foreign Key Relations

        public Deity Deity { get; set; }

        public ICollection<OfferingPreBooking> OfferingPreBookings { get; set; }

        public ICollection<OfferingTransaction> OfferingTransactions { get; set; }

        #endregion

        public override void Define(DbModelBuilder builder)
        {
            var offering = builder.Entity<Offering>();
            offering.HasKey(p => p.OfferingId);
            offering.Property(p => p.OfferingName).HasMaxLength(100);
            offering.Property(p => p.OfferingName).IsRequired();
            offering.HasRequired(p => p.Deity).WithMany(p => p.Offerings).HasForeignKey(p => p.DeityID);

        }

        public bool Equals(IEntity other)
        {
            var offering = (Offering)other;
            return (OfferingId == offering.OfferingId);
        }

    }
}
