using eTickets.Data.Services;
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
}