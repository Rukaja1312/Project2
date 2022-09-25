namespace Application.DTOs
{
    using System.ComponentModel.DataAnnotations;

    public class CarEditDTO
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Description is Required!")]
        public string Description { get; set; }
    }
}
