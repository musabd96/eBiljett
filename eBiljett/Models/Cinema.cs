using System.ComponentModel.DataAnnotations;

namespace eBiljett.Models
{
    public class Cinema
    {
        [Key]
        public int id { get; set; }

        public string Logo { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }


        public List<Movie> Movies { get; set; }
    }
}
