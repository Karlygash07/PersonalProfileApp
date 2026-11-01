namespace PersonalProfileApp.Models;

public class StudentProfile
{
    public string FullName { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string Initials { get; set; } = string.Empty;
    public string University { get; set; } = string.Empty;
    public string Specialty { get; set; } = string.Empty;
    public string Group { get; set; } = string.Empty;
    public string ShortBio { get; set; } = string.Empty;
    public string Biography { get; set; } = string.Empty;
    public string EducationDetails { get; set; } = string.Empty;
    public List<string> Skills { get; set; } = new();
    public string Email { get; set; } = string.Empty;
    public string GitHubUrl { get; set; } = string.Empty;
    public List<StudentProject> Projects { get; set; } = new();
}
