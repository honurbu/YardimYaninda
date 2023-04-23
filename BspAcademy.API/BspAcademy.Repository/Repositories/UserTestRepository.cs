using BspAcademy.Core.Entities;
using BspAcademy.Core.Repositories;
using BspAcademy.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BspAcademy.Repository.Repositories
{
    public class UserTestRepository : GenericRepository<UserTest>, IUserTestRepository
    {
        public UserTestRepository(AppDbContext context) : base(context)
        {
        }
    }
}
