using MicroDynamicWebAPI.Datas;
using MicroDynamicWebAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Dynamic;
using DynamicObject = MicroDynamicWebAPI.Entities.DynamicObject;

namespace MicroDynamicWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DynamicObjectController : ControllerBase
    {
        //Dependency Injection
        private readonly DataContext _context;

        public DynamicObjectController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllObjects()
        {
            var dynamicObjects = await _context.DynamicObjects.ToListAsync();

            return Ok(dynamicObjects);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Entities.DynamicObject>> GetObjectById(int id)
        {
            var dynamicObject = await _context.DynamicObjects.FindAsync(id);
            if(dynamicObject is null)
            {
                return NotFound("Dynamic Object not found.");
            }

            return Ok(dynamicObject);
        }
        [HttpPost]
        public async Task<ActionResult<List<DynamicObject>>> AddObject(DynamicObject dynamicObject)
        {
            _context.DynamicObjects.Add(dynamicObject);
            await _context.SaveChangesAsync();

            return Ok(await _context.DynamicObjects.ToListAsync());
        }
        [HttpPut]
        public async Task<ActionResult<List<DynamicObject>>> UpdateObject(DynamicObject updateObject)
        {
            var dbObject = await _context.DynamicObjects.FindAsync(updateObject.Id);
            if (dbObject is null)
            {
                return NotFound("Dynamic Object not found.");
            }
            dbObject.ObjectType = updateObject.ObjectType;
            dbObject.Data = updateObject.Data;
            dbObject.ParentId = updateObject.ParentId;

            return Ok(await _context.DynamicObjects.ToListAsync());
        }

        [HttpDelete]
        public async Task<ActionResult<List<DynamicObject>>> DeleteObject(int id)
        {
            var dbObject = await _context.DynamicObjects.FindAsync(id);
            if (dbObject is null)
            {
                return NotFound("Dynamic Object not found.");
            }
            _context.DynamicObjects.Remove(dbObject);
            await _context.SaveChangesAsync();

            return Ok(await _context.DynamicObjects.ToListAsync());
        }
    }
}
