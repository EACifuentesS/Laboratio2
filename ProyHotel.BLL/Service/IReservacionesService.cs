using ProyHotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyHotel.BLL.Service
{
    public interface IReservacionesService
    {
        Task<bool> Insertar(Reservaciones modelo);
        Task<bool> Actualizar(Reservaciones modelo);
        Task<bool> Eliminar(int id);
        Task<Reservaciones> Obtener(int id);
        Task<IQueryable<Reservaciones>> ObtenerTodos();
        Task<Reservaciones> ObterPorNombre(string nombreReservacion);
    }
}
