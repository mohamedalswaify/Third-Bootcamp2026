using System.ComponentModel.DataAnnotations;

namespace Third_ASP_EF_MVC.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = "";

        public string? Description { get; set; }
    }
}
