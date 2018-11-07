

namespace DivineAccounts.Model.Models
{
    using DivineAccounts.Model.Models.Base;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class OfferingTransaction : DbEntity, IEntity
    {
        /// <summary>
        /// The unique identifier for offering transaction.
        /// </summary>
        public int OfferingTransactionId { get; set; }

        /// <summary>
        /// The uniqie identifier for Offering object. (Foreign Key)
        /// </summary>
        public int OfferingId { get; set; }

        /// <summary>
        /// The name of the person for whom the offering is taking place.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The starsign id of the person.'s starsign
        /// </summary>
        public int? StarSignId { get; set; }

        /// <summary>
        /// The date and time of the transaction taking place.
        /// </summary>
        public DateTime Date { get; set; }

        #region Foreign Key Properties

        public Offering Offering { get; set; }

        public StarSign StarSign { get; set; }

        #endregion

        public override void Define(DbModelBuilder builder)
        {
            var offeringTransaction = builder.Entity<OfferingTransaction>();
            offeringTransaction.HasKey(p => p.OfferingTransactionId);
            offeringTransaction.Property(p => p.Name).HasMaxLength(100);
            offeringTransaction.HasRequired(p => p.Offering).WithMany(p => p.OfferingTransactions).HasForeignKey(p => p.OfferingId);
            offeringTransaction.HasOptional(p => p.StarSign).WithMany(p => p.OfferingTransactions).HasForeignKey(p => p.StarSignId);
        }

        public bool Equals(IEntity other)
        {
            var offeringTransactionId = (OfferingTransaction)other;
            return (OfferingTransactionId == offeringTransactionId.OfferingTransactionId);
        }


    }
}
