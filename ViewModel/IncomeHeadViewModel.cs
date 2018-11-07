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

    public class IncomeHeadViewModel
    {
        public IncomeHeadViewModel()
        {
            repository = new Repository<IncomeHead>();
        }

        /// <summary>
        /// The repository that contains data operations for Deity.
        /// </summary>
        IRepository<IncomeHead> repository = null;

        public IEnumerable<IncomeHeadDto> GetAllIncomeHead()
        {
            IncomeHeadDto dto = new IncomeHeadDto();
            var entities = repository.GetAll();
            return dto.ToObjects(entities);
        }

        public bool InsertIncomeHead(IncomeHeadDto incomeHeadDto)
        {
            try
            {
                repository.Insert(incomeHeadDto.ToEntity(incomeHeadDto));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
