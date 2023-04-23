using BspAcademy.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BspAcademy.Core.DTOs
{
    public class AidNoticeWithCityCategoryDto : BaseDto
    {
        public string? Description { get; set; }
        public string? Address { get; set; }
        public string? Place { get; set; }
        public string? HelperName { get; set; }
        public string? HelperSurname { get; set; }
        public string? HelperPhoneNumber { get; set; }
        public DateTime AidNoticeDate { get; set; }

        public List<CityDto> Cities { get; set; }

        public List<CategoryDto> Categories { get; set; }

    }
}
