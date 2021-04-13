using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SSSM.Common.Infrastructure;
using SSSM.Common.Models;
using System.Threading.Tasks;

namespace SSSM.Common.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext context;
        private readonly StudentRepository students;

        public StudentController(AppDbContext context)
        {
            this.context = context;
            this.students = new StudentRepository(context);
        }


        // GET: Student
        public async Task<IActionResult> Index()
        {
            return View(await students.GetList());
        }

        // GET: StudentModels/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id is null)
            {
                return NotFound();
            }
            var model = await students.GetById(id.Value);
            if (model is null)
            {
                return NotFound();
            }

            return View(model);
        }

        public IActionResult Create()
        {
            ViewData["repository"] = students;
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Gender,IDNumber,InnerCode,BirthDate,EnrollmentDate,PhotoPath,IsDeleted,Id")] StudentModel studentModel)
        {
            if (ModelState.IsValid)
            {
                context.Add(studentModel);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(studentModel);
        }

        // GET: Student/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id is null)
            {
                return NotFound();
            }

            var s = await students.GetById(id.Value);
            if (s is null)
            {
                return NotFound();
            }
            ViewData["repository"] = students;
            var model = s;

            return View(model);
        }

        // POST: Student/Edit/5
        [HttpPost]
        public async Task<IActionResult> Edit(long id, [Bind("Name,Gender,IDNumber,InnerCode,BirthDate,EnrollmentDate,PhotoPath,IsDeleted,Id")] StudentModel model)
        {
            if (id != model.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    context.Update(model);
                    await context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!students.Exists(model.Id))
                    {
                        return NotFound();
                    }
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: Student/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id != null)
            {
                return NotFound();
            }

            var model = await students.GetById(id.Value);
            if (model is null)
            {
                return NotFound();
            }

            return View(model);
        }

        // POST: Student/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var model = await students.GetById(id);
            await students.Delete(model);
            return RedirectToAction(nameof(Index));
        }
    }
}
