using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class SearchByBrand
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
