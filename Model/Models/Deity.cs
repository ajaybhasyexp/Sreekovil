// <copyright company="AugmentiWeblabs">
//   All rights reserved. Copyright © 2016 AugmentiWeblabs.
//   This computer program may not be used, copied, distributed, corrected, modified,
//   translated, transmitted or assigned without Augmenti’s prior written authorization
// </copyright>

namespace DivineAccounts.Model.Models
{
    using DivineAccounts.Model.Models.Base;
    using System.Data.Entity;
    using System.Collections.Generic;

    /// <summary>
    /// The Deity model.
    /// </summary>
    public class Deity : DbEntity, IEntity
    {
        public int DeityId { get; set; }

        public string DeityName { get; set; }

        public string Description { get; set; }

        public bool IsMain { get; set; }

        public ICollection<Offering> Offerings { get; set; }

        public override void Define(DbModelBuilder builder)
        {
            var diety = builder.Entity<Deity>();
            diety.HasKey(p => p.DeityId);
            diety.Property(p => p.DeityName).HasMaxLength(100);
            diety.Property(p => p.Description).HasMaxLength(100);

        }

        public bool Equals(IEntity other)
        {
            var deity = (Deity)other;
            return (DeityId == deity.DeityId);
        }
        
    }
}
