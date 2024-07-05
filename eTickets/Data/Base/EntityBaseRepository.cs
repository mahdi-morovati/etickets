using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace eTickets.Data.Base;

public class EntityBaseRepository<T>(AppDbContext context) : IEntityBaseRepository<T>
    where T : class, IEntityBase, new()
{
    public async Task<IEnumerable<T>> GetAllAsync() => await context.Set<T>().ToListAsync();
    
    public async Task<T> GetByIdAsync(int id)
    {
        var result = await context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
        return result;
    }

    public async Task AddAsync(T entity)
    {
        await context.Set<T>().AddAsync(entity);
        await context.SaveChangesAsync();
    }

    public async Task UpdateAsync(int id, T entity)
    {
        EntityEntry entityEntry =  context.Entry<T>(entity);
        entityEntry.State = EntityState.Modified;

        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var entity =  await context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
        EntityEntry entityEntry =  context.Entry<T>(entity);
        entityEntry.State = EntityState.Deleted;
        
        await context.SaveChangesAsync();
    }
    
}