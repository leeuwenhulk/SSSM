using Microsoft.EntityFrameworkCore;
using SSSM.Common.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSSM.Common.Infrastructure
{
    public class StudentRepository
    {
        private AppDbContext context;

        public StudentRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<List<StudentModel>> GetList()
        {
            return await context.Students.Where(x => !x.IsDeleted).ToListAsync();
        }

        public async Task<StudentModel> GetById(long id)
        {
            return await context.Students
                .Include(x => x.Major)
                .Include(x => x.SchoolClass)
                .Include(x => x.Courses).ThenInclude(y => y.Major)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<int> Delete(StudentModel model)
        {
            model.IsDeleted = true;
            return await context.SaveChangesAsync();
        }

        public async Task<int> DeleteCompletely(StudentModel model)
        {
            context.Students.Remove(model);
            return await context.SaveChangesAsync();
        }

        public bool Exists(long id)
        {
            return context.Students.Any(e => e.Id == id);
        }

        public IEnumerable<MajorModel> Majors => context.Majors;
        public IEnumerable<SchoolGradeModel> SchoolGrades => context.schoolGrades;
        public IEnumerable<SchoolClassModel> SchoolClasses => context.schoolClasses;
    }
}
