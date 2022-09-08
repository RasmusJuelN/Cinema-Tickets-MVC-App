using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "Actor")]
        public string? ProfilePictureURL { get; set; }

        [Display(Name = "Name")]
        public string? FullName { get; set; }

        [Display(Name = "Biography")]
        public string? Biography { get; set; }


        // Relationships
        public List<Actor_Movie>? Actors_Movies { get; set; }
    }
}
