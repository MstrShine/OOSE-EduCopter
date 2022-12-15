using EduCopter.Domain;
using EduCopter.Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EduCopter.API.Controllers
{
    /// <summary>
    /// Base controller class for creating simple CRUD controller, that can be overriden
    /// </summary>
    public abstract class AbstractEntityController<E> : ControllerBase where E : Entity, new()
    {
        protected readonly IEntityLogic<E> _logic;

        public AbstractEntityController(IEntityLogic<E> logic)
        {
            _logic = logic;
        }

        [HttpGet]
        public virtual async Task<IActionResult> GetAll()
        {
            var e = await _logic.GetAll();

            return Ok(e);
        }

        [HttpGet("{id}")]
        public virtual async Task<IActionResult> Get(Guid id)
        {
            var entity = await _logic.Get(id);

            return Ok(entity);
        }

        [HttpPost]
        public virtual async Task<IActionResult> Post(E entity)
        {
            entity = await _logic.SaveOrUpdate(entity);

            return Ok(entity);
        }

        [HttpPut("{id}")]
        public virtual async Task<IActionResult> Put(Guid id, E entity)
        {
            entity = await _logic.SaveOrUpdate(entity);

            return Ok(entity);
        }

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete(Guid id)
        {
            await _logic.Delete(id);

            return Ok();
        }
    }
}
