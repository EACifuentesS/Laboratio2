using System;
using System.Collections.Generic;

namespace ProyHotel.Models
{
    public partial class Reservaciones
    {
        public int IdReservacion { get; set; }
        public string Nombre { get; set; } = null!;
        public int Telefono { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string TipoHabitacion { get; set; } = null!;
        public int CantidadAdultos { get; set; }
        public int? CantidadNinos { get; set; }
        public decimal CostoTotal { get; set; }
    }
}
