﻿using BspAcademy.Core.Entities;
using BspAcademy.Core.Repositories;
using BspAcademy.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BspAcademy.Repository.Repositories
{
    public class CityRepository : GenericRepository<City>, ICityRepository
    {
        public CityRepository(AppDbContext context) : base(context)
        {
        }
    }
}
