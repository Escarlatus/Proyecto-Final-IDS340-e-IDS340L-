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
using WinFormsApp1.Files.Logica;
using WinFormsApp1.Files;


namespace WinFormsApp1.Forms._3
{
    public partial class Reservas : Form
    {
        private string connectionString = "Data Source=C:\\Users\\Asus\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Files\\Prueba.db";
        private HistorialLogica historialLogica;
        public Reservas()
        {
            InitializeComponent();
            LoadDataReserva();
            historialLogica = new HistorialLogica(connectionString);

            //Aqui agregamos los items del combo box
            BuscarReservaComboBox.Items.Add("Id");
            BuscarReservaComboBox.Items.Add("Usuario");
            BuscarReservaComboBox.Items.Add("Libro");
            BuscarReservaComboBox.Items.Add("Fecha de reserva");
            BuscarReservaComboBox.Items.Add("Fecha de retorno");

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

                // Asegúra de que la columna "Id" esté visible
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

                // Obtener el número de copias disponibles del libro
                int copiasDisponibles = ObtenerCopiasLibro(idLibro);

                if (copiasDisponibles > 0)
                {
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


                    // Aqui insertamos la reserva al historial
                    WinFormsApp1.Files.Historial nuevoHistorial = new Historial(idReserva, nombreUsuario, tituloLibro, dateTimePickerReserva1.Value, dateTimePickerReserva2.Value);
                    historialLogica.InsertarHistorial(nuevoHistorial);

                    // Actualizar el número de copias del libro
                    ActualizarCopiasLibro(idLibro, copiasDisponibles - 1);
                }
                else
                {

                    // Mostrar un mensaje de error si el libro no está disponible
                    MessageBox.Show("El libro no está disponible en este momento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la reserva: " + ex.Message);
            }
        }


        private int ObtenerCopiasLibro(int idLibro)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT Numero_de_copias FROM Libros WHERE Id = @IdLibro";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IdLibro", idLibro);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private void ActualizarCopiasLibro(int idLibro, int nuevasCopias)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "UPDATE Libros SET Numero_de_copias = @NuevasCopias WHERE Id = @IdLibro";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IdLibro", idLibro);
                cmd.Parameters.AddWithValue("@NuevasCopias", nuevasCopias);
                cmd.ExecuteNonQuery();
            }
        }

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

        private void RegistrarDevolucionButton_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Obtener el Id de la reserva de la tabla Reservas
                int idReserva = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                // Obtener la fecha actual
                DateTime fechaActual = DateTime.Now;

                // Obtener la fecha de retorno de la reserva
                DateTime fechaRetorno = ObtenerFechaRetornoReserva(idReserva);

                // Comparar la fecha actual con la fecha de retorno
                string entregaATiempo = fechaActual <= fechaRetorno ? "Sí" : "No";

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    // Actualizar la tabla HistorialReservas usando el idReserva como ReservaId
                    string sql = "UPDATE HistorialReservas SET FechaDevolucionReal = @FechaDevolucionReal, EntregaATiempo = @EntregaATiempo WHERE ReservaId = @idReserva";
                    SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@idReserva", idReserva); // Usar el idReserva como ReservaId
                    cmd.Parameters.AddWithValue("@FechaDevolucionReal", fechaActual.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@EntregaATiempo", entregaATiempo);
                    cmd.Parameters.AddWithValue("@EntregadaATiempo", fechaActual <= fechaRetorno ? "Sí" : "No");
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Devolución registrada exitosamente.");
                LoadDataReserva(); // Recargar los datos en el DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la devolución: " + ex.Message);
            }
        }

        // Método para obtener la fecha de retorno de una reserva
        private DateTime ObtenerFechaRetornoReserva(int reservaId)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT [Fecha de retorno] FROM Reservas WHERE Id = @ReservaId";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ReservaId", reservaId);
                return Convert.ToDateTime(cmd.ExecuteScalar());
            }
        }

        private void HistorialReservasButton_Click(object sender, EventArgs e)
        {
            HistorialReserva historialReserva = new HistorialReserva();
            historialReserva.Show();
            this.Close();
        }

        private void BuscarReservaBox_TextChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source=C:\\Users\\Asus\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Files\\Prueba.db;";
            string terminoBusqueda = BuscarReservaBox.Text;
            string criterioBusqueda = BuscarReservaComboBox.SelectedItem?.ToString();

            string sql = "SELECT * FROM Reservas WHERE ";

            switch (criterioBusqueda)
            {
                case "Id":
                    sql += "CAST(Id AS TEXT) LIKE @terminoBusqueda";
                    break;
                case "Usuario":
                    sql += "Usuario LIKE @terminoBusqueda";
                    break;
                case "Libro":
                    sql += "Libro LIKE @terminoBusqueda";
                    break;
                case "Fecha de reserva":
                    sql += "Fecha de reserva LIKE @terminoBusqueda";
                    break;
                case "Fecha de retorno":
                    sql += "Fecha de retorno LIKE @terminoBusqueda";
                    break;
                default:
                    sql += "CAST(Id AS TEXT) LIKE @terminoBusqueda OR Usuario LIKE @terminoBusqueda"; // Búsqueda por id y Usuario por defecto
                    break;
            }

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@terminoBusqueda", "%" + terminoBusqueda + "%");
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void BuscarReservaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

