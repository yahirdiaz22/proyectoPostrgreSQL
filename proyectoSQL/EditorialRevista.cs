﻿using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace proyectoSQL
{
    public partial class EditorialRevista : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public EditorialRevista()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dgvActividad.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM EditorialRevista ORDER BY idEditorialRevista");
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string idRevista = txtIDLibro.Text;
            string idEditorial = txtIDColeccion.Text;
            consulta = "INSERT INTO EditorialRevista (idEditorial,idRevista) " +
                "values('" + idEditorial + "', '" + idRevista + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();


            txtIDColeccion.Clear();
            txtIDLibro.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idEditorialRevista = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            string idEditorial = txtIDColeccion.Text;
            string idRevista = txtIDLibro.Text;
            consulta = "UPDATE EditorialRevista SET idEditorial = '" + idEditorial + "',idRevista = '" + idRevista + "' WHERE idEditorialRevista = " + idEditorialRevista.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtIDColeccion.Clear();
            txtIDLibro.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int idEditorialRevista = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE EditorialRevista SET ESTATUS = false WHERE idEditorialRevista =" + idEditorialRevista.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Hide();
        }

        private void EditorialRevista_Load(object sender, EventArgs e)
        {
            MostrarDatos();

        }
    }
}
