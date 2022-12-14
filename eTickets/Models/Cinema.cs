using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "")]
        public string? LogoURL { get; set; }

        [Display(Name = "Cinema")]
        public string? Name { get; set; }

        [Display(Name = "Description")]
        public string? Description { get; set; }

        // Relationships
        public List<Movie>? Movies { get; set; }
    }
}
