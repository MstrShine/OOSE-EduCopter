using EduCopter.Domain;
using EduCopter.Persistency.DataBase.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EduCopter.API.Controllers
{
    /// <summary>
    /// Base controller class for creating simple CRUD controller, that can be overriden
    /// </summary>
    public abstract class AbstractEntityController<E> : ControllerBase where E : Entity, new()
    {
        protected readonly IEntityRepository<E> _repository;

        public AbstractEntityController(IEntityRepository<E> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public virtual async Task<IActionResult> GetAll()
        {
            List<E> e;
            using (var session = _repository.CreateSession())
            {
                e = await session.GetAll();
            }

            return Ok();
        }

        [HttpGet("{id}")]
        public virtual async Task<IActionResult> Get(Guid id)
        {
            E entity;
            using (var session = _repository.CreateSession())
            {
                entity = await session.Get(id);
            }

            return Ok(entity);
        }

        [HttpPost]
        public virtual async Task<IActionResult> Post(E entity)
        {
            using (var session = _repository.CreateSession())
            {
                entity = await session.SaveOrUpdate(entity);
            }

            return Ok(entity);
        }

        [HttpPut("{id}")]
        public virtual async Task<IActionResult> Put(Guid id, E entity)
        {
            using (var session = _repository.CreateSession())
            {
                entity = await session.SaveOrUpdate(entity);
            }

            return Ok(entity);
        }

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete(Guid id)
        {
            using (var session = _repository.CreateSession())
            {
                await session.Delete(id);
            }

            return Ok();
        }
    }
}
