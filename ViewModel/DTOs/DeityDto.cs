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
    public class DeityDto : ObjectMapper<Deity, DeityDto>
    {
        /// <summary>
        /// The identifier for the Diety.
        /// </summary>
        public int DeityId { get; set; }

        /// <summary>
        /// The name of the diety.
        /// </summary>
        public string DeityName { get; set; }

        /// <summary>
        /// Description about the diety if any.
        /// </summary>
        public string Description { get; set; }

        public bool IsMain { get; set; }

        public override Deity ToEntity(DeityDto value)
        {
            Deity dt = new Deity()
            {
                DeityId = value.DeityId,
                DeityName = value.DeityName,
                Description = value.Description,
                IsMain = value.IsMain
            };
            return dt;
        }

        public override DeityDto ToObject(Deity entity)
        {
            DeityDto deity = new DeityDto()
            {
                DeityId = entity.DeityId,
                DeityName = entity.DeityName,
                Description = entity.Description,
                IsMain = entity.IsMain
            };
            return deity;
        }

        public override bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}
