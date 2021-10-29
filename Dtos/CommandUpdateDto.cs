using System.ComponentModel.DataAnnotations;

namespace restapi.Dtos
{
    public class CommandUpdateeDto
    {
        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }

        [Required]
        public string Line { get; set; }

        [Required]
        public string Platform {get ; set;}
    }
}