using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;


namespace Third_ASP_EF_MVC.Application.Dtos.UsersDtos
{
    public class CreateUserDto
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }
        public string? HashPassword { get; set; }

        public string Username { get; set; }

        public IFormFile? image { get; set; }
      


      
    }
}
