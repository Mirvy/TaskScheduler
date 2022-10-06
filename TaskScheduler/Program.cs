using Microsoft.EntityFrameworkCore;
using DutyBusinessLayer;
using DutyDbLibrary;
using DutyDatabaseLayer;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

//TODO - Move DbContext configuration out of the UI layer
//     - setup up a valid connection string in appsettings.json
//     - add a helper project with a singleton configuration builder
//       for the DutyContext
builder.Services.AddDbContext<DutyContext>(opts => {
    opts.UseSqlServer(builder.Configuration["ConnectionStrings:DutySchedulerConnection"]); 
});

builder.Services.AddScoped<IEmployeeRepository, EFEmployeeRepository>();
builder.Services.AddScoped<IProjectRepository, EFProjectRepository>();
builder.Services.AddScoped<IDutyRepository, EFDutyRepository>();
builder.Services.AddScoped<ITeamRepository, EFTeamRepository>();

builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IProjectService, ProjectService>();
builder.Services.AddScoped<IDutyService, DutyService>();
builder.Services.AddScoped<ITeamService, TeamService>();


var app = builder.Build();
app.UseStaticFiles();
app.MapDefaultControllerRoute();
app.MapControllerRoute("forms", "{controller=Home}/{action=Index}/{id?}");

app.Run();
