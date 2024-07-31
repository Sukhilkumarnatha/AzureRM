namespace MyPortfolio.Models
{
    public class WorkExperience
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }

        public string[] Projects { get; set; }
        public string[] ProjectDescription{ get; set; }

    }
}
