using AutoMapper;
using BspAcademy.Core.DTOs;
using BspAcademy.Core.Entities;
using BspAcademy.Core.Services;
using BspAcademy.Repository.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BspAcademy.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AidNoticeController : ControllerBase
    {
        private readonly IAidNoticeService _aidNoticeService;
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public AidNoticeController(IAidNoticeService aidNoticeService, AppDbContext context, IMapper mapper)
        {
            _aidNoticeService = aidNoticeService;
            _context = context;
            _mapper = mapper;
        }



        [HttpGet("{categoryid}/{cityid}")]
        public async Task<IActionResult> GetList(int categoryid, int cityid)
        {
            var values = await _aidNoticeService.GetListAidNoticeWithCityCategory(categoryid,cityid );
            return Ok(values);
        }


        [HttpPost]
        public async Task<IActionResult> AddAidNotice(AidNoticeAddDto aidNoticeDto)
        {
            var values = await _aidNoticeService.AddAsync(_mapper.Map<AidNotice>(aidNoticeDto));
            var valuesDto = _mapper.Map<AidNoticeAddDto>(values);

       
            return Ok(valuesDto);
        }


        [HttpGet]
        public async Task<IActionResult> GetLast()
        {
            var values = await _aidNoticeService.GetAidNoticeWithCityCategory();
            return Ok(values);
        }


    }
}
