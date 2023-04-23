using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BspAcademy.Core.Entities
{
    public class City : BaseEntity
    {
        public string? CityName { get; set; }

        //relations 
        public List<AidNotice> AidNotices { get; set; }

    }
}
