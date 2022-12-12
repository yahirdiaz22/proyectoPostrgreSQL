﻿using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace proyectoSQL
{
    public partial class Idioma : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Idioma()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dgvActividad.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM Idioma ORDER BY idIdioma");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtIdioma.Text;
            string descripcion = txtDescripcion.Text;
            string pais = txtPais.Text;
            string libro = txtIDLibro.Text;


            consulta = "INSERT INTO Idioma (nombreIdioma,descripcion,paisOrigen,idLibro) " +
                "values('" + nombre + "', '" + descripcion + "','" + pais + "','" + libro + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtPais.Clear();
            txtIdioma.Clear();
            txtDescripcion.Clear();
            txtIDLibro.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idIdioma = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            string nombre = txtIdioma.Text;
            string descripcion = txtDescripcion.Text;
            string pais = txtPais.Text;
            string libro = txtIDLibro.Text;
            consulta = "UPDATE Idioma SET nombreIdioma = '" + nombre + "',descripcion =  '" + descripcion + "',paisOrigen = '" + pais + "', idLibro = '" + libro + "' WHERE idIdioma = " + idIdioma.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtPais.Clear();
            txtIdioma.Clear();
            txtDescripcion.Clear();
            txtIDLibro.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int idIdioma = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Clasificacion SET ESTATUS = false WHERE idIdioma =" + idIdioma.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void Idioma_Load(object sender, EventArgs e)
        {
            MostrarDatos();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Hide();
        }
    }
}
