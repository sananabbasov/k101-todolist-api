using AutoMapper;
using TodoList.Business.Abstract;
using TodoList.Business.AutoMapper;
using TodoList.Business.Concrete;
using TodoList.DataAccess.Abstract;
using TodoList.DataAccess.Concrete.EntityFramework;
using TodoList.Entities.Concrete;

var builder = WebApplication.CreateBuilder(args);

var corsRuls = "_corsRules";

// Add services to the container.
builder.Services.AddCors(o =>
{
    o.AddPolicy(corsRuls,
         p =>
         {
             p.AllowAnyHeader();
             p.AllowAnyMethod();
             p.AllowAnyOrigin();
         }
        );
});


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<ITaskListDal, EfTaskListDal>();
builder.Services.AddScoped<ITaskListService, TaskListManager>();

builder.Services.AddScoped<AppDbContext>();

var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MappingProfile());
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseCors(corsRuls);
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

