using Microsoft.EntityFrameworkCore;
using DutyBusinessLayer;
using DutyDbLibrary;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

//TODO - Move DbContext configuration out of the UI layer
//     - setup up a valid connection string in appsettings.json
//     - add a helper project with a singleton configuration builder
//       for the DutyContext
builder.Services.AddDbContext<DutyContext>(opts => {
    opts.UseSqlServer(builder.Configuration["ConnectionStrings:DutySchedulerConnection"]); 
});

builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IProjectService, ProjectService>();
builder.Services.AddScoped<IDutyService, DutyService>();
builder.Services.AddScoped<ITeamService, TeamService>();


var app = builder.Build();
app.UseStaticFiles();
app.MapDefaultControllerRoute();

app.Run();
