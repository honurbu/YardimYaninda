using BspAcademy.Core.DTOs;
using BspAcademy.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BspAcademy.Core.Repositories
{
    public interface IAidNoticeRepository : IGenericRepository<AidNotice>
    {
        Task<List<AidNotice>> GetListAidNoticeWithCityCategory(int categoryid,int cityid );
        Task<List<AidNotice>> GetAidNoticeWithCityCategory();
    }
}
