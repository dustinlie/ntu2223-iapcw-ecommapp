using iapCoursework2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();

var Configuration = builder.Configuration;
builder.Services.AddDbContext<AppDataContext>(options => options.UseSqlite(Configuration.GetConnectionString("Default")));

builder.Services.AddIdentity<AppUser, IdentityRole>()
.AddDefaultTokenProviders()
.AddDefaultUI()
.AddEntityFrameworkStores<AppDataContext>();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication(); 
app.UseAuthorization();

app.MapRazorPages();

app.Run();