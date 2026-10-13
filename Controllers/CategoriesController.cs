using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RaceDay.Api.Data;
using RaceDay.Api.Models;

namespace RaceDay.Api.Controllers;

[ApiController]
[Route("api")]
public class CategoriesController : ControllerBase
{
    private readonly RaceDayContext _db;
    public CategoriesController(RaceDayContext db) => _db = db;

    [HttpGet("events/{eventId:int}/categories")]
    public async Task<IActionResult> GetForEvent(int eventId) => Ok(await _db.EventCategories.Where(c => c.EventID == eventId).ToListAsync());

    [HttpPost("events/{eventId:int}/categories")]
    public async Task<IActionResult> Create(int eventId, EventCategory category)
    {
        if (HttpContext.Session.GetString("Role") != "Organiser") return StatusCode(403, "Organiser role required.");
        if (!await _db.Events.AnyAsync(e => e.EventID == eventId && e.OrganiserID == HttpContext.Session.GetInt32("UserID"))) return NotFound("Event not found for this organiser.");
        category.EventID = eventId; _db.EventCategories.Add(category); await _db.SaveChangesAsync();
        return Created($"/api/events/{eventId}/categories", category);
    }
}
