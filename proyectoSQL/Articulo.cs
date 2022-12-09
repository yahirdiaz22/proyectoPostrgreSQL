﻿using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace proyectoSQL
{
    public partial class Articulo : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Articulo()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
            //conexion.Open();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcio.Text;
            string fecha = txtFecha.Text;
            string idUsuario = txtFecha.Text;
            string idEditorial = txtFecha.Text;
            consulta = "INSERT INTO Articulo (nombreArticulo,descripcion,año,idUsuario,idEditorial) values ('" + nombre + "','" + descripcion + "','" + fecha + "','" + idUsuario + "','" + idEditorial + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtNombre.Clear();
            txtDescripcio.Clear();
            txtFecha.Clear();
            txtidEditorial.Clear();
            txtidUsuario.Clear();
        }
        private void MostrarDatos()
        {
            dgvActividad.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM Articulo ORDER BY idArticulo");
        }
        private void Articulo_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcio.Text;
            string fecha = txtFecha.Text;
            string idUsuario = txtFecha.Text;
            string idEditorial = txtFecha.Text;
            int idArticulo = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE AreaMuseo SET nombre ='" + nombre + "','" + descripcion + "','" + fecha + "','" + idUsuario + "','" + idEditorial + "WHERE idAreaMuseo = " + idArticulo.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtNombre.Clear();
            txtDescripcio.Clear();
            txtFecha.Clear();
            txtidEditorial.Clear();
            txtidUsuario.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int idAreaMuseo = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE AreaMuseo SET ESTATUS = 0 WHERE idAreaMuseo =" + idAreaMuseo.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
            Menu regresar = new Menu();
            regresar.Show();
        }
    }
}
