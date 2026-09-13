using System.ComponentModel.DataAnnotations.Schema;

namespace SystemRoles.Dtos.UsersDtos
{
    public class UpdateUserDto : CreateUserDto
    {
        public int Id   { get; set; }
      

    }
}
