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
    public class CategoryService : GenericServices<Category>, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(IGenericRepository<Category> genericRepository, IUnitOfWorks unitOfWorks, ICategoryRepository categoryRepository) : base(genericRepository, unitOfWorks)
        {
            _categoryRepository = categoryRepository;
        }
    }
}
