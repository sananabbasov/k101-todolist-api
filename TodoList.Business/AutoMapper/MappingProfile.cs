using System;
using AutoMapper;
using TodoList.Entities.Concrete;
using TodoList.Entities.DTOs;

namespace TodoList.Business.AutoMapper
{
	public class MappingProfile :Profile 
	{
		public MappingProfile()
		{
			CreateMap<TaskList, TaskAddDTO>().ReverseMap();
            CreateMap<TaskList, TaskListDTO>().ReverseMap();
		}
	}
}

