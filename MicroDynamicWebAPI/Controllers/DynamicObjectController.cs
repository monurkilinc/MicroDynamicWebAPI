using MicroDynamicWebAPI.Application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Dynamic;
using DynamicObject = MicroDynamicWebAPI.Domain.Entities.DynamicObject;

namespace MicroDynamicWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DynamicObjectController : ControllerBase
    {
        //Dependency Injection
        private readonly IDynamicObjectService _objectService;

        public DynamicObjectController(IDynamicObjectService objectService)
        {
            _objectService = objectService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DynamicObject>>> GetAllObjects()
        {
            var dynamicObjects = await _objectService.GetAllObjects();

            return Ok(dynamicObjects);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<DynamicObject>> GetObjectById(int id)
        {
            var dynamicObject = await _objectService.GetObjectById(id);
            if (dynamicObject is null)
            {
                return NotFound("Dynamic Object not found.");
            }

            return Ok(dynamicObject);
        }
        [HttpPost]
        public async Task<ActionResult<List<DynamicObject>>> AddObject(DynamicObject dynamicObject)
        {
            var addObject = await _objectService.AddObject(dynamicObject);
            return CreatedAtAction(nameof(GetObjectById), new { id = addObject.Id }, addObject);

        }
        [HttpPut]
        public async Task<ActionResult<List<DynamicObject>>> UpdateObject(int id, DynamicObject updateObject)
        {
            if (id != updateObject.Id)
            {
                return BadRequest("Id mismatch.");
            }

            var updatedObject = await _objectService.UpdateObject(updateObject);
            if (updatedObject is null)
            {
                return NotFound("Dynamic Object not found.");
            }

            return Ok(updatedObject);
        }

        [HttpDelete]
        public async Task<ActionResult<List<DynamicObject>>> DeleteObject(int id)
        {
            var deletedObject = await _objectService.DeleteObject(id);
            if (deletedObject is null)
            {
                return NotFound("Dynamic Object not found.");
            }

            return Ok(deletedObject);
        }
    }
}
