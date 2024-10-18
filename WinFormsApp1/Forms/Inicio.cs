using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Forms._3;

namespace WinFormsApp1.Forms
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Librosbutton_Click(object sender, EventArgs e)
        {
            Libros libros = new Libros();
            libros.Show();
            this.Hide();
        }

        private void Usuariobutton_Click(object sender, EventArgs e)
        {
            Gestion_Usuarios gestion_Usuarios = new Gestion_Usuarios();
            gestion_Usuarios.Show();
            this.Hide();
        }

        private void Reservasbutton_Click(object sender, EventArgs e)
        {
            Reservas reservas = new Reservas();
            reservas.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Consultasbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Como explique en el .readme, no supe como realizar el Reporte ");
        }
    }
}
