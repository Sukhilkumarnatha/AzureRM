using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq; // For .Any() method
using MyPortfolio.Models; // Adjust namespace as needed
using MyPortfolio.Data;
public class HomeController : Controller
{
    private readonly WorkExperienceRepository _repository; // Define the repository

    // Constructor to initialize the repository
    public HomeController()
    {
        _repository = new WorkExperienceRepository(); // Initialize repository
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }

    public IActionResult WorkExperience()
    {
        return Index();
    }

    public IActionResult Contact()
    {
        return View();
    }
}