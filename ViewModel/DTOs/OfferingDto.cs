

namespace ViewModel.DTOs
{
    using System;
    using Common;
    using DivineAccounts.Model.Models;

    public class OfferingDto : ObjectMapper<Offering, OfferingDto>
    {
        public int OfferingId { get; set; }

        public string OfferingName { get; set; }

        public decimal Price { get; set; }

        public int MaxPerDay { get; set; }

        public int DeityID { get; set; }

        public int Code { get; set; }

        public bool IsBookable { get; set; }

        public override OfferingDto ToObject(Offering entity)
        {
            OfferingDto offeringDto = new OfferingDto
            {
                OfferingName = entity.OfferingName,
                Price = entity.Price,
                MaxPerDay = entity.MaxPerDay,
                DeityID = entity.DeityID,
                Code = entity.Code,
                IsBookable = entity.IsBookable,
                OfferingId = entity.OfferingId
            };
            return offeringDto;
        }

        public override Offering ToEntity(OfferingDto value)
        {
            Offering offering = new Offering
            {
                OfferingName = value.OfferingName,
                Price = value.Price,
                MaxPerDay = value.MaxPerDay,
                DeityID = value.DeityID,
                Code = value.Code,
                IsBookable = value.IsBookable,
            };

            return offering;
        }

        public override bool Validate()
        {
            return (!string.IsNullOrEmpty(OfferingName) && Price != 0 && Code != 0);
        }
    }
}
