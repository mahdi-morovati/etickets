using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eTickets.Data.Enums;

namespace eTickets.Models;

public class Movie
{
    [Key] public int Id { get; set; }

    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public string ImageUrl { get; set; }
    
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    // Enum
    public MovieCategory MovieCategory { get; set; } 
    
    // Relationships
    public List<ActorMovie> ActorMovies { get; set; }

    // Cinema
    // Movie belongs to one Cinema 
    public int CinemaId { get; set; }
    [ForeignKey("CinemaId")]
    public Cinema Cinema { get; set; }
    
    // Producer
    // Movie belongs to one Producer 
    public int ProducerId { get; set; }
    [ForeignKey("ProducerId")]
    public Producer Producer { get; set; }
}