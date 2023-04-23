using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BspAcademy.Core.Entities
{
    public class Category : BaseEntity
    {
        public string? CategoryName { get; set; }

        //relations

        public List<AidNotice> AidNotices { get; set; }
    }
}
