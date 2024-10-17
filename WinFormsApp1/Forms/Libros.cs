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
    public partial class Libros : Form
    {
        private LibroLogica libroLogica;

        public Libros()
        {
            InitializeComponent();
            LoadDataLibros();
            string connectionString = "Data Source=C:\\Users\\Asus\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Files\\Prueba.db;";
            libroLogica = new LibroLogica(connectionString);
            ActualizarLibrosDataGridView();

            //Aqui agregamos los items del combo box
            BuscarLibroComboBox.Items.Add("Id");
            BuscarLibroComboBox.Items.Add("ISBN");
            BuscarLibroComboBox.Items.Add("Titulo");
            BuscarLibroComboBox.Items.Add("Autor");
            BuscarLibroComboBox.Items.Add("Editorial");
            BuscarLibroComboBox.Items.Add("Año_de_publicacion");
            BuscarLibroComboBox.Items.Add("Genero");

        }

        private void LoadDataLibros()
        {


            // Conecta a la base de datos (remplazar C:\Users\Asus\source\repos\WinFormsApp1\WinFormsApp1\Files\Prueba.db por la ubicacion de tu base de datos)
            SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\Users\\Asus\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Files\\Prueba.db");
            conn.Open();

            // Crea la consulta SQL
            string sql = "SELECT * FROM Libros";

            // Crea un objeto DataTable y llena con los datos
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            // Asigna el DataTable al DataGridView
            dataGridView1.DataSource = dt;

            // Cierra la conexión
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataTable tabla = new DataTable();
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un libro para editar.");
                return;
            }

            try
            {
                // Obtener la fila seleccionada y el Id del libro
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells["Id"].Value); // Verifica que el nombre de la columna sea 'Id'

                // Crear una nueva instancia de Libro con los datos actuales
                Libro libro = new Libro(
                    ISBNBox.Text,
                    TituloBox.Text,
                    AutorBox.Text,
                    EditorialBox.Text,
                    AñoBox.Text,
                    GeneroBox.Text,
                    int.Parse(CopiasBox.Text)
                )
                {
                    Id = id // Establecer el Id del libro
                };

                // Llamar al método EditarLibro
                libroLogica.EditarLibro(libro);

                MessageBox.Show("Libro editado exitosamente.");

                // Recargar los datos en el DataGridView
                ActualizarLibrosDataGridView();
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

        private void Libros_Load_1(object sender, EventArgs e)
        {

        }

        private void InicioLibrosButton_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();
        }

        private void ActualizarLibrosDataGridView()
        {
            try
            {
                // Obtener todos los libros de la base de datos
                List<Libro> libros = libroLogica.ObtenerTodosLosLibros();

                // Asignar la lista de libros como origen de datos del DataGridView
                dataGridView1.DataSource = libros;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los libros: " + ex.Message);
            }
        }



        private void AgregarLibroBotton_Click(object sender, EventArgs e)
        {
            string isbn = ISBNBox.Text;
            string titulo = TituloBox.Text;
            string autor = AutorBox.Text;
            string editorial = EditorialBox.Text;
            string año_de_publicacion = AñoBox.Text;
            string genero = GeneroBox.Text;
            int numero_de_copias;


            if (!int.TryParse(CopiasBox.Text, out numero_de_copias))
            {
                MessageBox.Show("Por favor, ingrese un número válido de copias.");
                return;
            }


            Libro libro = new Libro(isbn, titulo, autor, editorial, año_de_publicacion, genero, numero_de_copias);

            try
            {
                // Llamar al método para insertar la persona en la base de datos
                libroLogica.InsertarLibro(libro);
                MessageBox.Show("Persona agregada exitosamente.");
                ActualizarLibrosDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar persona: " + ex.Message);

            }





        }
        private void EliminarLibroButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un libro para eliminar.");
                return;
            }

            // Obtener el Id del libro seleccionado
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["Id"].Value);

            try
            {
                libroLogica.EliminarLibro(id);
                MessageBox.Show("Libro eliminado exitosamente.");
                ActualizarLibrosDataGridView(); // Recargar la lista de libros
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el libro: " + ex.Message);
            }
        }

        private void BuscarLibroBox_TextChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source=C:\\Users\\Asus\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Files\\Prueba.db;";
            string terminoBusqueda = BuscarLibroBox.Text;
            string criterioBusqueda = BuscarLibroComboBox.SelectedItem?.ToString();

            string sql = "SELECT * FROM Libros WHERE ";

            switch (criterioBusqueda)
            {
                case "Id":
                    sql += "CAST(Id AS TEXT) LIKE @terminoBusqueda";
                    break;
                case "ISBN":
                    sql += "ISBN LIKE @terminoBusqueda";
                    break;
                case "Titulo":
                    sql += "Titulo LIKE @terminoBusqueda";
                    break;
                case "Autor":
                    sql += "Autor LIKE @terminoBusqueda";
                    break;
                case "Editorial":
                    sql += "Editorial LIKE @terminoBusqueda";
                    break;
                case "Año_de_publicacion":
                    sql += "Año_de_publicacion LIKE @terminoBusqueda";
                    break;
                case "Genero":
                    sql += "Genero LIKE @terminoBusqueda";
                    break;
                default:
                    sql += "CAST(Id AS TEXT) LIKE @terminoBusqueda OR Titulo LIKE @terminoBusqueda"; // Búsqueda por id y titulo por defecto
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

        private void BuscarLibroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
