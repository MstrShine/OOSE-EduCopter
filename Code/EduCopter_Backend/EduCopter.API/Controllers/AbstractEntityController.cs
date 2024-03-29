﻿using EduCopter.Domain;
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
            List<E> eList = null;
            try
            {
                eList = await _logic.GetAll();
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
                e = await _logic.SaveOrUpdate(entity);
            }
            catch (Exception ex)
            {
                BadRequest(ex);
            }

            return Ok(e);
        }

        [HttpPut("{id}")]
        public virtual async Task<IActionResult> Put(Guid id, E entity)
        {
            E e = null;
            try
            {
                e = await _logic.SaveOrUpdate(entity);
            }
            catch (Exception ex)
            {
                BadRequest(ex);
            }

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
