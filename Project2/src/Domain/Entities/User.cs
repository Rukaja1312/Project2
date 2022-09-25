using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities;

public class User : IdentityUser
{
    [MinLength(5)]
    [MaxLength(50)]
    public string? FullName{ get; set; }
}
