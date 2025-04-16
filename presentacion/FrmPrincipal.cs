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

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            EventoNegocio negocio = new EventoNegocio();
            listadoEventos = negocio.listarEventos(); // Se guarda en objeto para manipularlo
            dgvListarEventos.DataSource = listadoEventos;
        }

        private void dgvListarEventos_SelectionChanged(object sender, EventArgs e)
        {
            Evento seleccion = (Evento)dgvListarEventos.CurrentRow.DataBoundItem; // evento seleccionado por el cursor
            
            // FrmModificarEvento ventana = new FrmModificarEvento();
            
            


            // mandar informacion del evento seleccionado a nueva ventana
            // https://campusmaxiprograma.com/mod/page/view.php?id=1071

           // ventana.ShowDialog();
            
        }

        private void btnAgregarEvento_Click(object sender, EventArgs e)
        {
            frmAgregarEvento alta = new frmAgregarEvento(); 
            alta.ShowDialog(); // Abre ventana para AGREGAR EVENTO
        }
    }
}
