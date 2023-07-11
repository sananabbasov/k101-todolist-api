using System;
using TodoList.Core.DataAccess.EntitiyFramework;
using TodoList.DataAccess.Abstract;
using TodoList.Entities.Concrete;

namespace TodoList.DataAccess.Concrete.EntityFramework
{
	public class EfTaskListDal : EfRepositoryBase<TaskList,AppDbContext>, ITaskListDal
    {
		
	}
}

