using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data;


public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // ActorMovie
        modelBuilder.Entity<ActorMovie>().HasKey(am => new
        {
            am.ActorId,
            am.MovieId
        });

        // Movie side. One to Many
        modelBuilder.Entity<ActorMovie>().HasOne(m => m.Movie).WithMany(am => am.ActorMovies)
            .HasForeignKey(m => m.MovieId);
        
        // Actor side. One to Many
        modelBuilder.Entity<ActorMovie>().HasOne(m => m.Actor).WithMany(am => am.ActorMovies)
            .HasForeignKey(m => m.ActorId);
        
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Actor> Actors { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<ActorMovie> ActorMovies { get; set; }
    public DbSet<Cinema> Cinemas { get; set; }
    public DbSet<Producer> Producers { get; set; }
    
} 