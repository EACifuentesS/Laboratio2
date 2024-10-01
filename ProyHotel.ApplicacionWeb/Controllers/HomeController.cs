using Microsoft.AspNetCore.Mvc;
using ProyHotel.ApplicacionWeb.Models;
using ProyHotel.ApplicacionWeb.Models.ViewModels;
using ProyHotel.BLL.Service;
using ProyHotel.Models;
using System.Diagnostics;
using System.Globalization;

namespace ProyHotel.ApplicacionWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IReservacionesService _reservacionesService;

        public HomeController(IReservacionesService reservacionesService)
        {
            _reservacionesService = reservacionesService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Lista()
        {
            IQueryable<Reservaciones> queryReservacionesSQL = await _reservacionesService.ObtenerTodos();

            List<VMReservaciones> lista = queryReservacionesSQL 
                                                .Select(c => new VMReservaciones()
                                                {
                                                    IdReservacion = c.IdReservacion,
                                                    Nombre = c.Nombre,
                                                    Telefono = c.Telefono,
                                                    FechaInicio = c.FechaInicio.ToString("dd/MM/yyyy"),
                                                    FechaFin = c.FechaFin.ToString("dd/MM/yyyy"),
                                                    TipoHabitacion = c.TipoHabitacion,
                                                    CantidadAdultos = c.CantidadAdultos,
                                                    CantidadNinos = c.CantidadNinos,
                                                    CostoTotal = c.CostoTotal,
                                                })
                                                .ToList();

            return StatusCode(StatusCodes.Status200OK, lista);
        }

        [HttpPost]
        public async Task<IActionResult> Insertar([FromBody] VMReservaciones modelo)
        {
           Reservaciones NuevoModelo = new Reservaciones()
           {
               Nombre = modelo.Nombre,
               Telefono = modelo.Telefono,
               FechaInicio = DateTime.ParseExact(modelo.FechaInicio,"dd/MM/yyyy",CultureInfo.CreateSpecificCulture("es-GT")),
               FechaFin = DateTime.ParseExact(modelo.FechaFin, "dd/MM/yyyy", CultureInfo.CreateSpecificCulture("es-GT")),
               TipoHabitacion = modelo.TipoHabitacion,
               CantidadAdultos = modelo.CantidadAdultos,
               CantidadNinos= modelo.CantidadNinos,
               CostoTotal= modelo.CostoTotal,  
           };

            bool respuesta = await _reservacionesService.Insertar(NuevoModelo);

            return StatusCode(StatusCodes.Status200OK, new {valor = respuesta});
        }

        [HttpPut]
        public async Task<IActionResult> Actualizar([FromBody] VMReservaciones modelo)
        {
            Reservaciones NuevoModelo = new Reservaciones()
            {
                IdReservacion = modelo.IdReservacion,
                Nombre = modelo.Nombre,
                Telefono = modelo.Telefono,
                FechaInicio = DateTime.ParseExact(modelo.FechaInicio, "dd/MM/yyyy", CultureInfo.CreateSpecificCulture("es-GT")),
                FechaFin = DateTime.ParseExact(modelo.FechaFin, "dd/MM/yyyy", CultureInfo.CreateSpecificCulture("es-GT")),
                TipoHabitacion = modelo.TipoHabitacion,
                CantidadAdultos = modelo.CantidadAdultos,
                CantidadNinos = modelo.CantidadNinos,
                CostoTotal = modelo.CostoTotal,
            };

            bool respuesta = await _reservacionesService.Actualizar(NuevoModelo);

            return StatusCode(StatusCodes.Status200OK, new { valor = respuesta });
        }

        [HttpDelete]
        public async Task<IActionResult> Eliminar(int id)
        {
           
            bool respuesta = await _reservacionesService.Eliminar(id);

            return StatusCode(StatusCodes.Status200OK, new { valor = respuesta });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
