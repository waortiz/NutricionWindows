using Nutricion.Control;
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
    public partial class ListadoPacientes : Form
    {
        public ListadoPacientes()
        {
            InitializeComponent();
        }

        private void ListadoPacientes_Load(object sender, EventArgs e)
        {

        }

        public void EliminarPaciente()
        {
            if (dgvPacientes.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Está seguro de eliminar el paciente",
                                   this.Text, MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        long idPaciente = ((Entidades.Paciente)(dgvPacientes.SelectedRows[0].DataBoundItem)).Id;
                        ControlPaciente.EliminarPaciente(idPaciente);
                        ConsultarPacientes();
                        MessageBox.Show("El paciente se eliminó correctamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("No se pudo eliminar el paciente. " + exc.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public Paciente ObtenerPacienteSeleccionado()
        {
            if (dgvPacientes.SelectedRows.Count > 0)
                return (Paciente)(dgvPacientes.SelectedRows[0].DataBoundItem);
            else
                return null;
        }

        private void ConsultarPacientes()
        {
            long? numeroDocumento = null;
            if (!string.IsNullOrEmpty(txtNumeroDocumento.Text))
            {
                numeroDocumento = long.Parse(txtNumeroDocumento.Text);
            }

            dgvPacientes.AutoGenerateColumns = false;
            dgvPacientes.DataSource = ControlPaciente.ConsultarPacientes(numeroDocumento, txtPrimerNombre.Text, txtSegundoNombre.Text, txtPrimerApellido.Text, txtSegundoApellido.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarPaciente();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ConsultarPacientes();
        }
    }
}
