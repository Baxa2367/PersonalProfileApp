
using Microsoft.AspNetCore.Mvc;
using PersonalProfileApp.Models;

namespace PersonalProfileApp.Controllers
{
    public class InfoController : Controller
    {
        private ProfileViewModel GetProfile()
        {
            return new ProfileViewModel
            {
                Name = "Жұмағұл Бақберген",
                Group = "ИСК-242",
                University = "Абай атындағы ҚазҰПУ",
                Program = "Ақпараттық жүйелер",

                Bio = "Мен ақпараттық жүйелер мамандығы бойынша білім алып жүрген студентпін. Бағдарламалау, веб-технологиялар және цифрлық жобаларға қызығамын.",

                Skills = new List<string>
                {
                    "C#",
                    "HTML",
                    "CSS",
                    "JavaScript",
                    "Python",
                    "SQL",
                    "ASP.NET Core"
                },

                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "CyberGuard AI",
                        Description = "Киберқауіпсіздік сауаттылығын арттыруға арналған веб-платформа.",
                        Technology = "React, TypeScript, Supabase"
                    },
                    new ProjectItem
                    {
                        Title = "Student Hub",
                        Description = "Студенттерге арналған цифрлық платформа.",
                        Technology = "Web Development, Database"
                    },
                    new ProjectItem
                    {
                        Title = "Digital Library",
                        Description = "Электрондық кітапхана жобасы.",
                        Technology = "React, Supabase"
                    }
                }
            };
        }

        public IActionResult Index()
        {
            return View(GetProfile());
        }

        public IActionResult About()
        {
            return View(GetProfile());
        }

        public IActionResult Portfolio()
        {
            return View(GetProfile());
        }
    }
}
