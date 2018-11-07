using DivineAccounts.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Common;

namespace ViewModel.DTOs
{
    public class StarSignDto : ObjectMapper<StarSign, StarSignDto>
    {
        /// <summary>
        /// The StarSign Identifier.
        /// </summary>
        public int StarSignId { get; set; }

        /// <summary>
        /// The name of the star sign.
        /// </summary>
        public string StarSignName { get; set; }

        /// <summary>
        /// The code for the star sign.
        /// </summary>
        public int Code { get; set; }

        public override StarSign ToEntity(StarSignDto value)
        {
            StarSign starSign = new StarSign()
            {
                StarSignId = value.StarSignId,
                StarSignName = value.StarSignName,
                Code = value.Code
            };
            return starSign;
        }

        public override StarSignDto ToObject(StarSign entity)
        {
            StarSignDto starSign = new StarSignDto()
            {
                StarSignId = entity.StarSignId,
                StarSignName = entity.StarSignName,
                Code = entity.Code
            };
            return starSign;
        }

        public override bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}
