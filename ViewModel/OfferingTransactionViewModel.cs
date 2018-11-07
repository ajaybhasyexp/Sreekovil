// <copyright company="AugmentiWeblabs">
//   All rights reserved. Copyright © 2016 AugmentiWeblabs.
//   This computer program may not be used, copied, distributed, corrected, modified,
//   translated, transmitted or assigned without Augmenti’s prior written authorization
// </copyright>

namespace ViewModel
{
    using DivineAccounts.Model.Models;
    using DivineAccounts.Model.Repository;
    using System.Collections.Generic;
    using ViewModel.DTOs;

    /// <summary>
    /// The View model class that contains the business methods for Offering Transaction.
    /// </summary>
    public class OfferingTransactionViewModel
    {
        IRepository<OfferingTransaction> offeringTransactionRepo = null;

        OfferingTransactionDto mapper = null;

        public OfferingTransactionViewModel()
        {
            offeringTransactionRepo = new Repository<OfferingTransaction>();
            mapper = new OfferingTransactionDto();
        }

        /// <summary>
        /// Adds a offering transaction.
        /// </summary>
        /// <param name="transaction">The dto with details to save.</param>
        /// <returns>A offering transaction dto object after saving.</returns>
        public OfferingTransactionDto AddOfferingTransaction(OfferingTransactionDto transaction)
        {
            var entity = mapper.ToEntity(transaction);
            offeringTransactionRepo.Insert(entity);
            return transaction.ToObject(entity);
        }

        public void AddOfferingTransaction(List<OfferingTransactionDto> transactions)
        {
            var entity = mapper.ToEntities(transactions);
            offeringTransactionRepo.InsertMultiple(entity);
        }

    }
}
