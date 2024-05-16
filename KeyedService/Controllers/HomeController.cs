using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using KeyedService.Models;
using KeyedService.Services;

namespace KeyedService.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index([FromKeyedServices("LocalService")] IStorageService storageService)
    {
        storageService.UploadData("Fake Data");
        return View();
    }

    public IActionResult Privacy([FromKeyedServices("CloudService")] IStorageService storageService)
    {
        storageService.UploadData("Fake Data");
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
