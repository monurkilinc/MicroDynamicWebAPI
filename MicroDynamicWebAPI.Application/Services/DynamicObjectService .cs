using MicroDynamicWebAPI.Domain.Entities;
using MicroDynamicWebAPI.Infrastructure.Datas;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MicroDynamicWebAPI.Application.Services
{
    public class DynamicObjectService : IDynamicObjectService
    {
        private readonly DataContext _context;

        public DynamicObjectService(DataContext context)
        {
            _context = context;
        }
        public async Task<DynamicObject> AddObject(DynamicObject entity)
        {
            _context.Set<DynamicObject>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<DynamicObject> UpdateObject(DynamicObject entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<DynamicObject> DeleteObject(int id)
        {
            var entity = await _context.Set<DynamicObject>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<DynamicObject>().Remove(entity);
                await _context.SaveChangesAsync();
            }
            return entity;
        }

        public async Task<IEnumerable<DynamicObject>> GetAllObjects()
        {
            return await _context.Set<DynamicObject>().ToListAsync();
        }

        public async Task<DynamicObject> GetObjectById(int id)
        {
            return await _context.Set<DynamicObject>().FindAsync(id);
        }
    }
}
