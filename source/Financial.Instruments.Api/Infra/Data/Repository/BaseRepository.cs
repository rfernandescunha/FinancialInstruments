﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using Financial.Instruments.Api.Domain.Interfaces.IRepository;
using Financial.Instruments.Api.Infra.Data.Context;

namespace Financial.Instruments.Api.Infra.Data.Repository
{
    public class BaseRepository<T> : IBaseRepository<T>, IDisposable where T : class
    {

        private readonly FinancialContext _context;

        public BaseRepository(FinancialContext context)
        {
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            _context.ChangeTracker.AutoDetectChangesEnabled = true;
            _context.ChangeTracker.LazyLoadingEnabled = false;
        }

        public virtual async Task<T> Insert(T Objeto)
        {
            await _context.Set<T>().AddAsync(Objeto);
            await _context.SaveChangesAsync();

            return Objeto;
        }


        public virtual async Task<bool> Delete(int Id)
        {
            var item = await _context.Set<T>().FindAsync(Id);

            _context.Set<T>().Remove(item);

            await _context.SaveChangesAsync();

            return true;
        }

        public virtual async Task<T> Find(int Id)
        {

            return await _context.Set<T>().FindAsync(Id);
            
        }

        public virtual async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate = null)
        {

            _context.ChangeTracker.LazyLoadingEnabled = false;

            if (predicate != null)
            {
                return await _context.Set<T>().Where(predicate).AsNoTracking().ToListAsync();
            }
            else
            {
                return await _context.Set<T>().ToListAsync();
            } 

        }

        public virtual async Task<T> Update(T Objeto)
        {
            _context.Set<T>().Update(Objeto);
            await _context.SaveChangesAsync();

            return Objeto;
        }


        #region Disposed https://docs.microsoft.com/pt-br/dotnet/standard/garbage-collection/implementing-dispose
        // Flag: Has Dispose already been called?
        bool disposed = false;
        // Instantiate a SafeHandle instance.
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);



        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                handle.Dispose();
                // Free any other managed objects here.
                //
            }

            disposed = true;
        }
        #endregion

    }
}
