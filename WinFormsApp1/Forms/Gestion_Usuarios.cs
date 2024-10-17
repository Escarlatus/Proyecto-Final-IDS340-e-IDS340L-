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

namespace WinFormsApp1.Forms
{
    public partial class Gestion_Usuarios : Form
    {


        private UsuarioLogica usuarioLogica;
        public Gestion_Usuarios()
        {
            InitializeComponent();
            LoadDataUsuarios();
            string connectionString = "Data Source=C:\\Users\\Asus\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Files\\Prueba.db;";
            usuarioLogica = new UsuarioLogica(connectionString);

            //Aqui agregamos los items del combo box
            BuscarComboBox.Items.Add("Nombre");
            BuscarComboBox.Items.Add("Apellido");
            BuscarComboBox.Items.Add("Email");
            BuscarComboBox.Items.Add("Teléfono");



        }

        private void LoadDataUsuarios()
        {


            // Conecta a la base de datos (remplazar C:\Users\Asus\source\repos\WinFormsApp1\WinFormsApp1\Files\Prueba.db por la ubicacion de tu base de datos)
            SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\Users\\Asus\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Files\\Prueba.db");
            conn.Open();

            // Crea la consulta SQL
            string sql = "SELECT * FROM Usuarios";

            // Crea un objeto DataTable y llena con los datos
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            // Asigna el DataTable al DataGridView
            dataGridViewUsuarios.DataSource = dt;

            // Cierra la conexión
            conn.Close();
        }


        private void InicioUsuarioButton_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Gestion_Usuarios_Load(object sender, EventArgs e)
        {

        }

        private void AgregaUsuarioButton_Click(object sender, EventArgs e)
        {
            int id;
            string nombre = NombreUsuarioBox.Text;
            string apellido = ApellidoUsuarioBox.Text;
            string email = EmailUsuarioBox.Text;
            string telefono = TelefonoUsuarioBox.Text;



            if (!int.TryParse(IdUsuarioBox.Text, out id))
            {
                MessageBox.Show("Por favor, ingrese un id valido.");
                return;
            }


            Usuario usuario = new Usuario(id, nombre, apellido, email, telefono);

            try
            {
                // Llamar al método para insertar la persona en la base de datos
                usuarioLogica.InsertarUsuario(usuario);
                MessageBox.Show("Persona agregada exitosamente.");
                ActualizarUsuariosDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar persona: " + ex.Message);

            }





        }

        private void ActualizarUsuariosDataGridView()
        {
            try
            {
                // Obtener todos los Usuarios de la base de datos
                List<Usuario> usuarios = usuarioLogica.ObtenerTodosLosUsuarios();

                if (usuarios == null || usuarios.Count == 0)
                {
                    MessageBox.Show("No hay usuarios disponibles para mostrar.");
                    return;
                }


                // Asignar la lista de Usuarios como origen de datos del DataGridView
                dataGridViewUsuarios.DataSource = usuarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los usuarios: " + ex.Message);
            }
        }

        private void EditarUsuarioButton_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila
            if (dataGridViewUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un libro para editar.");
                return;
            }

            try
            {
                // Obtener la fila seleccionada y el Id del libro
                DataGridViewRow row = dataGridViewUsuarios.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells["Id"].Value); // Verifica que el nombre de la columna sea 'Id'

                // Crear una nueva instancia de Libro con los datos actuales
                Usuario usuario = new Usuario(
                    int.Parse(IdUsuarioBox.Text),
                    NombreUsuarioBox.Text,
                    ApellidoUsuarioBox.Text,
                    EmailUsuarioBox.Text,
                    TelefonoUsuarioBox.Text


                );

                // Llamar al método EditarLibro
                usuarioLogica.EditarUsuario(usuario);

                MessageBox.Show("Libro editado exitosamente.");

                // Recargar los datos en el DataGridView
                ActualizarUsuariosDataGridView();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un número válido en el campo de copias.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el libro: " + ex.Message);
            }
        }

        private void EliminarUsuarioButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un libro para eliminar.");
                return;
            }

            // Obtener el Id del libro seleccionado
            DataGridViewRow row = dataGridViewUsuarios.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["Id"].Value);

            try
            {
                usuarioLogica.EliminarUsuario(id);
                MessageBox.Show("Libro eliminado exitosamente.");
                ActualizarUsuariosDataGridView(); // Recargar la lista de libros
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el libro: " + ex.Message);
            }
        }

        private void BuscarUsuarioBox_TextChanged(object sender, EventArgs e)
        {

            string connectionString = "Data Source=C:\\Users\\Asus\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Files\\Prueba.db;";
            string terminoBusqueda = BuscarUsuarioBox.Text;
            string criterioBusqueda = BuscarComboBox.SelectedItem?.ToString();

            string sql = "SELECT * FROM Usuarios WHERE ";

            switch (criterioBusqueda)
            {
                case "Nombre":
                    sql += "Nombre LIKE @terminoBusqueda";
                    break;
                case "Apellido":
                    sql += "Apellido LIKE @terminoBusqueda";
                    break;
                case "Email":
                    sql += "Email LIKE @terminoBusqueda";
                    break;
                case "Teléfono":
                    sql += "Telefono LIKE @terminoBusqueda";
                    break;
                default:
                    sql += "Nombre LIKE @terminoBusqueda OR Apellido LIKE @terminoBusqueda"; // Búsqueda por nombre y apellido por defecto
                    break;
            }

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@terminoBusqueda", "%" + terminoBusqueda + "%");
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewUsuarios.DataSource = dt;
            }
        }

        private void BuscarComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
