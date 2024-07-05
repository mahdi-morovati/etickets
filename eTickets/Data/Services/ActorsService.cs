using eTickets.Data.Base;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services;


// old version
// public class ActorsService : EntityBaseRepository<Actor>, IActorsService
// {
//     public ActorsService(AppDbContext context): base(context) { }
// }
public class ActorsService(AppDbContext context) : EntityBaseRepository<Actor>(context), IActorsService;