using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace proyectoSQL
{
    public partial class ProveedorRevista : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public ProveedorRevista()
        {
            InitializeComponent(); string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dgvActividad.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM ProveedorRevista ORDER BY idProveedorRevista");
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string idProveedor = txtIDProveedor.Text;
            string revista = txtRevista.Text;
            consulta = "INSERT INTO ProveedorRevista (idProveedor,idRevista) " +
                "values('" + idProveedor + "', '" + revista + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idProveedorRevista = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            string idProveedor = txtIDProveedor.Text;
            string revista = txtRevista.Text;
            consulta = "UPDATE ProveedorRevista  SET idProveedor = '" + idProveedor + "', idRevista = '" + revista + "' WHERE idProveedorRevista = " + idProveedorRevista.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtIDProveedor.Clear();
            txtRevista.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int idProveedorRevista = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE ProveedorRevista SET ESTATUS = false WHERE idProveedorRevista =" + idProveedorRevista.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Hide();
        }

        private void ProveedorRevista_Load(object sender, EventArgs e)
        {
            MostrarDatos();

        }
    }
}
