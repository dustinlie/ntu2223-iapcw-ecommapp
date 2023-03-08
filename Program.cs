using iapCoursework2.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();
app.MapRazorPages();

app.Run();

var Configuration = builder.Configuration; 
builder.Services.AddDbContext<AppDataContext>(options => options.UseSqlite(Configuration.GetConnectionString("Default")));