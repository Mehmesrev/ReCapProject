using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.DTOs
{
    public class CarDetailDto : IDto
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int DailyPrice { get; set; }

    }
}
