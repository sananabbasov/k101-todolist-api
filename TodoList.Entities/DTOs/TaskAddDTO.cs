using System;
namespace TodoList.Entities.DTOs
{
	public class TaskAddDTO
	{
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DeadLine { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}

