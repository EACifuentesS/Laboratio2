using Microsoft.EntityFrameworkCore;
using ProyHotel.DAL.DataContext;
using ProyHotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyHotel.DAL.Repositorio
{
    public class ReservaRepository : IGenericRepository<Reservaciones>
    {
        private readonly HotelContext _dbcontext;

        public ReservaRepository(HotelContext context)
        {
            _dbcontext = context;
        }

        public async Task<bool> Actualizar(Reservaciones modelo)
        {
            _dbcontext.Reservaciones.Update(modelo);
            await _dbcontext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
           Reservaciones modelo = _dbcontext.Reservaciones.First(c => c.IdReservacion == id);
            _dbcontext.Reservaciones.Remove(modelo);
            await _dbcontext.SaveChangesAsync();
            return true;
        }

        public Task<bool> Eliminar(Reservaciones modelo)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Insertar(Reservaciones modelo)
        {
            _dbcontext.Reservaciones.Add(modelo);
            await _dbcontext.SaveChangesAsync();
            return true;
        }

        public async Task<Reservaciones> Obtener(int id)
        {
            return await _dbcontext.Reservaciones.FindAsync(id);
        }

        public async Task<IQueryable<Reservaciones>> ObtenerTodos()
        {
            IQueryable<Reservaciones> queryReservacionesSQL = _dbcontext.Reservaciones;
            return queryReservacionesSQL;
        }
    }
}
