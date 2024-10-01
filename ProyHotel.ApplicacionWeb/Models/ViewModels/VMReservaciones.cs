namespace ProyHotel.ApplicacionWeb.Models.ViewModels
{
    public class VMReservaciones
    {
        public int IdReservacion { get; set; }
        public string Nombre { get; set; } = null!;
        public int Telefono { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public string TipoHabitacion { get; set; } = null!;
        public int CantidadAdultos { get; set; }
        public int? CantidadNinos { get; set; }
        public decimal CostoTotal { get; set; }
    }
}
