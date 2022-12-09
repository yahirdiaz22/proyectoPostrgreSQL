using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoSQL
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Actividad actividad = new Actividad();
            actividad.Show();
            Hide();
        }

        private void btnActividadPrograma_Click(object sender, EventArgs e)
        {
            
            ActividadPrograma actividaPrograma = new ActividadPrograma();
            actividaPrograma.Show();
            Hide();
        }

        private void btnAdquisicion_Click(object sender, EventArgs e)
        {
            Adquisicion adquisicion = new Adquisicion();
            adquisicion.Show();
            Hide();
        }

        private void btnArchivero_Click(object sender, EventArgs e)
        {
            Archivero archivero = new Archivero();
            archivero.Show();
            Hide();
        }

        private void btnAreaMuseo_Click(object sender, EventArgs e)
        {
            AreaMuseo areaMuseo = new AreaMuseo();
            areaMuseo.Show();
            Hide();
        }

        private void btnArticulo_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            articulo.Show();
            Hide();
        }

        private void btnAutor_Click(object sender, EventArgs e)
        {
            Autor autor = new Autor();
            autor.Show();
            Hide();
        }

        private void btnBiblioteca_Click(object sender, EventArgs e)
        {
            Biblioteca biblioteca = new Biblioteca();  
            biblioteca.Show();
            Hide();
        }

        private void btnBoveda_Click(object sender, EventArgs e)
        {
            Boveda boveda = new Boveda();
            boveda.Show();
            Hide();
        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            Catalogo catalogo = new Catalogo();
            catalogo.Show();
            Hide();
        }

        private void btnClasificacion_Click(object sender, EventArgs e)
        {
            Clasificacion clasificacion = new Clasificacion();
            clasificacion.Show();
            Hide();
        }

        private void btnColeccionLibro_Click(object sender, EventArgs e)
        {
            ColeccionLibro coleccionLibro = new ColeccionLibro();
            coleccionLibro.Show();
            Hide();
        }

        private void btnDocumento_Click(object sender, EventArgs e)
        {
            Documento documento = new Documento();
            documento.Show();
            Hide();

        }

        private void btnConvenio_Click(object sender, EventArgs e)
        {
            Convenio convenio = new Convenio();
            convenio.Show();
            Hide();
        }

        private void btnCopias_Click(object sender, EventArgs e)
        {
            Copias copias = new Copias();
            copias.Show();
            Hide();
        }

        private void btnCredencial_Click(object sender, EventArgs e)
        {
            Credencial credencial = new Credencial();
            credencial.Show();
            Hide();
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            Devolucion devolucion = new Devolucion();
            devolucion.Show();
            Hide();
        }

        private void btnDevolucionPrestamo_Click(object sender, EventArgs e)
        {
            DevolucionPrestamo devolucionPrestamo = new DevolucionPrestamo();
            devolucionPrestamo.Show();
            Hide();
        }

        private void btnDimensionLudica_Click(object sender, EventArgs e)
        {
            DimensionLudica dimensionLudica = new DimensionLudica();
            dimensionLudica.Show();
            Hide();
        }

        private void btnEquipoComputo_Click(object sender, EventArgs e)
        {
            EquipoComputo equipoComputo = new EquipoComputo();
            equipoComputo.Show();
            Hide();
        }

        private void btnEditorial_Click(object sender, EventArgs e)
        {
            Editorial editorial = new Editorial();
            editorial.Show();
            Hide();
        }

        private void btnEditorialLibro_Click(object sender, EventArgs e)
        {
            EditorialLibro editorialLibro = new EditorialLibro();
            editorialLibro.Show();
            Hide();

        }

        private void btnEditorialRevista_Click(object sender, EventArgs e)
        {
            EditorialRevista editorialRevista = new EditorialRevista();
            editorialRevista.Show();
            Hide();
        }

        private void btnEjemplares_Click(object sender, EventArgs e)
        {
            Ejemplares ejemplares = new Ejemplares();
            ejemplares.Show();
            Hide();

        }

        private void btnEjemplaresLibro_Click(object sender, EventArgs e)
        {
            EjemplaresLibro ejemplaresLibro = new EjemplaresLibro();
            ejemplaresLibro.Show();
            Hide();
        }

        private void btnEmpleadoActividad_Click(object sender, EventArgs e)
        {
            EmpleadoActividad empleadoActividad = new EmpleadoActividad();
            empleadoActividad.Show();
            Hide();
        }

        private void btnImprenta_Click(object sender, EventArgs e)
        {
            Imprenta imprenta = new Imprenta();
            imprenta.Show();
            Hide();
        }

        private void btnEstanteria_Click(object sender, EventArgs e)
        {
            Estanteria estanteria = new Estanteria();
            estanteria.Show();
            Hide();
        }

        private void btnFichaTecnica_Click(object sender, EventArgs e)
        {
            FichaTecnica fichaTecnica = new FichaTecnica();
            fichaTecnica.Show();
            Hide();
        }

        private void btnGaleria_Click(object sender, EventArgs e)
        {
            Galeria galeria = new Galeria();
            galeria.Show();
            Hide();
        }

        private void btnGenero_Click(object sender, EventArgs e)
        {
            Genero genero = new Genero();
            genero.Show();
            Hide();
        }

        private void btnGrupoLectura_Click(object sender, EventArgs e)
        {
            GrupoLectura grupoLectura = new GrupoLectura();
            grupoLectura.Show();
            Hide();
        }

        private void btnIdioma_Click(object sender, EventArgs e)
        {
            Idioma idioma = new Idioma();
            idioma.Show();
            Hide();

        }

        private void btnPeriodo_Click(object sender, EventArgs e)
        {
            Periodico periodico = new Periodico();
            periodico.Show();
            Hide();

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            Inventario inventario = new Inventario();
            inventario.Show();
            Hide();

        }

        private void btnLibro_Click(object sender, EventArgs e)
        {
            Libro libro = new Libro();
            libro.Show();
            Hide();

        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            Material material = new Material();
            material.Show();
            Hide();

        }

        private void btnMobiliario_Click(object sender, EventArgs e)
        {
            Mobiliario mobiliario = new Mobiliario();
            mobiliario.Show();
            Hide();

        }

        private void btnMulta_Click(object sender, EventArgs e)
        {
            Multa multa = new Multa();
            multa.Show();
            Hide();

        }

        private void btnPasta_Click(object sender, EventArgs e)
        {
            Pasta pasta = new Pasta();
            pasta.Show();
            Hide();

        }

        private void btnSecciones_Click(object sender, EventArgs e)
        {
            Seccion seccion = new Seccion();
            seccion.Show();
            Hide();

        }

        private void btnPiso_Click(object sender, EventArgs e)
        {
            Piso piso = new Piso();
            piso.Show();
            Hide();

        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            Prestamo prestamo = new Prestamo();
            prestamo.Show();
            Hide();

        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {

            Proveedor proveedor = new Proveedor();
            proveedor.Show();
            Hide();
        }

        private void btnProveedorLibro_Click(object sender, EventArgs e)
        {
            ProveedorLibro proveedorLibro = new ProveedorLibro();
            proveedorLibro.Show();
            Hide();

        }

        private void btnRegistroVista_Click(object sender, EventArgs e)
        {
            RegistroVisita registroVisita = new RegistroVisita();
            registroVisita.Show();
            Hide();

        }

        private void btnRevista_Click(object sender, EventArgs e)
        {
            Revista revista = new Revista();
            revista.Show();
            Hide();

        }

        private void btnSocio_Click(object sender, EventArgs e)
        {
            Socio socio = new Socio();
            socio.Show();
            Hide();

        }

        private void btnTaller_Click(object sender, EventArgs e)
        {
            Taller taller = new Taller();
            taller.Show();
            Hide();

        }

        private void btnTema_Click(object sender, EventArgs e)
        {
            Tema tema = new Tema();
            tema.Show();
            Hide();

        }

        private void btnTraduccion_Click(object sender, EventArgs e)
        {
            Traduccion traduccion = new Traduccion();
            traduccion.Show();
            Hide();

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Show();
            Hide();

        }

        private void btnUsuarioPrestamo_Click(object sender, EventArgs e)
        {
            UsuarioPrestamo usuarioPrestamo = new UsuarioPrestamo();
            usuarioPrestamo.Show();
            Hide();

        }

        private void btnColeccion_Click(object sender, EventArgs e)
        {
            Coleccion coleccion = new Coleccion();
            coleccion.Show();
            Hide();
        }

        private void btnComite_Click(object sender, EventArgs e)
        {
            Comite comite = new Comite();
            comite.Show();
            Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ProveedorRevista  proveedorRevista= new ProveedorRevista();
            proveedorRevista.Show();
            Hide();
        }
    }
}
