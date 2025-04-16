using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace presentacion
{
    public partial class frmAgregarEvento : Form
    {
        public frmAgregarEvento()
        {
            InitializeComponent();
        }

        private void AgregarEvento_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarEventoCancel_Click(object sender, EventArgs e)
        {
            Close(); // Cierra la ventana de NUEVO EVENTO sin guardar cambios.
        }

        private void btnAgregarEventoOK_Click(object sender, EventArgs e)
        {
            Evento nuevoEvento = new Evento();
            EventoNegocio negocio = new EventoNegocio();

            try
            {
                //nuevoEvento.Fecha = fecha.Parse(tbxAgregarEventoFecha.Text);
                nuevoEvento.DNI_Persona = int.Parse(tbxAgregarEventoPersona.Text);
                nuevoEvento.Nro_Interno = int.Parse(tbxAgregarEventoTractor.Text);
                nuevoEvento.Tipo = tbxAgregarEventoTipo.Text;
                nuevoEvento.Detalle = tbxAgregarEventoDetalle.Text;

                negocio.agregar(nuevoEvento);
                MessageBox.Show("Evento agregado.");
                Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
