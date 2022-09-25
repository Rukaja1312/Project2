using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Dealer
    {
        public Dealer()
        {
            Cars = new List<Car>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(30)]
        public string Name { get; set; }


        [Required]
        public string UserId { get; set; }

        public IEnumerable<Car> Cars { get; set; }
    }
}
