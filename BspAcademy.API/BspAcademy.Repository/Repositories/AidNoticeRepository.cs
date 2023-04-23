using BspAcademy.Core.Entities;
using BspAcademy.Core.Repositories;
using BspAcademy.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BspAcademy.Repository.Repositories
{
    public class AidNoticeRepository : GenericRepository<AidNotice>, IAidNoticeRepository
    {
        public AidNoticeRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<AidNotice>> GetAidNoticeWithCityCategory()
        {
            return await _context.AidNotices.Include(x => x.Category).Include(x => x.City).OrderByDescending(x => x.AidNoticeDate).Take(5).ToListAsync();
        }

        public async Task<List<AidNotice>> GetListAidNoticeWithCityCategory(int categoryid, int cityid)
        {
            return await _context.AidNotices.Include(x => x.City).Include(x => x.Category).Where(x => x.CityId == cityid && x.CategoryId == categoryid).ToListAsync();
        }


    }
}
