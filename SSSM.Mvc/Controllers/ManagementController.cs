using Microsoft.AspNetCore.Mvc;
using SSSM.Common.Infrastructure;
using SSSM.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSSM.Common.Controllers
{
    public class ManagementController : Controller
    {
        private readonly AppDbContext context;
        public ManagementController(AppDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult SchoolGrades()
        {
            return View(context.schoolGrades.ToList());
        }

        [HttpPost]
        public IActionResult SchoolGradesCreate(string gradename)
        {
            var name2 = gradename.Trim();
            if (string.IsNullOrEmpty(name2) || context.schoolGrades.Any(x => x.Name == name2))
            {
                return RedirectToAction(nameof(SchoolGrades));
            }

            context.Add(new SchoolGradeModel { Name = name2 });
            context.SaveChanges();
            return RedirectToAction(nameof(SchoolGrades));
        }

        public IActionResult SchoolGradesDelete(long id)
        {
            var schoolgrade = context.schoolGrades.Find(id);
            if (schoolgrade is null ||
                context.schoolClasses.Any(x => x.SchoolGrade.Name == schoolgrade.Name))
            {
                return RedirectToAction(nameof(SchoolGrades));
            }

            context.Remove(schoolgrade);
            context.SaveChanges();
            return RedirectToAction(nameof(SchoolGrades));
        }


        public IActionResult SchoolClasses()
        {
            ViewData["context"] = context;
            return View(context.schoolClasses.ToList());
        }

        [HttpPost]
        public IActionResult SchoolClassesCreate(string gradename, string classname)
        {
            var gname2 = gradename.Trim();
            var cname2 = classname.Trim();
            if (string.IsNullOrWhiteSpace(gname2) || string.IsNullOrWhiteSpace(cname2))
            {
                return RedirectToAction(nameof(SchoolClasses));
            }
            var schoolgrade = context.schoolGrades.FirstOrDefault(x => x.Name == gradename);
            if (schoolgrade is null)
            {
                return RedirectToAction(nameof(SchoolClasses));
            }
            if (context.schoolClasses.Any(x => x.SchoolGrade.Name == gname2 && x.Name == cname2))
            {
                return RedirectToAction(nameof(SchoolClasses));
            }

            context.Add(new SchoolClassModel { SchoolGrade = schoolgrade, Name = cname2 });
            context.SaveChanges();
            return RedirectToAction(nameof(SchoolClasses));
        }

        public IActionResult SchoolClassesDelete(long id)
        {
            var schoolclass = context.schoolClasses.Find(id);
            if (schoolclass is null ||
                context.Students.Any(x=>x.SchoolClass.Name == schoolclass.Name))
            {
                return RedirectToAction(nameof(SchoolClasses));
            }

            context.Remove(schoolclass);
            context.SaveChanges();
            return RedirectToAction(nameof(SchoolClasses));
        }
    

        public IActionResult Majors()
        {
            return View(context.Majors.ToList());
        }

        [HttpPost]
        public IActionResult MajorsCreate(string majorname)
        {
            var name2 = majorname.Trim();
            if (string.IsNullOrEmpty(name2) || context.Majors.Any(x => x.Name == name2))
            {
                return RedirectToAction(nameof(Majors));
            }

            context.Add(new MajorModel { Name = name2 });
            context.SaveChanges();
            return RedirectToAction(nameof(Majors));
        }

        public IActionResult MajorsDelete(long id)
        {
            var model = context.Majors.Find(id);
            if (model is null ||
                context.Courses.Any(x => x.Major.Name == model.Name))
            {
                return RedirectToAction(nameof(Majors));
            }

            context.Remove(model);
            context.SaveChanges();
            return RedirectToAction(nameof(SchoolGrades));
        }
    }
}
