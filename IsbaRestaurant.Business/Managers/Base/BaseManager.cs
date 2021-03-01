using IsbaRestaurant.Business.Services.Base;
using IsbaRestaurant.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IsbaRestaurant.Business.Managers.Base
{
    public class BaseManager<TEntity> : IBaseService<TEntity> where TEntity : class, IEntity, new()
    {
        private bool disposedValue;

        public void Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Add(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public void AddOrUpdate(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void AddOrUpdate(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public BindingList<TEntity> BindingList()
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public bool Exist(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public bool HasChanges()
        {
            throw new NotImplementedException();
        }

        public void Load(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> Select(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TEntity>> selector, params Expression<Func<TEntity, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TResult> Select<TResult>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TResult>> selector, params Expression<Func<TEntity, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: yönetilen durumu (yönetilen nesneleri) atın
                }

                // TODO: yönetilmeyen kaynakları (yönetilmeyen nesneleri) serbest bırakın ve sonlandırıcıyı geçersiz kılın
                // TODO: büyük alanları null olarak ayarlayın
                disposedValue = true;
            }
        }

        // // TODO: sonlandırıcıyı yalnızca 'Dispose(bool disposing)' içinde yönetilmeyen kaynakları serbest bırakacak kod varsa geçersiz kılın
        // ~BaseManager()
        // {
        //     // Bu kodu değiştirmeyin. Temizleme kodunu 'Dispose(bool disposing)' metodunun içine yerleştirin.
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Bu kodu değiştirmeyin. Temizleme kodunu 'Dispose(bool disposing)' metodunun içine yerleştirin.
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
