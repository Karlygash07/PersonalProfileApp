namespace PersonalProfileApp.Models;

public class StudentProject
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<string> Technologies { get; set; } = new();
    public string RepositoryUrl { get; set; } = string.Empty;
}
