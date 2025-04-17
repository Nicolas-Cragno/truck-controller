using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;

namespace presentacion
{
    public partial class FrmPrincipal : Form
    {
        private List<Evento> listadoEventos;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void ocultarColumnas()
        {
            dgvListarEventos.Columns["Detalle"].Visible = false; // Ocultar el detalle en la grilla orginal
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            EventoNegocio negocio = new EventoNegocio();
            listadoEventos = negocio.listarEventos(); // Se guarda en objeto para manipularlo
            dgvListarEventos.DataSource = listadoEventos;
            ocultarColumnas();
        }

        private void dgvListarEventos_SelectionChanged(object sender, EventArgs e)
        {
            // Evento seleccion = (Evento)dgvListarEventos.CurrentRow.DataBoundItem; // evento seleccionado por el cursor
            //  FrmModificarEvento ventana = new FrmModificarEvento();
            //  ventana.Show();


        }

        private void btnAgregarEvento_Click(object sender, EventArgs e)
        {
            frmAgregarEvento alta = new frmAgregarEvento(); 
            alta.ShowDialog(); // Abre ventana para AGREGAR EVENTO
            // cargar();   //buscar funcion maxi
        }

        private void dgvListarEventos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Evento seleccion = (Evento)dgvListarEventos.CurrentRow.DataBoundItem; // evento seleccionado por el cursor

            FrmModificarEvento modificar = new FrmModificarEvento(seleccion);
            modificar.Show();
        }

        private void filtrarEventos()
        {
            List<Evento> listaFiltrada;
            string filtro = tbxFiltrarEventos.Text;

            if (filtro != "")
            {
                listaFiltrada = listadoEventos.FindAll(ev => ev.DNI_Persona.ToString().ToUpper().Contains(filtro.ToUpper()) || ev.Nro_Interno.ToString().ToUpper().Contains(filtro.ToUpper()) || ev.Tipo.ToString().ToUpper().Contains(filtro.ToUpper()) || ev.Id.ToString().ToUpper().Contains(filtro.ToUpper()) || ev.Fecha.ToString().ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listadoEventos;
            }
            dgvListarEventos.DataSource = null; // vaciarla primero para pisarla desp con la lista filtrada
            dgvListarEventos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void btnFiltrarEventos_Click(object sender, EventArgs e)
        {
            filtrarEventos();
        }

        private void tbxFiltrarEventos_Enter(object sender, EventArgs e)
        {
            //filtrarEventos();
        }

        private void tbxFiltrarEventos_DragEnter(object sender, DragEventArgs e)
        {
            //filtrarEventos();
        }
    }
}
