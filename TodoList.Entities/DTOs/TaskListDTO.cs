using System;
namespace TodoList.Entities.DTOs
{
	public class TaskListDTO
	{
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DeadLine { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}

