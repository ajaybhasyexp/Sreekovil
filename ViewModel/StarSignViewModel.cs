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
    public class StarSignViewModel
    {
        IRepository<StarSign> repository = null;

        public StarSignViewModel()
        {
            repository = new Repository<StarSign>();
        }

        public IEnumerable<StarSignDto> GetAllStarSigns()
        {
            StarSignDto dto = new StarSignDto();
            return dto.ToObjects(repository.GetAll());
        }

        public StarSignDto GetByCode(int code)
        {
            StarSignDto dto = new StarSignDto();
            var entity = repository.Collect(p => p.Code == code).FirstOrDefault();
            if (entity != null)
            {
                return dto.ToObject(entity);
            }
            return null;

        }
    }
}
