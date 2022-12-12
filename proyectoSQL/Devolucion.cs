﻿using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace proyectoSQL
{
    public partial class Devolucion : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Devolucion()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dgvActividad.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM Devolucion ORDER BY idDevolucion");
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string fecha = txtFecha.Text;
            string descripcion = txtDescripcion.Text;
            string cantidad = txtCantidad.Text;
            string idUsuraio = txtidUsuario.Text;
            consulta = "INSERT INTO Devolucion (fecha, descripcion, cantidadDevolucion,idUsuario) " +
                "values('" + fecha + "', '" + descripcion + "', '" + cantidad + "', '" + idUsuraio + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();


            txtFecha.Clear();
            txtDescripcion.Clear();
            txtCantidad.Clear();
            txtidUsuario.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idDevolucion = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            string fecha = txtFecha.Text;
            string descripcion = txtDescripcion.Text;
            string cantidad = txtCantidad.Text;
            string idUsuraio = txtidUsuario.Text;
            consulta = "UPDATE Devolucion SET fechaEntrega = '" + fecha + "', descripcion = '" + descripcion + "', cantidadDevolucion = '" + cantidad + "', idUsuario =  '" + idUsuraio + "' WHERE idDevolucion = " + idDevolucion.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtFecha.Clear();
            txtDescripcion.Clear();
            txtCantidad.Clear();
            txtidUsuario.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int idDevolucion = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Devolucion SET ESTATUS = false WHERE idDevolucion =" + idDevolucion.ToString();
            conexion.Open();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Hide();
        }

        private void Devolucion_Load(object sender, EventArgs e)
        {
            MostrarDatos();

        }
    }
}
