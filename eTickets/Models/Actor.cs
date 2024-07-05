using System.ComponentModel.DataAnnotations;

namespace eTickets.Models;

public class Actor
{
    [Key] public int Id { get; set; }

    [Display(Name = "Profile Picture Url")]
    [Required(ErrorMessage = "Profile Picture Url is required")]
    public string ProfilePictureUrl { get; set; }
    
    [Display(Name = "Full Name")]
    [Required(ErrorMessage = "Full Name is required")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 characters")]
    public string FullName { get; set; }
    
    [Display(Name = "Biography")]
    [Required(ErrorMessage = "Biography is required")]
    public string Bio { get; set; }
    
    // RelationShips
    //  new List<ActorMovie>(); for nullable this attribute on create Actor
    public List<ActorMovie> ActorMovies { get; set; } = new List<ActorMovie>();
    

}