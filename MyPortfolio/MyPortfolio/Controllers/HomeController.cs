using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq; // For .Any() method
using MyPortfolio.Models; // Adjust namespace as needed

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
        var experiences = _repository.GetAllWorkExperiences(); // Retrieve data
        if (experiences == null || !experiences.Any())
        {
            return View(new List<WorkExperience>()); // Pass an empty list if no data is available
        }
        return View(experiences); // Pass the data to the view
    }

    public IActionResult Contact()
    {
        return View();
    }
}
