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
        public virtual async Task<List<E>> GetAll()
        {
            List<E> eList = null;
            try
            {
                eList = await _logic.GetAll();
            }
            catch (Exception ex)
            {
                HttpContext.Response.StatusCode = 500;
            }

            return eList;
        }

        [HttpGet("{id}")]
        public virtual async Task<E> Get(Guid id)
        {
            E e = null;
            try
            {
                e = await _logic.Get(id);
            }
            catch (Exception ex)
            {
                HttpContext.Response.StatusCode = 500;
            }

            return e;
        }

        [HttpPost]
        public virtual async Task<E> Post(E entity)
        {
            E e = null;
            try
            {
                e = await _logic.SaveOrUpdate(entity);
            }
            catch (Exception ex)
            {
                HttpContext.Response.StatusCode = 500;
            }

            return e;
        }

        [HttpPut("{id}")]
        public virtual async Task<E> Put(Guid id, E entity)
        {
            E e = null;
            try
            {
                e = await _logic.SaveOrUpdate(entity);
            }
            catch (Exception ex)
            {
                HttpContext.Response.StatusCode = 500;
            }

            return e;
        }

        [HttpDelete("{id}")]
        public virtual async Task Delete(Guid id)
        {
            try
            {
                await _logic.Delete(id);
            }
            catch (Exception ex)
            {
                HttpContext.Response.StatusCode = 500;
            }

            return;
        }
    }
}
