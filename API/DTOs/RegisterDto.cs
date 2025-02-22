using System;
using System.ComponentModel.DataAnnotations;

namespace API.DTOs;

public class RegisterDto
{
    [Required]
    public required String Username { get; set; }
    
    [Required]
    public required String Password { get; set; }
}
