using BspAcademy.Core.Entities;
using BspAcademy.Core.Repositories;
using BspAcademy.Core.Services;
using BspAcademy.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BspAcademy.Service.Services
{
    public class CityService : GenericServices<City>, ICityService
    {
        private readonly ICityRepository _cityRepository;
        public CityService(IGenericRepository<City> genericRepository, IUnitOfWorks unitOfWorks, ICityRepository cityRepository) : base(genericRepository, unitOfWorks)
        {
            _cityRepository = cityRepository;
        }
    }
}
