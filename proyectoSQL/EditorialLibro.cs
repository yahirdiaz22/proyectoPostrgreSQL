﻿using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace proyectoSQL
{
    public partial class EditorialLibro : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public EditorialLibro()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dgvActividad.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM EditorialLibro ORDER BY idEditorialLibro");
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string idLibro = txtIDLibro.Text;
            string idEditorial = txtIDEditorial.Text;
            consulta = "INSERT INTO EditorialLibro (idEditorial,idLibro) " +
                "values('" + idEditorial + "', '" + idLibro + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtIDEditorial.Clear();
            txtIDLibro.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idEditorialLibro = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            string idEditorial = txtIDEditorial.Text;
            string idLibro = txtIDLibro.Text;
            consulta = "UPDATE EditorialLibro SET idEditorial = '" + idEditorial + "', idLibro = '" + idLibro + "' WHERE idEditorialLibro = " + idEditorialLibro.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtIDEditorial.Clear();
            txtIDLibro.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int idEditorialLibro = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE EditorialLibro SET ESTATUS = false WHERE idEditorialLibro =" + idEditorialLibro.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Hide();
        }

        private void EditorialLibro_Load(object sender, EventArgs e)
        {
            MostrarDatos();

        }
    }
}
