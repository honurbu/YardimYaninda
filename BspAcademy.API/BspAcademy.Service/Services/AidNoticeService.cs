using AutoMapper;
using BspAcademy.Core.DTOs;
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
    public class AidNoticeService : GenericServices<AidNotice>, IAidNoticeService
    {
        private readonly IAidNoticeRepository _aidNoticeRepository;
        private readonly IMapper _mapper;
        public AidNoticeService(IGenericRepository<AidNotice> genericRepository, IUnitOfWorks unitOfWorks, IAidNoticeRepository aidNoticeRepository, IMapper mapper) : base(genericRepository, unitOfWorks)
        {
            _aidNoticeRepository = aidNoticeRepository;
            _mapper = mapper;
        }

        public async Task<CustomResponseDto<List<AidNoticeWithCityCategoryDto>>> GetAidNoticeWithCityCategory()
        {
            var aidNotice = await _aidNoticeRepository.GetAidNoticeWithCityCategory();

            var aidNoticeDto = _mapper.Map<List<AidNoticeWithCityCategoryDto>>(aidNotice);
            return CustomResponseDto<List<AidNoticeWithCityCategoryDto>>.Success(200,aidNoticeDto);
        }

        public async Task<List<AidNotice>> GetListAidNoticeWithCityCategory(int categoryid, int cityid)
        {
            return await _aidNoticeRepository.GetListAidNoticeWithCityCategory(categoryid,cityid);
        }


    }
}
