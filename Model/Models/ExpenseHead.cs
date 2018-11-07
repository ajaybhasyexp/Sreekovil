using DivineAccounts.Model.Models.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivineAccounts.Model.Models
{
    public class ExpenseHead : DbEntity, IEntity
    {
        public int ExpenseHeadId { get; set; }

        public string ExpenseHeadName { get; set; }

        public string ExpenseHeadDescription { get; set; }

        #region Foreign Key Relations
        public ICollection<ExpenseTransaction> ExpenseTranasctions { get; set; }
        #endregion
        public override void Define(DbModelBuilder builder)
        {
            var ExpenseHead = builder.Entity<ExpenseHead>();
            ExpenseHead.HasKey(p => p.ExpenseHeadId);
            ExpenseHead.Property(p => p.ExpenseHeadName).HasMaxLength(100);
            ExpenseHead.Property(p => p.ExpenseHeadDescription).HasMaxLength(500);
            
        }

        public bool Equals(IEntity other)
        {
            var Expense = (ExpenseHead)other;
            return (ExpenseHeadId == Expense.ExpenseHeadId);

        }
    }


}
