using System;
using AutoMapper;
using TodoList.Business.Abstract;
using TodoList.DataAccess.Abstract;
using TodoList.DataAccess.Concrete.EntityFramework;
using TodoList.Entities.Concrete;
using TodoList.Entities.DTOs;

namespace TodoList.Business.Concrete
{
    public class TaskListManager : ITaskListService
    {
        private readonly ITaskListDal _taskListDal;
        private readonly IMapper _mapper;
        public TaskListManager(ITaskListDal taskListDal, IMapper mapper)
        {
            _taskListDal = taskListDal;
            _mapper = mapper;
        }

        public void AddTodoList(TaskAddDTO addTask)
        {
            var mapper = _mapper.Map<TaskList>(addTask);
            _taskListDal.Add(mapper);
        }

        public List<TaskListDTO> GetAllTasks()
        {
            var tasks = _taskListDal.GetAll();
            var mapper = _mapper.Map<List<TaskListDTO>>(tasks);

            return mapper;
        }
    }
}

