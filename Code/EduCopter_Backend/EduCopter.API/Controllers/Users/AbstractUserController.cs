using EduCopter.Domain.Users;
using EduCopter.Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EduCopter.API.Controllers.Users
{
    public class AbstractUserController<E> : ControllerBase where E : UserInfo
    {
        protected readonly IEntityLogic<E> _logic;

        private readonly IPasswordHandler _passwordHandler;

        public AbstractUserController(IEntityLogic<E> logic, IPasswordHandler passwordHandler)
        {
            _logic = logic;
            _passwordHandler = passwordHandler;
        }

        [HttpGet]
        public virtual async Task<IActionResult> GetAll()
        {
            List<E> eList = null;
            try
            {
                eList = await _logic.GetAll();
                foreach(var e  in eList)
                {
                    e.Password = null;
                }
            }
            catch (Exception ex)
            {
                BadRequest(ex);
            }

            return Ok(eList);
        }

        [HttpGet("{id}")]
        public virtual async Task<IActionResult> Get(Guid id)
        {
            E e = null;
            try
            {
                e = await _logic.Get(id);
                e.Password = null;
            }
            catch (Exception ex)
            {
                BadRequest(ex);
            }

            return Ok(e);
        }

        [HttpPost]
        public virtual async Task<IActionResult> Post(E entity)
        {
            E e = null;
            try
            {
                var newPassword = await _passwordHandler.CreatePassword(entity.Password);
                entity.Password = newPassword;
                e = await _logic.SaveOrUpdate(entity);
            }
            catch (Exception ex)
            {
                BadRequest(ex);
            }

            e.Password = null;

            return Ok(e);
        }

        [HttpPut("{id}")]
        public virtual async Task<IActionResult> Put(Guid id, E entity)
        {
            E e = null;
            try
            {
                var newPassword = await _passwordHandler.CreatePassword(entity.Password);
                entity.Password = newPassword;
                e = await _logic.SaveOrUpdate(entity);
            }
            catch (Exception ex)
            {
                BadRequest(ex);
            }

            e.Password = null;

            return Ok(e);
        }

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                await _logic.Delete(id);
            }
            catch (Exception ex)
            {
                BadRequest(ex);
            }

            return Ok();
        }
    }
}
