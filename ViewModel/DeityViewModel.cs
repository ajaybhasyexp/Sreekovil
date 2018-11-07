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

    public class DeityViewModel
    {
        public DeityViewModel()
        {
            repository = new Repository<Deity>();
        }

        /// <summary>
        /// The repository that contains data operations for Deity.
        /// </summary>
        IRepository<Deity> repository = null;

        public IEnumerable<DeityDto> GetAllDeities()
        {
            DeityDto dto = new DeityDto();
            var entities = repository.GetAll();
            return dto.ToObjects(entities);
        }

        public bool InsertDeity(DeityDto deityDto)
        {
            try
            {
                repository.Insert(deityDto.ToEntity(deityDto));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
