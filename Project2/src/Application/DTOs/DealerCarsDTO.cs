using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class DealerCarsDTO
    {
        public IEnumerable<Car> Cars { get; set; }
    }
}
