using Microsoft.AspNetCore.Mvc;
using GiftOfGivers.Models;

public class IncidentController : Controller
{
    private readonly ApplicationDbContext _context;

    public IncidentController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult Report(Incident incident)
    {
        _context.Incidents.Add(incident);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
}
