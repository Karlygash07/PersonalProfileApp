using PersonalProfileApp.Models;

namespace PersonalProfileApp.Data;

// Барлық жеке мәліметті осы жерден өзгертуге болады.
public static class StudentProfileData
{
    public static StudentProfile Create()
    {
        return new StudentProfile
        {
            FullName = "Қарлығаш",
            FirstName = "Қарлығаш",
            Initials = "Қ",
            University = "Абай атындағы университет",
            Specialty = "ИСК",
            Group = "ИСК242",
            ShortBio = "Абай атындағы университетте ИСК мамандығы бойынша білім алып жүрмін.",
            Biography = "Мен — Қарлығаш. ИСК242 тобының студентімін. Бұл шағын сайтта өзім туралы ақпарат пен оқу жобам жинақталған.",
            EducationDetails = "ИСК мамандығы · ИСК242 тобы",
            Skills = new List<string> { "C# негіздері", "HTML / CSS", "ASP.NET Core MVC" },
            Email = "karlygash_abdiyeva@mail.ru",
            GitHubUrl = "https://github.com/Karlygash07",
            Projects = new List<StudentProject>
            {
                new StudentProject
                {
                    Title = "Жеке визитка",
                    Description = "Өзім туралы қысқаша мәлімет пен байланыс ақпараты берілген үш беттік оқу сайты.",
                    Technologies = new List<string> { "C#", ".NET 8", "Razor", "CSS" },
                    RepositoryUrl = "https://github.com/Karlygash07/PersonalProfileApp"
                }
            }
        };
    }
}
