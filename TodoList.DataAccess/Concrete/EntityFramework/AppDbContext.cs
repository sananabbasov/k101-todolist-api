using System;
using Microsoft.EntityFrameworkCore;
using TodoList.Entities.Concrete;

namespace TodoList.DataAccess.Concrete.EntityFramework
{
	public class AppDbContext : DbContext
	{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=127.0.0.1,1433;Database=K101TodoList; User Id=SA; Password=Ehmed123; TrustServerCertificate=True;");
        }
        public DbSet<TaskList> TaskLists { get; set; }
    }
}

