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
using WinFormsApp1.Forms._3;

namespace WinFormsApp1.Forms
{
    public partial class HistorialReserva : Form
    {
        public HistorialReserva()
        {
            InitializeComponent();
            LoadDataHistorial();

            //Aqui agregamos los items del combo box
            BuscarHistorialComboBox.Items.Add("Id");
            BuscarHistorialComboBox.Items.Add("ReservaId");
            BuscarHistorialComboBox.Items.Add("Libro");
            BuscarHistorialComboBox.Items.Add("Usuario");
            BuscarHistorialComboBox.Items.Add("FechaReserva");
            BuscarHistorialComboBox.Items.Add("FechaRetorno");
            BuscarHistorialComboBox.Items.Add("FechaDevolucionRea");
            BuscarHistorialComboBox.Items.Add("EntregaATiempo");

        }

        private void LoadDataHistorial()
        {


            // Conecta a la base de datos (remplazar C:\Users\Asus\source\repos\WinFormsApp1\WinFormsApp1\Files\Prueba.db por la ubicacion de tu base de datos)
            SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\Users\\Asus\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Files\\Prueba.db");
            conn.Open();

            // Crea la consulta SQL
            string sql = "SELECT * FROM HistorialReservas";

            // Crea un objeto DataTable y llena con los datos
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            // Asigna el DataTable al DataGridView
            dataGridView1.DataSource = dt;

            // Cierra la conexión
            conn.Close();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            Reservas reservas = new Reservas();
            reservas.Show();
            this.Close();
        }

        private void Historial_Load(object sender, EventArgs e)
        {

        }

        private void BuscarHistorialBox_TextChanged_1(object sender, EventArgs e)
        {
            string connectionString = "Data Source=C:\\Users\\Asus\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Files\\Prueba.db;";
            string terminoBusqueda = BuscarHistorialBox.Text;
            string criterioBusqueda = BuscarHistorialComboBox.SelectedItem?.ToString();

            string sql = "SELECT * FROM HistorialReservas WHERE ";

            switch (criterioBusqueda)
            {
                case "Id":
                    sql += "CAST(Id AS TEXT) LIKE @terminoBusqueda";
                    break;
                case "ReservaId":
                    sql += "CAST(ReservaId AS TEXT) LIKE @terminoBusqueda";
                    break;
                case "Libro":
                    sql += "Libro LIKE @terminoBusqueda";
                    break;
                case "Usuario":
                    sql += "Usuario LIKE @terminoBusqueda";
                    break;
                case "FechaReserva":
                    sql += "FechaReserva LIKE @terminoBusqueda";
                    break;
                case "FechaRetorno":
                    sql += "FechaRetorno LIKE @terminoBusqueda";
                    break;
                case "FechaDevolucionRea;":
                    sql += "FechaDevolucionRea LIKE @terminoBusqueda";
                    break;
                case "EntregaATiempo":
                    sql += "EntregaATiempo LIKE @terminoBusqueda";
                    break;
                default:
                    sql += "CAST(ReservaId AS TEXT) LIKE @terminoBusqueda OR Libro LIKE @terminoBusqueda OR Usuario LIKE @terminoBusqueda"; // Búsqueda por id,libro y usuario por defecto
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

        private void BuscarHistorialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }






    }
}
