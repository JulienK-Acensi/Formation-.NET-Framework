using Microsoft.EntityFrameworkCore;
using Tours_OpenData.Parkings_Indigo.Infrastructures.Contexts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add Database
builder.Services.AddDbContext<ParkingContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Tours_OpenDataDB"), sqloption =>
    {

    });
});

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
