// <copyright company="AugmentiWeblabs">
//   All rights reserved. Copyright © 2016 AugmentiWeblabs.
//   This computer program may not be used, copied, distributed, corrected, modified,
//   translated, transmitted or assigned without Augmenti’s prior written authorization
// </copyright>

namespace DivineAccounts.Model.Models
{
    using Base;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;

    public class OfferingPreBooking : DbEntity, IEntity
    {
        public int OfferingPreBookingId { get; set; }

        public int OfferingId { get; set; }

        public DateTime DateOfBooking { get; set; }

        public DateTime DateOfOrdering { get; set; }

        public int ContactNumber { get; set; }

        public string ContactName { get; set; }

        public Offering Offering { get; set; }

        public bool Equals(IEntity other)
        {
            var offeringBookingId = (OfferingPreBooking)other;
            return (OfferingPreBookingId == offeringBookingId.OfferingPreBookingId);
        }

        public override void Define(DbModelBuilder builder)
        {
            var offeringPreBooking = builder.Entity<OfferingPreBooking>();
            offeringPreBooking.HasKey(p => p.OfferingPreBookingId);
            offeringPreBooking.Property(p => p.ContactName).HasMaxLength(100);
            offeringPreBooking.HasRequired(p => p.Offering)
                .WithMany(p => p.OfferingPreBookings)
                .HasForeignKey(p => p.OfferingId);
        }
    }
}
