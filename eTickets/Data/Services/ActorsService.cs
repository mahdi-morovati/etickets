using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services;

public class ActorsService(AppDbContext context) : IActorsService
{
    public async Task<IEnumerable<Actor>> GetAllAsync()
    {
        var result = await context.Actors.ToListAsync();
        return result;
    }
    
    public async Task<Actor> GetByIdAsync(int id)
    {
        var result = await context.Actors.FirstOrDefaultAsync(n => n.Id == id);
        return result;
    }

    public async Task AddAsync(Actor actor)
    {
        await context.Actors.AddAsync(actor);
        await context.SaveChangesAsync();
    }

    public Actor Update(int id, Actor newActor)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }
}