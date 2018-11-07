using DivineAccounts.Model.Models;
using DivineAccounts.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.DTOs;

namespace ViewModel
{
    public class OfferingViewModel
    {
        IRepository<Offering> repository = null;

        public OfferingViewModel()
        {
            repository = new Repository<Offering>();
        }

        public bool InsertOffering(OfferingDto offeringDto)
        {
            try
            {
                repository.Insert(offeringDto.ToEntity(offeringDto));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }


        }

        /// <summary>
        /// Get all offerings from the db.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<OfferingDto> GetAllOfferings()
        {
            OfferingDto dto = new OfferingDto();
            var entities = repository.GetAll();
            return dto.ToObjects(entities);

        }

        /// <summary>
        /// Gets the Offering object based on the code supplied.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public OfferingDto GetByCode(int code)

        {
            OfferingDto dto = new OfferingDto();
            var entity = repository.Collect(p => p.Code == code).FirstOrDefault();
            if (entity != null)
            {
                return dto.ToObject(entity);
            }
            return null;

        }
    }
}
