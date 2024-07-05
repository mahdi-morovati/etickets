using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers;

public class ActorsController(IActorsService  service) : Controller
{
    // GET
    public async Task<IActionResult> Index()
    {
        var data = await service.GetAll();
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
    public Task<IActionResult> Create([Bind("FullName,ProfilePictureUrl,Bio")]Actor actor)
    {
        if (!ModelState.IsValid)
        {
            return Task.FromResult<IActionResult>(View(actor));
        }
        service.Add(actor);
        return Task.FromResult<IActionResult>(Redirect(nameof(Index)));
    }
}