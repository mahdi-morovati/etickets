using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers;

public class ActorsController(IActorsService  service) : Controller
{
    // GET
    public async Task<IActionResult> Index()
    {
        var data = await service.GetAllAsync();
        return View(data);
    }

    
    /// <summary>
    /// Display Create Actor vierw
    /// </summary>
    /// <returns>Redirect to Actoes list</returns>
    [Route("Actors/Create")]
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create([Bind("FullName,ProfilePictureUrl,Bio")]Actor actor)
    {
        if (!ModelState.IsValid)
        {
            return await Task.FromResult<IActionResult>(View(actor));
        }
        await service.AddAsync(actor);
        return await Task.FromResult<IActionResult>(Redirect(nameof(Index)));
    }
    
    // Get: Actors/Details/1
    public async Task<IActionResult> Details(int id)
    {
        var actorDetails = await service.GetByIdAsync(id);
        if (actorDetails == null)
        {
            return View("Empty");
        }

        return View(actorDetails);
    }
}