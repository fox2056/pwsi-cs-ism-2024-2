using projektMVC.DataContext;
using projektMVC.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<CoreStudentsContext>(options => options
.UseLazyLoadingProxies()
.UseSqlServer(builder.Configuration.GetConnectionString("StudentContext")));




var app = builder.Build();

var context = app.Services.CreateScope().ServiceProvider.GetRequiredService<CoreStudentsContext>();
context.Database.EnsureCreated();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
