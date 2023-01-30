﻿using System.ComponentModel.DataAnnotations;

namespace eBiljett.Models
{
    public class Producer
    {
        [Key]
        public int id { get; set; }

        public string profilePictureURL { get; set; }
        public string fullName { get; set; }
        public string Bio { get; set; }

        public List<Movie> Movies { get; set;}
    }
}