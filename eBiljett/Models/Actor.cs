using System.ComponentModel.DataAnnotations;

namespace eBiljett.Models
{
    public class Actor
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "Profile Picture URL")]      
        public string ProfilePictureURL { get; set; }
        public string fullName { get; set; }
        [Display(Name = "Full Name")]
        public string Bio { get; set; }
        [Display(Name = "Biography")]
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
