using EduCopter.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Persistency.DataBase.Domain
{
    public abstract class EFEntity<E, EF> where E : Entity, new() where EF : EFEntity<E, EF>
    {
        public Guid Id { get; set; }

        private E EntityReference = null;

        /// <summary>
        /// Transforms the EF entity into a normal Entity. If the object has done this once already, it returns a reference to the previous version.
        /// </summary>
        /// <returns></returns>
        public E ToDomain()
        {
            if (EntityReference != null)
                return EntityReference;
            EntityReference = new E();
            _ToDomain(ref EntityReference);
            FillIdForDomainObject(EntityReference);
            return EntityReference;
        }

        public EF FromDomain(E entity)
        {
            if (entity is null)
                return null;
            EF obj = FromDomain(entity);
            obj.FillIdForEFObject(entity);
            return obj;
        }

        protected abstract void _ToDomain(ref E entity);
        protected abstract EF _FromDomain(E entity);

        protected void FillIdForEFObject(E entity)
        {
            Id = entity.Id;
        }

        protected void FillIdForDomainObject(E entity)
        {
            entity.Id = Id;
        }
    }
}
