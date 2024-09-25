using MicroDynamicWebAPI.Domain.Entities;

namespace MicroDynamicWebAPI.Application.Services
{
    public interface IDynamicObjectService
    {
        Task<IEnumerable<DynamicObject>> GetAllObjects();
        Task<DynamicObject> GetObjectById(int id);
        Task<DynamicObject> AddObject(DynamicObject entity);
        Task<DynamicObject> UpdateObject(DynamicObject entity);
        Task<DynamicObject> DeleteObject(int id);
    }
}
