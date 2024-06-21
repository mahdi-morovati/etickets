namespace eTickets.Models;

public class ActorMovie
{
    // Foreign key
    public int MovieId { get; set; }
    // Relationship
    public Movie Movie { get; set; }
    
    public int ActorId { get; set; }
    // Relationship
    public Actor Actor { get; set; }
}