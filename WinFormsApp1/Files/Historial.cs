using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Files
{
    public class Historial
    {
        public int Id { get; set; }
        public int ReservaId { get; set; }
        public string Usuario { get; set; }
        public string Libro { get; set; }
        public DateTime FechaReserva { get; set; }
        public DateTime FechaRetorno { get; set; }
        public DateTime? FechaDevolucionReal { get; set; }  // Puede ser null si no se ha devuelto
        public string EntregadaATiempo { get; set; }  // Solo tendra 2 valores "Sí" o "No"

        public Historial(int reservaId, string usuario, string libro, DateTime fechaReserva, DateTime fechaRetorno)
        {
            ReservaId = reservaId;
            Usuario = usuario;
            Libro = libro;
            FechaReserva = fechaReserva;
            FechaRetorno = fechaRetorno;
            EntregadaATiempo = "No";  // Por defecto, la entrega no es a tiempo hasta que se registre la devolución
        }
    }
}
