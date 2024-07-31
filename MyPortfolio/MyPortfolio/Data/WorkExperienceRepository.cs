using System.Collections.Generic;
using System.Linq;
using MyPortfolio.Models;

namespace MyPortfolio.Data
{
    public class WorkExperienceRepository
    {
        private List<WorkExperience> workExperiences = new List<WorkExperience>
        {
            new WorkExperience {
                Id = 1,
                Title = "Senior Analyst",
                Company = "HCL Technologies",
                Location = "Bangalore, Karnataka, India",
                StartDate = "Oct, 2017",
                EndDate = "July 2021",
                Description = "Developed web applications." ,
                Projects = new string[] {"Health Care Service Corporation", "Citi Bank" },
                ProjectDescription = new string[] {"HCSC Project Description", "Citi Project Description"}
            },
            new WorkExperience {
                Id = 2,
                Title = "Software Developer",
                Company = "Diebold Nixdorf",
                Location = "Hyderabad, Telangana, India",
                StartDate = "July 2021",
                EndDate = "Dec 2021",
                Description = "Developed web applications.",
                Projects = new string[] {"Diebold Nixdorf"},
                ProjectDescription = new string[] {"Diebold Project Description here"}
            }
            // Add more experiences here
        };


        public List<WorkExperience> GetAllWorkExperiences()
        {
            // Return a list of work experiences from the in-memory list
            return workExperiences;
        }

        public WorkExperience GetWorkExperienceById(int id)
        {
            var workExperience = workExperiences.FirstOrDefault(we => we.Id == id);
            if (workExperience == null)
            {
                throw new InvalidOperationException($"Work experience with ID {id} not found.");
            }
            return workExperience;
        }
    }
}
