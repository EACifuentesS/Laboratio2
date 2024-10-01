using Microsoft.EntityFrameworkCore;
using ProyHotel.BLL.Service;
using ProyHotel.DAL.DataContext;
using ProyHotel.DAL.Repositorio;
using ProyHotel.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<HotelContext>(opciones =>
{
    opciones.UseSqlServer(builder.Configuration.GetConnectionString("cadenaSQL"));
});


builder.Services.AddScoped<IGenericRepository<Reservaciones>, ReservaRepository>();
builder.Services.AddScoped<IReservacionesService, ReservacionesService>();

var app = builder.Build();

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
