
namespace PersonalProfileApp.Models
{
    public class ProfileViewModel
    {
        public string Name { get; set; } = "";
        public string Group { get; set; } = "";
        public string University { get; set; } = "";
        public string Program { get; set; } = "";
        public string Bio { get; set; } = "";

        public List<string> Skills { get; set; } = new();

        public List<ProjectItem> Projects { get; set; } = new();
    }

    public class ProjectItem
    {
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public string Technology { get; set; } = "";
    }
}
