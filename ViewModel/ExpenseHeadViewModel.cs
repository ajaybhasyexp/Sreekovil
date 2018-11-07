// <copyright company="AugmentiWeblabs">
//   All rights reserved. Copyright © 2016 AugmentiWeblabs.
//   This computer program may not be used, copied, distributed, corrected, modified,
//   translated, transmitted or assigned without Augmenti’s prior written authorization
// </copyright>

namespace ViewModel
{
    using DivineAccounts.Model.Models;
    using DivineAccounts.Model.Repository;
    using DTOs;
    using System;
    using System.Collections.Generic;

    public class ExpenseHeadViewModel
    {
        public ExpenseHeadViewModel()
        {
            repository = new Repository<ExpenseHead>();
        }

        /// <summary>
        /// The repository that contains data operations for ExpenseHead.
        /// </summary>
        IRepository<ExpenseHead> repository = null;

        public IEnumerable<ExpenseHeadDto> GetExpenseHead()
        {
            ExpenseHeadDto dto = new ExpenseHeadDto();
            var entities = repository.GetAll();
            return dto.ToObjects(entities);
        }

        public bool InsertExpenseHead(ExpenseHeadDto ExpenseHeadDto)
        {
            try
            {
                repository.Insert(ExpenseHeadDto.ToEntity(ExpenseHeadDto));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
