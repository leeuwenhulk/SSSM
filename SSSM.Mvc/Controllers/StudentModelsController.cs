using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SSSM.Common.Infrastructure;
using SSSM.Common.Models;

namespace SSSM.Common.Controllers
{
    public class StudentModelsController : Controller
    {
        private readonly AppDbContext _context;

        public StudentModelsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: StudentModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.Students.ToListAsync());
        }

        // GET: StudentModels/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentModel = await _context.Students
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studentModel == null)
            {
                return NotFound();
            }

            return View(studentModel);
        }

        // GET: StudentModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StudentModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Gender,IDNumber,InnerCode,BirthDate,EnrollmentDate,PhotoPath,IsDeleted,Id")] StudentModel studentModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studentModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(studentModel);
        }

        // GET: StudentModels/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentModel = await _context.Students.FindAsync(id);
            if (studentModel == null)
            {
                return NotFound();
            }
            return View(studentModel);
        }

        // POST: StudentModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Name,Gender,IDNumber,InnerCode,BirthDate,EnrollmentDate,PhotoPath,IsDeleted,Id")] StudentModel studentModel)
        {
            if (id != studentModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studentModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentModelExists(studentModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(studentModel);
        }

        // GET: StudentModels/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentModel = await _context.Students
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studentModel == null)
            {
                return NotFound();
            }

            return View(studentModel);
        }

        // POST: StudentModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var studentModel = await _context.Students.FindAsync(id);
            _context.Students.Remove(studentModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentModelExists(long id)
        {
            return _context.Students.Any(e => e.Id == id);
        }
    }
}
