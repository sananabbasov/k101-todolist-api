using System;
using TodoList.Core.DataAccess;
using TodoList.Entities.Concrete;
namespace TodoList.DataAccess.Abstract
{
	public interface ITaskListDal : IRepositoryBase<TaskList>
	{
	}
}

