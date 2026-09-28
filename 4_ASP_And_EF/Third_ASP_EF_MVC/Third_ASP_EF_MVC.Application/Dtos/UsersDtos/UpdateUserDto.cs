using System.ComponentModel.DataAnnotations.Schema;

namespace Third_ASP_EF_MVC.Application.Dtos.UsersDtos
{
    public class UpdateUserDto : CreateUserDto
    {
        public int Id   { get; set; }
      

    }
}
