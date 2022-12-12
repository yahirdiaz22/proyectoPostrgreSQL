﻿using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace proyectoSQL
{
    public partial class Galeria : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Galeria()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dgvActividad.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM Galeria ORDER BY idGaleria");
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string artista = txtArtista.Text;
            string fechainiico = txtFechaInicio.Text;
            string fechafinal = txtFechaFinal.Text;
            string idBiblioteca = txtIDBiblioteca.Text;
            consulta = "INSERT INTO Galeria (nombre,nombreArtista,fechaInicio,fechaFinal,idBiblioteca) " +
                "values('" + nombre + "', '" + artista + "','" + fechainiico + "', '" + fechafinal + "','" + idBiblioteca + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtNombre.Clear();
            txtArtista.Clear();
            txtFechaInicio.Clear();
            txtIDBiblioteca.Clear();
            txtFechaFinal.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idGaleria = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            string nombre = txtNombre.Text;
            string artista = txtArtista.Text;
            string fechainiico = txtFechaInicio.Text;
            string fechafinal = txtFechaFinal.Text;
            string idBiblioteca = txtIDBiblioteca.Text; ;
            consulta = "UPDATE Galeria SET nombre = '" + nombre + "', nombreArtista = '" + artista + "',fechaInicio = '" + fechainiico + "', fechaFinal = '" + fechafinal + "',idBiblioteca = '" + idBiblioteca + "' WHERE idGaleria = " + idGaleria.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtNombre.Clear();
            txtArtista.Clear();
            txtFechaInicio.Clear();
            txtIDBiblioteca.Clear();
            txtFechaFinal.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int idGaleria = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Galeria SET ESTATUS = false WHERE idGaleria =" + idGaleria.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Hide();
        }

        private void Galeria_Load(object sender, EventArgs e)
        {
            MostrarDatos();

        }
    }
}
