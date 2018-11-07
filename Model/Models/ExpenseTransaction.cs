using DivineAccounts.Model.Models.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivineAccounts.Model.Models
{
    public class ExpenseTransaction : DbEntity, IEntity
    {
        public int ExpenseTransactionId { get; set; }
        public int ExpenseHeadId { get; set; }
        public decimal Price { get; set; }
        public string ExpenseDescription { get; set; }
        public DateTime ExpenseTransactionDate { get; set; }


        #region Foreign Key Properties
        public ExpenseHead ExpenseHead { get; set; }
        //public ExpenseHead ExpenseHeadId { get; set; }

        //public StarSign StarSign { get; set; }

        #endregion
        public override void Define(DbModelBuilder builder)
        {
            var ExpenseTransaction = builder.Entity<ExpenseTransaction>();
            ExpenseTransaction.HasKey(p => p.ExpenseTransactionId);
            ExpenseTransaction.Property(p => p.ExpenseDescription).HasMaxLength(300);
            ExpenseTransaction.HasRequired(p => p.ExpenseHead).WithMany(p => p.ExpenseTranasctions).HasForeignKey(p => p.ExpenseHeadId);

        }


        public bool Equals(IEntity other)
        {
            var Expense = (ExpenseHead)other;
            return (ExpenseHeadId == Expense.ExpenseHeadId);

        }
    }
}
