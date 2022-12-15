using EduCopter.Persistency.DataBase.Domain;
using EduCopter.Persistency.DataBase.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EduCopter.Persistency.DataBase.Repository.Sessions
{
    public abstract class EntityRepositorySession<EF> : IEntityRepositorySession<EF> where EF : EFEntity, new()
    {
        protected readonly EduCopterContext _context;
        protected abstract DbSet<EF> Table { get; }

        private bool disposedValue;

        public EntityRepositorySession(EduCopterContext context)
        {
            _context = context;
        }

        public virtual async Task Delete(Guid id)
        {
            if (id == Guid.Empty)
                throw new ArgumentNullException(nameof(id));

            var e = await Get(id);

            if (e == null)
                throw new ArgumentOutOfRangeException($"Could not find entity in table {typeof(EF)} with id {id}");

            Table.Remove(new EF());
            await _context.SaveChangesAsync();
        }

        public virtual async Task<EF> Get(Guid id)
        {
            if (id == Guid.Empty)
                throw new ArgumentNullException(nameof(id));

            var entity = await Table.FirstOrDefaultAsync(x => x.Id == id);

            return entity;
        }

        public virtual async Task<List<EF>> GetAll()
        {
            var entities = await Table.ToListAsync();

            return entities;
        }

        public virtual async Task<EF> SaveOrUpdate(EF entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            if (entity.Id == Guid.Empty)
            {
                entity.Id = Guid.NewGuid();
                await Table.AddAsync(new EF());
            }
            else
            {
                Table.Update(new EF());
            }

            await _context.SaveChangesAsync();

            return entity;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~EntityRepositorySession()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
