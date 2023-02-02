﻿using System.ComponentModel.DataAnnotations;

namespace eBiljett.Models
{
    public class Actor
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage ="Profile picture is required")] 
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage ="Full Name is required")]
        [StringLength(50, ErrorMessage = "Full Name must be between 3 and 50 chars")]
        public string fullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage ="Biography is required")]  
        public string Bio { get; set; }
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
