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
    public partial class FrmModificarEvento : Form
    {
        private Evento evento = null;
        public FrmModificarEvento(Evento eventoSeleccionado) 
        {
            InitializeComponent();
            this.evento = eventoSeleccionado;
        }

        //private Evento eventoSeleccionado;

        private void FrmModificarEvento_Load(object sender, EventArgs e)
        {
            if (evento != null)
            {
                lblModificarEventoIdEvento.Text = evento.Id.ToString();
                tbxModificarEventoPersona.Text = evento.DNI_Persona.ToString();
                tbxModificarEventoTractor.Text = evento.Nro_Interno.ToString();
                tbxModificarEventoTipo.Text = evento.Tipo;
                tbxModificarEventoDetalle.Text = evento.Detalle;

            }
        }

        private void tbxModificarEventoDetalle_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificarEventoOK_Click(object sender, EventArgs e)
        {
            Evento eventoModificado = new Evento();
            EventoNegocio negocio = new EventoNegocio();

            try
            {
                //nuevoEvento.Fecha = fecha.Parse(tbxAgregarEventoFecha.Text);
                eventoModificado.Id = int.Parse(lblModificarEventoIdEvento.Text);
                eventoModificado.DNI_Persona = int.Parse(tbxModificarEventoPersona.Text);
                eventoModificado.Nro_Interno = int.Parse(tbxModificarEventoTractor.Text);
                eventoModificado.Tipo = tbxModificarEventoTipo.Text;
                eventoModificado.Detalle = tbxModificarEventoDetalle.Text;

                negocio.modificar(eventoModificado);
                MessageBox.Show("Cambios guardados.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificarEventoCancel_Click(object sender, EventArgs e)
        {
            Close(); // Cierra la ventana de MODIFICAR EVENTOS sin guardar cambios.
        }
    }
}
