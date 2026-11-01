using Microsoft.AspNetCore.Mvc;
using PersonalProfileApp.Data;

namespace PersonalProfileApp.Controllers;

public class InfoController : Controller
{
    public IActionResult Index()
    {
        var profile = StudentProfileData.Create();
        return View(profile);
    }

    public IActionResult About()
    {
        var profile = StudentProfileData.Create();
        return View(profile);
    }

    public IActionResult Portfolio()
    {
        var profile = StudentProfileData.Create();
        return View(profile);
    }
}
