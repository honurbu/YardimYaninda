using BspAcademy.Core.DTOs;
using BspAcademy.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BspAcademy.Core.Services
{
    public interface IAidNoticeService : IGenericService<AidNotice>
    {
        Task<List<AidNotice>> GetListAidNoticeWithCityCategory(int categoryid,int cityid );
        Task<CustomResponseDto<List<AidNoticeWithCityCategoryDto>>> GetAidNoticeWithCityCategory();

    }
}
