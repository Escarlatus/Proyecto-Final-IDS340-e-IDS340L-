using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Forms;

namespace WinFormsApp1.Files.Logica
{
    public class UsuarioLogica
    {
        private string connectionString;

        public UsuarioLogica(string connectionString)
        {
            this.connectionString = connectionString;

        }

        public void InsertarUsuario(Usuario usuario)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString)) 
            { 
                connection.Open();
                string query = "INSERT INTO Usuarios (Id, Nombre, Apellido, Email, Telefono) VALUES (@id, @nombre, @apellido, @email, @telefono)";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", usuario.Id);
                    command.Parameters.AddWithValue("@nombre", usuario.Nombre);
                    command.Parameters.AddWithValue("@apellido", usuario.Apellido);
                    command.Parameters.AddWithValue("@email", usuario.Email);
                    command.Parameters.AddWithValue("@telefono", usuario.Telefono);


                    try
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("Usuario agregado exitosamente.");
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al insertar Usuario: " + ex.Message);
                    }


                }



            }



        }

        public List<Usuario> ObtenerTodosLosUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Usuarios";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Asignamos correctamente el Id
                            Usuario usuario = new Usuario(
                                Convert.ToInt32(reader["Id"]),
                                reader["Nombre"].ToString(),
                                reader["Apellido"].ToString(),
                                reader["Email"].ToString(),
                                reader["Telefono"].ToString()

                            );
                            

                            usuarios.Add(usuario);
                        }
                    }
                }
            }

            return usuarios;
        }


        public void EditarUsuario(Usuario usuario)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"
            UPDATE Usuarios
            SET 
                Id = @id,
                Nombre = @nombre,
                Apellido = @apellido,
                Email = @email,
                Telefono = @telefono";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", usuario.Id);
                    command.Parameters.AddWithValue("@nombre", usuario.Nombre);
                    command.Parameters.AddWithValue("@apellido", usuario.Apellido);
                    command.Parameters.AddWithValue("@email", usuario.Email);
                    command.Parameters.AddWithValue("@telefono", usuario.Telefono);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void EliminarUsuario(int id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Usuarios WHERE Id = @id";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }











    }
}
