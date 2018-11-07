namespace ViewModel.DTOs
{
    using DivineAccounts.Model.Models;
    using System;
    using ViewModel.Common;

    public class IncomeHeadDto : ObjectMapper<IncomeHead, IncomeHeadDto>
    {
        public int IncomeHeadId { get; set; }

        public string IncomeHeadName { get; set; }

        public string IncomeHeadDescription { get; set; }

        public override IncomeHead ToEntity(IncomeHeadDto value)
        {
            IncomeHead dt = new IncomeHead()
            {
                IncomeHeadId = value.IncomeHeadId,
                IncomeHeadName = value.IncomeHeadName,
                IncomeHeadDescription = value.IncomeHeadDescription

            };
            return dt;
        }

        public override IncomeHeadDto ToObject(IncomeHead entity)
        {
            IncomeHeadDto dt = new IncomeHeadDto()
            {
                IncomeHeadId = entity.IncomeHeadId,
                IncomeHeadName = entity.IncomeHeadName,
                IncomeHeadDescription = entity.IncomeHeadDescription
          
            };
            return dt;
        }

        public override bool Validate()
        {
            return (!string.IsNullOrEmpty(IncomeHeadName));
        }
    }
}
