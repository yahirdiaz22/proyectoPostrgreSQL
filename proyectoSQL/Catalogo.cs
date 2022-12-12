﻿using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace proyectoSQL
{
    public partial class Catalogo : Form
    {
        public Catalogo()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        private void MostrarDatos()
        {
            dgvActividad.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM Catalogo ORDER BY idCatalogo");
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtAutor.Text;
            string materias = txtMateria.Text;
            string titulo = txtTitulo.Text;
            string referencia = txtReferencia.Text;
            string idBiblioteca = txtidBiblio.Text;

            consulta = "INSERT INTO Catalogo (autor, materias, titulo, referenciaBibliografica,idBiblioteca) " +
                "values('" + nombre + "', '" + materias + "', '" + titulo + "', '" + referencia + "', '" + idBiblioteca + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtTitulo.Clear();
            txtAutor.Clear();
            txtidBiblio.Clear();
            txtMateria.Clear();
            txtReferencia.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idCatalogo = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            string nombre = txtAutor.Text;
            string materias = txtMateria.Text;
            string titulo = txtTitulo.Text;
            string referencia = txtReferencia.Text;
            string idBiblioteca = txtidBiblio.Text;
            consulta = "UPDATE Catalogo SET autor  = '" + nombre + "', materias = '" + materias + "', titulo = '" + titulo + "', referenciaBibliografica = '" + referencia + "', idBiblioteca = '" + idBiblioteca + "' WHERE idCatalogo = " + idCatalogo.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtTitulo.Clear();
            txtAutor.Clear();
            txtidBiblio.Clear();
            txtMateria.Clear();
            txtReferencia.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int idCatalogo = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Catalogo SET ESTATUS = false WHERE idCatalogo =" + idCatalogo.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Hide();
        }

        private void Catalogo_Load(object sender, EventArgs e)
        {
            MostrarDatos();

        }
    }
}
