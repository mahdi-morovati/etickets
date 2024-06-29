using eTickets.Data;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers;

public class ActorsController(AppDbContext context) : Controller
{
    private readonly AppDbContext _context = context;

    // GET
    public IActionResult Index()
    {
        var data = _context.Actors.ToList();
        return View();
    }
}