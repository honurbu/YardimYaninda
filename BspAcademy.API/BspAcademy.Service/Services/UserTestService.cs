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
    public class UserTestService : GenericServices<UserTest> , IUserTestService
    {
        private readonly IUserTestRepository _userTestRepository;

        public UserTestService(IGenericRepository<UserTest> genericRepository, IUnitOfWorks unitOfWorks, IUserTestRepository userTestRepository) : base(genericRepository, unitOfWorks)
        {
            _userTestRepository = userTestRepository;
        }
    }
}
