using System.Collections.Generic;
using MyPortfolio.Models;

public class WorkExperienceRepository
{
    public List<WorkExperience> GetAllWorkExperiences()
    {
        // Return a list of work experiences
        return new List<WorkExperience>
        {
            new WorkExperience { Id = 1, Title = "Developer", Company = "Company A", StartDate = "Oct, 2017", EndDate = "July 2021", Description = "Developed web applications." },
            new WorkExperience { Id = 2, Title = "Software Developer", Company = "Company B", StartDate = "July 2021", EndDate = "Dec 2021", Description = "Developed web applications." },
            
            // Add more experiences
        };
    }

    public WorkExperience GetWorkExperienceById(int id)
    {
        // Return work experience by ID
        return new WorkExperience { Id = id, Title = "Developer", Company = "Company A", StartDate = "2020-01-01", EndDate = "2021-01-01", Description = "Developed web applications." };
    }
}
