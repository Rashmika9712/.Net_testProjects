using System.ComponentModel.DataAnnotations;

namespace ProjectAPI
{
    public class Projects
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Name is required!")]
        public string Name { get; set; }
    }
}
