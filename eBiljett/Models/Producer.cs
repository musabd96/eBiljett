using System.ComponentModel.DataAnnotations;

namespace eBiljett.Models
{
    public class Producer
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "Profile Picture")]
        public string profilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        public string fullName { get; set; }

        [Display(Name = "Biography")]
        public string Bio { get; set; }

        public List<Movie> Movies { get; set;}
    }
}
