using Microsoft.AspNetCore.Mvc;
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
    public IActionResult Index()
    {
        return View();
    }
    // 
    // GET: /Stars/Details/id
    public async Task<IActionResult> Details(int id)
    {
        var star = await _connection.Stars.FindAsync(id);
        if (star == null) 
        {
            return NotFound();
        }
        return View(star);
    }
}
