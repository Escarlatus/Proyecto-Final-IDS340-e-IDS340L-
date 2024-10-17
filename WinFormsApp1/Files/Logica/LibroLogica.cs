using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using WinFormsApp1.Files;

namespace WinFormsApp1.Files.Logica
{
    public class LibroLogica
    {
        private string connectionString;

        public LibroLogica(string connectionString) 
        {
            this.connectionString = connectionString;
        
        }

        public void InsertarLibro(Libro libro)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Libros (ISBN, Titulo, Autor, Editorial, Año_de_publicacion, Genero, Numero_de_copias) VALUES (@isbn, @titulo, @autor, @editorial, @año_de_publicacion, @genero, @numero_de_copias)";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@isbn", libro.ISBN);
                    command.Parameters.AddWithValue("@titulo", libro.Titulo);
                    command.Parameters.AddWithValue("@autor", libro.Autor);
                    command.Parameters.AddWithValue("@editorial", libro.Editorial);
                    command.Parameters.AddWithValue("@año_de_publicacion", libro.Año_de_publicacion);
                    command.Parameters.AddWithValue("@genero", libro.Genero);
                    command.Parameters.AddWithValue("@numero_de_copias", libro.Numero_de_copias);

                    try
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("Libro agregado exitosamente.");
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al insertar Libro: " + ex.Message);
                    }


                }


            }
        }
        public List<Libro> ObtenerTodosLosLibros()
        {
            List<Libro> libros = new List<Libro>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Libros";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Asignamos correctamente el Id
                            Libro libro = new Libro(
                                reader["ISBN"].ToString(),
                                reader["Titulo"].ToString(),
                                reader["Autor"].ToString(),
                                reader["Editorial"].ToString(),
                                reader["Año_de_publicacion"].ToString(),
                                reader["Genero"].ToString(),
                                Convert.ToInt32(reader["Numero_de_copias"])
                            )
                            {
                                Id = Convert.ToInt32(reader["Id"]) // Asignar el ID del libro
                            };

                            libros.Add(libro);
                        }
                    }
                }
            }

            return libros;
        }
        public void EditarLibro(Libro libro)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"
            UPDATE Libros
            SET 
                ISBN = @isbn,
                Titulo = @titulo,
                Autor = @autor,
                Editorial = @editorial,
                Año_de_publicacion = @año_de_publicacion,
                Genero = @genero,
                Numero_de_copias = @numero_de_copias
            WHERE Id = @id";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", libro.Id);
                    command.Parameters.AddWithValue("@isbn", libro.ISBN);
                    command.Parameters.AddWithValue("@titulo", libro.Titulo);
                    command.Parameters.AddWithValue("@autor", libro.Autor);
                    command.Parameters.AddWithValue("@editorial", libro.Editorial);
                    command.Parameters.AddWithValue("@año_de_publicacion", libro.Año_de_publicacion);
                    command.Parameters.AddWithValue("@genero", libro.Genero);
                    command.Parameters.AddWithValue("@numero_de_copias", libro.Numero_de_copias);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void EliminarLibro(int id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Libros WHERE Id = @id";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
