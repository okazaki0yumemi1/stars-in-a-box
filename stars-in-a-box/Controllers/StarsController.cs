using Microsoft.AspNetCore.Mvc;
namespace stars_in_a_box;
public class StarsController : Controller
{
    // 
    // GET: /Stars/
    public IActionResult Index()
    {
        return View();
    }
    // 
    // GET: /Stars/Welcome/ 
    public string Welcome()
    {
        return "This is the Welcome action method...";
    }
}
