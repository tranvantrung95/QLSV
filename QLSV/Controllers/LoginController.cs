using Microsoft.AspNetCore.Mvc;

namespace QLSV.Controllers;

public class LoginController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}