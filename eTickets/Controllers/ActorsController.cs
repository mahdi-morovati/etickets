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
}