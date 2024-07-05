using System.ComponentModel.DataAnnotations;

namespace eTickets.Models;

public class Actor
{
    [Key] public int Id { get; set; }

    [Display(Name = "Profile Picture Url")]
    public string ProfilePictureUrl { get; set; }
    
    [Display(Name = "Full Name")]
    public string FullName { get; set; }
    
    [Display(Name = "Biography")]
    public string Bio { get; set; }
    
    // RelationShips
    public List<ActorMovie> ActorMovies { get; set; }
}