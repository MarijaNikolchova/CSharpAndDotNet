using Microsoft.EntityFrameworkCore;
using MyFirstMVC.Data;

var builder = WebApplication.CreateBuilder(args);
//Welcome to my first Mvc
// Add services to the container.
builder.Services.AddControllersWithViews();

// Connect to database
builder.Services.AddDbContext<FirstContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
