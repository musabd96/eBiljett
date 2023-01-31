using System.ComponentModel.DataAnnotations;

namespace eBiljett.Models
{
    public class Cinema
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "Cinema Logo")]
        public string Logo { get; set; }
        [Display(Name = "Cinema Name")]
        public string Name { get; set; }
        [Display(Name = "Cinema Description")]
        public string Description { get; set; }


        public List<Movie> Movies { get; set; }
    }
}
