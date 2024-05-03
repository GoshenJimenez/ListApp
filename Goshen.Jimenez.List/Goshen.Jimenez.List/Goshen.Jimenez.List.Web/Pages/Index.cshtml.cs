using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace Goshen.Jimenez.List.Web.Pages
{
    public class Index : PageModel
    {
        private readonly ILogger<Index> _logger;

        public Index(ILogger<Index> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public List<Student>? Students { get; set; }

        public void OnGet(string? sortBy = "Name")
        {
            Students = new List<Student>()
            {
                new Student()
                {
                    Name = "Ajani Goldmane",
                    EmailAddress = "agoldmane@mailinator.com",
                    Course = "BSIS",
                    DateOfBirth = DateTime.Parse("02/07/1996")
                },
                new Student()
                {
                    Name = "Liliana Vess",
                    EmailAddress = "lvess@mailinator.com",
                    Course = "BSHRM",
                    DateOfBirth = DateTime.Parse("06/28/2005")
                },
                new Student()
                {
                    Name = "Nissa Revane",
                    EmailAddress = "nrevane@mailinator.com",
                    Course = "BSCRIM",
                    DateOfBirth = DateTime.Parse("09/03/2004")
                },
                new Student()
                {
                    Name = "Elspeth Tirel",
                    EmailAddress = "etirel@mailinator.com",
                    Course = "BSCA",
                    DateOfBirth = DateTime.Parse("11/13/1985")
                },
                new Student()
                {
                    Name = "Jace Beleren",
                    EmailAddress = "jbeleren@mailinator.com",
                    Course = "BSED",
                    DateOfBirth = DateTime.Parse("02/09/2015")
                },
                new Student()
                {
                    Name = "Chandra Nalaar",
                    EmailAddress = "cnalaar@mailinator.com",
                    Course = "BSTM",
                    DateOfBirth = DateTime.Parse("04/23/2002")
                }
            };

            if(sortBy.ToLower() == "name") {
                Students = Students.OrderBy(a => a.Name).ToList();
            }
            else if(sortBy.ToLower() == "emailaddress") {
                Students = Students.OrderBy(a => a.EmailAddress).ToList();
            }
            else if (sortBy.ToLower() == "course")
            {
                Students = Students.OrderBy(a => a.Course).ToList();
            }
            else if (sortBy.ToLower() == "dateofbirth")
            {
                Students = Students.OrderBy(a => a.DateOfBirth).ToList();
            }


        }


        public class Student
        {
            public string? Name { get; set; }
            public string? EmailAddress { get; set; }
            public string? Course { get; set; }
            public DateTime? DateOfBirth { get; set; }
        }
    }
}
