using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace stars_in_a_box;
public class StarsController : Controller
{
    private readonly DatabaseConnection _connection;

    public StarsController(DatabaseConnection connection)
    {
        _connection = connection;
    }
    // 
    // GET: /Stars/
    public async Task<IActionResult> Index()
    {
        return _connection.Stars != null ?
        View(await _connection.Stars.ToListAsync()) :
        Problem("Entity set 'stars-in-a-box.Stars'  is null.");
    }
    // 
    // GET: /Stars/Details/id
    public async Task<IActionResult> Details(int? id)
    {
        var star = await _connection.Stars.FindAsync(id);
        if (star == null) 
        {
            return NotFound();
        }
        return View(star);
    }
}
