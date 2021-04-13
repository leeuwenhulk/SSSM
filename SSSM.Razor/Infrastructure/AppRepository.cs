using Microsoft.EntityFrameworkCore;
using SSSM.Common.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSSM.Razor.Infrastructure
{
    public class AppRepository
    {
        private AppDbContext context;

        public AppRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<List<T>> GetAll<T>() where T : BaseModel
        {
            return await context.Set<T>().ToListAsync();
        }

        public async Task<List<T>> GetNotDeleted<T>() where T : BaseModel, ISoftDeleted
        {
            return await context.Set<T>().Where(x => !x.IsDeleted).ToListAsync();
        }

        public async Task<T> GetById<T>(long id) where T : BaseModel
        {
            return await context.Set<T>().FindAsync(id);
        }

        public async Task<int> Delete<T>(T model) where T : BaseModel
        {
            context.Remove(model);
            return await context.SaveChangesAsync();
        }

        public async Task<int> SoftDelete<T>(T model) where T : BaseModel, ISoftDeleted
        {
            model.IsDeleted = true;
            context.Update(model);
            return await context.SaveChangesAsync();
        }

        public bool Exists<T>(long id) where T : BaseModel
        {
            return context.Set<T>().Any(e => e.Id == id);
        }

    }
}
