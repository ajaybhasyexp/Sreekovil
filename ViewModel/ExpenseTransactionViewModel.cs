// <copyright company="AugmentiWeblabs">
//   All rights reserved. Copyright © 2016 AugmentiWeblabs.
//   This computer program may not be used, copied, distributed, corrected, modified,
//   translated, transmitted or assigned without Augmenti’s prior written authorization
// </copyright>

namespace ViewModel
{
    using DivineAccounts.Model.Models;
    using DivineAccounts.Model.Repository;
    using System;
    using ViewModel.DTOs;

    /// <summary>
    /// The View model class that contains the business methods for Offering Transaction.
    /// </summary>
    public class ExpenseTransactionViewModel
    {
        IRepository<ExpenseTransaction> expenseTransactionrepo = null;

        public ExpenseTransactionViewModel()
        {
            expenseTransactionrepo = new Repository<ExpenseTransaction>();
        }

        /// <summary>
        /// Adds a offering transaction.
        /// </summary>
        /// <param name="transaction">The dto with details to save.</param>
        /// <returns>A offering transaction dto object after saving.</returns>
        public bool AddExpenseTransaction(ExpenseTransactionDto transaction)
        {
            try
            {
                var entity = transaction.ToEntity(transaction);
                expenseTransactionrepo.Insert(entity);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
