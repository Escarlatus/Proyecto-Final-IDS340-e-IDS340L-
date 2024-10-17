using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Forms._3
{
    public partial class Reservas : Form
    {
        private string connectionString = "Data Source=C:\\Users\\Asus\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Files\\Prueba.db";

        public Reservas()
        {
            InitializeComponent();
            LoadDataReserva();
        }

        // Cargar los datos existentes de Reservas en el DataGridView
        private void LoadDataReserva()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT Id, Usuario, Libro, [Fecha de reserva], [Fecha de retorno] FROM Reservas";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                // Asegúrate de que la columna "Id" esté visible
                if (dataGridView1.Columns["Id"] != null)
                {
                    dataGridView1.Columns["Id"].Visible = true; // Si estaba oculta, mostrarla
                }
            }
        }

        // Obtener el título del libro por su ID
        private string ObtenerTituloLibro(int idLibro)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT Titulo FROM Libros WHERE Id = @IdLibro";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IdLibro", idLibro);

                var resultado = cmd.ExecuteScalar();
                return resultado != null ? resultado.ToString() : "";
            }
        }

        // Obtener el nombre completo del usuario por su ID
        private string ObtenerNombreUsuario(int idUsuario)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT Nombre, Apellido FROM Usuarios WHERE Id = @IdUsuario";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return $"{reader["Nombre"]} {reader["Apellido"]}";
                    }
                }
            }
            return "";
        }

        // Evento del botón "Agregar" para crear una nueva reserva
        private void AgregarReservaButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar los valores ingresados antes de procesar la reserva
                if (!int.TryParse(IdUsuarioReservaBox.Text, out int idUsuario) || !int.TryParse(IdLibroReservaBox.Text, out int idLibro))
                {
                    MessageBox.Show("Por favor, ingresa un ID válido para el usuario y el libro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtener los nombres y títulos asociados
                string nombreUsuario = ObtenerNombreUsuario(idUsuario);
                string tituloLibro = ObtenerTituloLibro(idLibro);

                // Verificar si los resultados son válidos
                if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(tituloLibro))
                {
                    MessageBox.Show("Usuario o libro no encontrado. Verifica los IDs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Generar ID aleatorio de 8 dígitos para la reserva
                int idReserva = GenerarIdAleatorio();

                // Insertar la nueva reserva en la base de datos
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string sql = "INSERT INTO Reservas (Id, Usuario, Libro, [Fecha de reserva], [Fecha de retorno]) VALUES (@Id, @Usuario, @Libro, @FechaReserva, @FechaRetorno)";
                    SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Id", idReserva); // Insertamos el ID generado
                    cmd.Parameters.AddWithValue("@Usuario", nombreUsuario);
                    cmd.Parameters.AddWithValue("@Libro", tituloLibro);
                    cmd.Parameters.AddWithValue("@FechaReserva", dateTimePickerReserva1.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@FechaRetorno", dateTimePickerReserva2.Value.ToString("yyyy-MM-dd"));

                    cmd.ExecuteNonQuery();
                }

                // Mostrar mensaje de éxito
                MessageBox.Show($"Reserva agregada exitosamente con ID: {idReserva}");
                LoadDataReserva();  // Recargar los datos en el DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la reserva: " + ex.Message);
            }
        }

        // Evento del botón "Eliminar" para eliminar la reserva seleccionada
        private void EliminarReservaButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells["Id"].Value != null)
            {
                // Obtener el ID de la reserva seleccionada
                if (int.TryParse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString(), out int idReserva))
                {
                    // Confirmar la eliminación
                    DialogResult result = MessageBox.Show($"¿Estás seguro de que deseas eliminar la reserva con ID: {idReserva}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                        {
                            conn.Open();
                            string sql = "DELETE FROM Reservas WHERE Id = @IdReserva";
                            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                            cmd.Parameters.AddWithValue("@IdReserva", idReserva);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Reserva eliminada correctamente.");
                            }
                            else
                            {
                                MessageBox.Show("No se encontró la reserva a eliminar.");
                            }
                        }

                        LoadDataReserva();  // Recargar los datos en el DataGridView
                    }
                }
                else
                {
                    MessageBox.Show("El valor del ID no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una reserva para eliminar.");
            }
        }

        // Evento del botón "Inicio" para volver al menú principal
        private void InicioReservaButton_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Reservas_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private int GenerarIdAleatorio()
        {
            Random random = new Random();
            int idAleatorio;

            // Asegura que el ID tenga exactamente 8 dígitos y no esté duplicado
            do
            {
                idAleatorio = random.Next(10000000, 99999999); // Generar número aleatorio de 8 dígitos
            } while (IdReservaExiste(idAleatorio)); // Verifica si el ID ya existe en la base de datos

            return idAleatorio;
        }

        // Método para verificar si el ID de reserva ya existe en la base de datos
        private bool IdReservaExiste(int idReserva)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM Reservas WHERE Id = @IdReserva";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IdReserva", idReserva);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0; // Retorna true si ya existe, false si no existe
            }
        }



    }
}

