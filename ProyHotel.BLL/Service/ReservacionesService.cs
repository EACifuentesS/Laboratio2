using ProyHotel.DAL.Repositorio;
using ProyHotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyHotel.BLL.Service
{
    public class ReservacionesService : IReservacionesService
    {
        private readonly IGenericRepository<Reservaciones> _reservacionesRepo;

        public ReservacionesService(IGenericRepository<Reservaciones> reservacionRepo)
        {
            _reservacionesRepo = reservacionRepo;

        }
        public async Task<bool> Actualizar(Reservaciones modelo)
        {
            return await _reservacionesRepo.Actualizar(modelo); 
        }

        public async Task<bool> Eliminar(int id)
        {
            return await _reservacionesRepo.Eliminar(id);
        }

        public async Task<bool> Insertar(Reservaciones modelo)
        {
            return await _reservacionesRepo.Insertar(modelo);
        }

        public async Task<Reservaciones> Obtener(int id)
        {
            return await _reservacionesRepo.Obtener(id);
        }
        public async Task<Reservaciones> ObterPorNombre(string nombreReservacion)
        {
            IQueryable<Reservaciones> queryReservacionesSQL = await _reservacionesRepo.ObtenerTodos();
            Reservaciones reservaciones = queryReservacionesSQL.Where(c => c.Nombre == nombreReservacion).FirstOrDefault();
            return reservaciones;
        }

        public async Task<IQueryable<Reservaciones>> ObtenerTodos()
        {
            return await _reservacionesRepo.ObtenerTodos();
        }

        
    }
}
