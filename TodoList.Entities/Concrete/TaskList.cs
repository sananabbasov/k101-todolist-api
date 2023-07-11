using System;
using TodoList.Core.Entities.Abstract;

namespace TodoList.Entities.Concrete
{
	public class TaskList : IEntity
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public DateTime DeadLine { get; set; }
		public bool IsActive { get; set; }
		public bool IsDeleted { get; set; }
	}
}

