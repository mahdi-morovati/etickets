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

    public async Task<Actor> UpdateAsync(int id, Actor newActor)
    {
        context.Update(newActor);
        await context.SaveChangesAsync();
        return newActor;
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }
}