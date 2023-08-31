using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrete
{
    public class Service : BaseEntity
    {
        public required string ServiceIcon { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
    }
}
