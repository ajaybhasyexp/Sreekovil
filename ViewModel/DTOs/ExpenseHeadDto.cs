// <copyright company="AugmentiWeblabs">
//   All rights reserved. Copyright © 2016 AugmentiWeblabs.
//   This computer program may not be used, copied, distributed, corrected, modified,
//   translated, transmitted or assigned without Augmenti’s prior written authorization
// </copyright>

namespace ViewModel.DTOs
{
    using DivineAccounts.Model.Models;
    using System;
    using ViewModel.Common;

    /// <summary>
    /// The business dto object for Diety.
    /// </summary>
    public class ExpenseHeadDto : ObjectMapper<ExpenseHead, ExpenseHeadDto>
    {
        /// <summary>
        /// The identifier for the Diety.
        /// </summary>
        public int ExpenseHeadId { get; set; }

        /// <summary>
        /// The name of the diety.
        /// </summary>
        public string ExpenseHeadName { get; set; }

        /// <summary>
        /// Description about the diety if any.
        /// </summary>
        public string ExpenseDescription { get; set; }

        

        public override ExpenseHead ToEntity(ExpenseHeadDto value)
        {
            ExpenseHead dt = new ExpenseHead()
            {
                ExpenseHeadId = value.ExpenseHeadId,
                ExpenseHeadName = value.ExpenseHeadName,
                
            };
            return dt;
        }

        public override ExpenseHeadDto ToObject(ExpenseHead entity)
        {
            ExpenseHeadDto ExpenseHead = new ExpenseHeadDto()
            {
                ExpenseHeadId = entity.ExpenseHeadId,
                ExpenseHeadName = entity.ExpenseHeadName,
                
            };
            return ExpenseHead;
        }

        public override bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}
