using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {

        [Key]
        public int Id { get; set; }


        [Display(Name = "Actor")]
        [Required(ErrorMessage = "Picture is required")]
        public string? ProfilePictureURL { get; set; }


        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is required")]
        public string? FullName { get; set; }


        [Display(Name = "Biography")]
        [Required(ErrorMessage = "A description is required")]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "Minimum 5 characters is required")]
        public string? Biography { get; set; }


        // Relationships
        public List<Actor_Movie>? Actors_Movies { get; set; }
    }
}
