using System;
using TodoList.Entities.DTOs;

namespace TodoList.Business.Abstract
{
	public interface ITaskListService
	{
		void AddTodoList(TaskAddDTO addTask);
		List<TaskListDTO> GetAllTasks();
	}
}

