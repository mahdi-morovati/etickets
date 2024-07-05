using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services;

public class ActorsService(AppDbContext context) : IActorsService
{
    public async Task<IEnumerable<Actor>> GetAll()
    {
        var result = await context.Actors.ToListAsync();
        return result;
    }

    public Actor GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Add(Actor actor)
    {
        context.Actors.Add(actor);
        context.SaveChanges();
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