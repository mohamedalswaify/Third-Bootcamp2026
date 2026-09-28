using System.ComponentModel.DataAnnotations;

namespace Third_ASP_EF_MVC.Application.Dtos.HrDtos
{

    public class JobDto 
    {
        public int Id { get; set; }
        public string UID { get; set; }
        public string Name { get; set; }
    }
    public class CreateJobDto
    {
        public string Name { get; set; }
    }
    public class UpdateJobDto : JobDto
    {
     
    }

}
