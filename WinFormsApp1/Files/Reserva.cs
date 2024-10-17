using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Files
{
    public class Reserva
    {
        public int Id { get; set; }
        public string Usuario { get; set; } 
        public string Libro { get; set; }    
        public string FechaDeReserva { get; set; }
        public string FechaDeRetorno { get; set; }

        public Reserva(int id, string usuario, string libro, string fechaDeReserva, string fechaDeRetorno)
        {
            Id = id;
            Usuario = usuario;
            Libro = libro;
            FechaDeReserva = fechaDeReserva;
            FechaDeRetorno = fechaDeRetorno;
        }
    }
}
