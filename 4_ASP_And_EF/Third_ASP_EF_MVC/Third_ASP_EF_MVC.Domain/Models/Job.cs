using System.ComponentModel.DataAnnotations;

namespace Third_ASP_EF_MVC.Domain.Models
{
    public class Job
    {
        [Key]
        public int Id { get; set; }

        public string UID { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public string Name { get; set; }


        public ICollection<Employee> Employees { get; set; } = new List<Employee>();



    }
}
