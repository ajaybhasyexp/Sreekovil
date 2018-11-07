

namespace DivineAccounts.Model.Models
{
    using Base;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data.Entity;

    public class StarSign : DbEntity, IEntity
    {
        public int StarSignId { get; set; }

        public string StarSignName { get; set; }

        public int Code { get; set; }

        public ICollection<OfferingTransaction> OfferingTransactions { get; set; }

        public override void Define(DbModelBuilder builder)
        {
            var starSign = builder.Entity<StarSign>();
            starSign.HasKey(p => p.StarSignId);
            starSign.Property(p => p.StarSignName).HasMaxLength(100);
        }

        public bool Equals(IEntity other)
        {
            var starSign = (StarSign)other;
            return (StarSignId == starSign.StarSignId);
        }

    }
}
