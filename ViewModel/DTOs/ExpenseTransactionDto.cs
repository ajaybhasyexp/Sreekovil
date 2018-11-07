// <copyright company="AugmentiWeblabs">
//   All rights reserved. Copyright © 2016 AugmentiWeblabs.
//   This computer program may not be used, copied, distributed, corrected, modified,
//   translated, transmitted or assigned without Augmenti’s prior written authorization
// </copyright>

using DivineAccounts.Model.Models;
using System;
using ViewModel.Common;

namespace ViewModel
{
    public class ExpenseTransactionDto : ObjectMapper<ExpenseTransaction, ExpenseTransactionDto>
    {
        public int ExpenseTransactionId { get; set; }
        public int ExpenseHeadId { get; set; }
        public decimal Price { get; set; }
        public string ExpenseDescription { get; set; }
        public DateTime ExpenseTransactionDate { get; set; }

        public override ExpenseTransactionDto ToObject(ExpenseTransaction entity)
        {
            var ExpenseTransactionDto = new ExpenseTransactionDto()
            {

                ExpenseTransactionId = entity.ExpenseTransactionId,
                ExpenseHeadId = entity.ExpenseHeadId,
                Price = entity.Price,
                ExpenseDescription = entity.ExpenseDescription,
                ExpenseTransactionDate = entity.ExpenseTransactionDate
                                };
            return ExpenseTransactionDto;
        }

        /// <summary>
        /// The mapper method from dto to entity.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override ExpenseTransaction ToEntity(ExpenseTransactionDto value)
        {
            var entity = new ExpenseTransaction()
            {
                ExpenseTransactionId = value.ExpenseTransactionId,
                ExpenseHeadId = value.ExpenseHeadId,
                Price = value.Price,
                ExpenseDescription = value.ExpenseDescription,
                ExpenseTransactionDate = value.ExpenseTransactionDate
            };
            return entity;
        }

        public override bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}