using System;
using System.Linq.Expressions;
using TodoList.Core.Entities.Abstract;

namespace TodoList.Core.DataAccess
{
	public interface IRepositoryBase<TEntity>
		where TEntity : class, IEntity, new()
    {
		void Add(TEntity entity);
		void Update(TEntity entity);
		void Delete(TEntity entity);
		TEntity Get(Expression<Func<TEntity, bool>> filter);
		IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null);
	}
}

