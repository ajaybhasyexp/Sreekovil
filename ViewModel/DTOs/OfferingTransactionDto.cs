

namespace ViewModel.DTOs
{
    using DivineAccounts.Model.Models;
    using System;
    using ViewModel.Common;

    public class OfferingTransactionDto : ObjectMapper<OfferingTransaction, OfferingTransactionDto>
    {
        public int OfferingTransactionId { get; set; }

        public int OfferingId { get; set; }

        public string Name { get; set; }

        public int? StarSignId { get; set; }

        public DateTime Date { get; set; }

        /// <summary>
        /// The mapper method to dto from entity.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public override OfferingTransactionDto ToObject(OfferingTransaction entity)
        {
            var OfferingTransactionDto = new OfferingTransactionDto()
            {
                Date = entity.Date,
                Name = entity.Name,
                OfferingId = entity.OfferingId,
                OfferingTransactionId = entity.OfferingTransactionId,
                StarSignId = entity.StarSignId
            };
            return OfferingTransactionDto;
        }

        /// <summary>
        /// The mapper method from dto to entity.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override OfferingTransaction ToEntity(OfferingTransactionDto value)
        {
            var entity = new OfferingTransaction()
            {
                Date = value.Date,
                Name = value.Name,
                OfferingId = value.OfferingId,
                OfferingTransactionId = value.OfferingTransactionId,
                StarSignId = value.StarSignId
            };
            return entity;
        }

        public override bool Validate()
        {
            return (OfferingId != 0);
        }
    }
}
