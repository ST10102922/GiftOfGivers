using Microsoft.AspNetCore.Mvc;
using GiftOfGivers.Models;

public class DonationController : Controller
{
    private readonly ApplicationDbContext _context;

    public DonationController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult Donate(Donation donation)
    {
        _context.Donations.Add(donation);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
}
