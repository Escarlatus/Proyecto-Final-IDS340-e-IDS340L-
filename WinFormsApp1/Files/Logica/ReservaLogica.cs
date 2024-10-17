using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Files.Logica
{
    public class ReservaLogica
    {
        private string connectionString = "Data Source=C:C:\\Users\\Asus\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Files\\Prueba.db";

        // Método para obtener el nombre completo del usuario desde la tabla Usuarios
        public string ObtenerNombreUsuario(int idUsuario)
        {
            string nombreCompleto = "";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT Nombre, Apellido FROM Usuarios WHERE Id = @IdUsuario";
                SQLiteCommand command = new SQLiteCommand(sql, conn);
                command.Parameters.AddWithValue("@IdUsuario", idUsuario);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string nombre = reader.GetString(0);
                        string apellido = reader.GetString(1);
                        nombreCompleto = $"{nombre} {apellido}";  // Combina Nombre y Apellido
                    }
                }
            }

            return nombreCompleto;
        }

        // Método para obtener el título del libro desde la tabla Libros
        public string ObtenerTituloLibro(int idLibro)
        {
            string tituloLibro = "";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT Titulo FROM Libros WHERE Id = @IdLibro";
                SQLiteCommand command = new SQLiteCommand(sql, conn);
                command.Parameters.AddWithValue("@IdLibro", idLibro);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        tituloLibro = reader.GetString(0);
                    }
                }
            }

            return tituloLibro;
        }

        // Método para insertar una nueva reserva en la tabla Reservas
        public void InsertarReserva(Reserva reserva)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO Reservas (Usuario, Libro, [Fecha de reserva], [Fecha de retorno]) VALUES (@Usuario, @Libro, @FechaReserva, @FechaRetorno)";
                SQLiteCommand command = new SQLiteCommand(sql, conn);
                command.Parameters.AddWithValue("@Usuario", reserva.Usuario);
                command.Parameters.AddWithValue("@Libro", reserva.Libro);
                command.Parameters.AddWithValue("@FechaReserva", reserva.FechaDeReserva);
                command.Parameters.AddWithValue("@FechaRetorno", reserva.FechaDeRetorno);

                command.ExecuteNonQuery();  // Ejecuta la inserción en la base de datos
            }
        }
    }
}
