using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace proyectoSQL
{
    public partial class ActividadPrograma : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;

        public ActividadPrograma()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }

        private void ActividadPrograma_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
        private void MostrarDatos()
        {
            dgvActividadPrograma.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM ActividadPrograma ORDER BY idActividadPrograma");
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string fecha = txtFecha.Text;
            string idEmpleado = txtidEmpleado.Text;
            consulta = "INSERT INTO ActividadPrograma (nombre,fecha,idEmpleado) values ('" + nombre + "','" + fecha + "','" + idEmpleado + "')";
            conexion.Open();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtNombre.Clear();
            txtidEmpleado.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string fecha = txtFecha.Text;
            string idEmpelado = txtidEmpleado.Text;
            int idActividadPrograma = (int)dgvActividadPrograma.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE Actividad SET nombreActividad ='" + nombre + "','" + fecha +  "','" + idEmpelado + "'WHERE idActividadPrograma = " + idActividadPrograma.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtNombre.Clear();
            txtidEmpleado.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int idActividadPrograma = (int)dgvActividadPrograma.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE ActividadPrograma SET ESTATUS = 0 WHERE idActividadPrograma =" + idActividadPrograma.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Menu regresar = new Menu();
            regresar.Show();
        }
    }
}
