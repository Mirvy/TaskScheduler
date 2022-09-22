using Microsoft.EntityFrameworkCore;
using TaskScheduler.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DataContext>(opts => {
    opts.UseSqlServer(builder.Configuration["ConnectionStrings:SchedulerConnection"]);
});

builder.Services.AddScoped<IEmployeeRepository, EFEmployeeRepository>();
builder.Services.AddScoped<IProjectRepository, EFProjectRepository>();
builder.Services.AddScoped<ITaskRepository, EFTaskRepository>();
builder.Services.AddScoped<ITeamRepository, EFTeamRepository>();

var app = builder.Build();

app.MapDefaultControllerRoute();

app.Run();
