using Nutricion.Control;
using Nutricion.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nutricion
{
    public partial class Paciente : Form
    {
        public Paciente()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrimerNombre.Text))
            {
                erpMensaje.SetError(txtPrimerNombre, "El nombre es obligatorio");
                return;
            }
            else
            {
                erpMensaje.SetError(txtPrimerNombre, "");
            }
            //TODO: VALIDAR Número de Documento
            if (dtpFechaNacimiento.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha de nacimiento debe ser menor a la fecha actual");
                return;
            }

            Entidades.Paciente paciente = new Entidades.Paciente();
            paciente.PrimerNombre = txtPrimerNombre.Text;
            paciente.SegundoNombre = txtSegundoNombre.Text;
            paciente.PrimerApellido = txtPrimerApellido.Text;
            paciente.SegundoApellido = txtSegundoApellido.Text;
            paciente.Beneficiario = chkBeneficiario.Checked;
            paciente.Telefono = txtTelefono.Text;
            paciente.IdEstadoCivil = (cboEstadoCivil.SelectedItem as EstadoCivil).Id;
            paciente.NumeroDocumento = Convert.ToInt64(txtNumeroDocumento.Text);
            paciente.FechaNacimiento = dtpFechaNacimiento.Value;
            paciente.IdTipoDocumento = (cboTipoDocumento.SelectedItem as TipoDocumento).Id;

            ControlPaciente.IngresarPaciente(paciente);

            MessageBox.Show("Paciente ingresado exitosamente");
        }

        private void Paciente_Load(object sender, EventArgs e)
        {
            List<TipoDocumento> tiposDocumento = ControlPaciente.ObtenerTiposDocumento();
            cboTipoDocumento.DataSource = tiposDocumento;
            cboTipoDocumento.DisplayMember = "Nombre";

            List<EstadoCivil> estadosCiviles = ControlPaciente.ObtenerEstadosCiviles();
            cboEstadoCivil.DataSource = estadosCiviles;
            cboEstadoCivil.DisplayMember = "Nombre";

        }

        private void txtNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((int)e.KeyChar == 8 || 
                (int)e.KeyChar >= 48 && (int)e.KeyChar <= 59))
            {
                e.Handled = true;
            }
        }

        private void dtpFechaNacimiento_Validating(object sender, CancelEventArgs e)
        {
            if (dtpFechaNacimiento.Value > DateTime.Now)
            {
                erpMensaje.SetError(dtpFechaNacimiento, 
                    "La fecha de nacimiento debe ser menor a la fecha actual");
            }
            else
            {
                erpMensaje.SetError(dtpFechaNacimiento, string.Empty);
            }
        }

        private void btnVerListado_Click(object sender, EventArgs e)
        {
            ListadoPacientes form = new ListadoPacientes();
            form.ShowDialog();
        }
    }
}
