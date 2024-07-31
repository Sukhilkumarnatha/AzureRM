using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Data;
using MyPortfolio.Models;

public class WorkExperienceController : Controller
{
    private readonly WorkExperienceRepository _repository;

    public WorkExperienceController()
    {
        _repository = new WorkExperienceRepository(); // Make sure repository is correctly instantiated
    }

    public IActionResult Index()
    {
        var experiences = _repository.GetAllWorkExperiences();
        if (experiences == null || !experiences.Any())
        {
            return View(new List<WorkExperience>()); // Pass an empty list if no data is available
        }
        return View(experiences);
    }

    public IActionResult Details(int id)
    {
        var experience = _repository.GetWorkExperienceById(id); // Ensure this method returns the correct object
        if (experience == null)
        {
            return NotFound();
        }
        return View(experience);
    }
}