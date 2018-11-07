using DivineAccounts.Model.Models.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivineAccounts.Model.Models
{
    public class IncomeHead : DbEntity, IEntity
    {
        public int IncomeHeadId { get; set; }

        public string IncomeHeadName { get; set; }

        public string IncomeHeadDescription { get; set; }

        public override void Define(DbModelBuilder builder)
        {
            var incomeHead = builder.Entity<IncomeHead>();
            incomeHead.HasKey(p => p.IncomeHeadId);
            incomeHead.Property(p => p.IncomeHeadName).HasMaxLength(100);
            incomeHead.Property(p => p.IncomeHeadDescription).HasMaxLength(500);

        }

        public bool Equals(IEntity other)
        {
            var income = (IncomeHead)other;
            return (IncomeHeadId == income.IncomeHeadId);

        }
    }


}
