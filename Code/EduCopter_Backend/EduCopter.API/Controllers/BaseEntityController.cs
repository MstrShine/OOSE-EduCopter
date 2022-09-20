using EduCopter.Domain;
using Microsoft.AspNetCore.Mvc;

namespace EduCopter.API.Controllers
{
    /// <summary>
    /// Base controller class for creating simple CRUD controller, that can be overriden
    /// </summary>
    public abstract class BaseEntityController<T> : ControllerBase where T : Entity
    {
        [HttpGet]
        public virtual async Task<List<T>> GetAll()
        {
            return null;
        }

        [HttpGet("{id}")]
        public virtual async Task<T> Get(Guid id)
        {
            return null;
        }

        [HttpPost]
        public virtual async Task<T> Post(T entity)
        {
            return null;
        }

        [HttpPut("{id}")]
        public virtual async Task<T> Put(Guid id, T entity) 
        {
            return null;
        }

        [HttpDelete("{id}")]
        public virtual async Task Delete(Guid id) 
        { 
            
        }
    }
}
