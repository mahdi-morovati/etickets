using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers;

public class MoviesController(AppDbContext context) : Controller
{
    private readonly AppDbContext _context = context;
    // GET
    public async Task<IActionResult> Index()
    {
        var allMovies = await _context.Cinemas.ToListAsync();
        return View();
    }
}