using System.ComponentModel.DataAnnotations;
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
}