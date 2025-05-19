using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModeloABM
{
    public partial class frmModeloAMB : Form
    {
        bool estaEditando = false;
        public void apagar()
        {
            tbApellido.Enabled = false;
            tbNombre.Enabled = false;
            coboxTipoDocumento.Enabled = false;
            tbDocumento.Enabled = false;
            coboxEstadoCivil.Enabled = false;
            rbtnFemenino.Enabled = false;
            rbtnMasculino.Enabled = false;
            cboxFallecido.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
        }
        public frmModeloAMB()
        {
            InitializeComponent();
            apagar();
            btnBorrar.Enabled = false;
            btnGrabar.Enabled = false;
            tbApellido.TextChanged += validarCampos;
            tbNombre.TextChanged += validarCampos;
            coboxTipoDocumento.TextChanged += validarCampos;
            tbDocumento.TextChanged += validarCampos;
            coboxEstadoCivil.TextChanged += validarCampos;
            rbtnFemenino.CheckedChanged += validarCampos;
            rbtnMasculino.CheckedChanged += validarCampos;
        }

        private void validarCampos(object sender, EventArgs e)
        {
            bool apeValido = !string.IsNullOrWhiteSpace(tbApellido.Text);
            bool nomValido = !string.IsNullOrWhiteSpace(tbNombre.Text);
            bool tipoDocValido = !string.IsNullOrWhiteSpace(coboxTipoDocumento.Text);
            bool docValido = !string.IsNullOrWhiteSpace(tbDocumento.Text);
            bool estadoCivilValido = !string.IsNullOrWhiteSpace(coboxEstadoCivil.Text);
            bool sexoValidado = rbtnFemenino.Checked || rbtnMasculino.Checked;
            btnGrabar.Enabled = apeValido && nomValido && tipoDocValido && estadoCivilValido && sexoValidado;
        }

        public void clear()
        {
            tbApellido.Clear();
            tbNombre.Clear();
            tbDocumento.Clear();
            coboxTipoDocumento.SelectedIndex = -1;
            coboxEstadoCivil.SelectedIndex = -1;
            rbtnFemenino.Checked = false;
            rbtnMasculino.Checked = false;
            cboxFallecido.Checked = false;
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (estaEditando)
            {
                Persona personaseleccionada = (Persona)lbPersonas.SelectedItem;
                personaseleccionada.apellido = tbApellido.Text;
                personaseleccionada.nombre = tbNombre.Text;
                personaseleccionada.tipoDocumento = coboxTipoDocumento.Text;
                personaseleccionada.documento = int.Parse(tbDocumento.Text);
                personaseleccionada.estadoCivil = coboxEstadoCivil.Text;
                personaseleccionada.fallecido = cboxFallecido.Checked;
                estaEditando = false;
                clear();
                apagar();
                int index = lbPersonas.SelectedIndex;
                lbPersonas.Items[index] = personaseleccionada;
            }
            else
            {
                string apellido = tbApellido.Text;
                string nombre = tbNombre.Text;
                string tipoDoc = coboxTipoDocumento.Text;
                int doc;
                int.TryParse(tbDocumento.Text, out doc);
                string estadoCivil = coboxEstadoCivil.Text;
                string sexo = " ";
                bool fallecido = cboxFallecido.Checked;
                if (rbtnFemenino.Checked)
                {
                    sexo = "Femenino";
                }
                else if (rbtnMasculino.Checked)
                {
                    sexo = "Masculino";
                }
                Persona persona = new Persona(apellido, nombre, tipoDoc, doc, estadoCivil, sexo, fallecido);
                lbPersonas.Items.Add(persona);
                clear();
                apagar();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult siOno = MessageBox.Show("Desea salir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (siOno == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tbApellido.Enabled = true;
            tbNombre.Enabled = true;
            coboxTipoDocumento.Enabled = true;
            tbDocumento.Enabled = true;
            coboxEstadoCivil.Enabled = true;
            rbtnFemenino.Enabled = true;
            rbtnMasculino.Enabled = true;
            cboxFallecido.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clear();
            apagar();
            btnNuevo.Enabled = true;
            btnSalir.Enabled = true;
            estaEditando = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnSalir.Enabled = false;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnBorrar.Enabled = false;
            estaEditando = true;
            tbApellido.Enabled = true;
            tbNombre.Enabled = true;
            coboxTipoDocumento.Enabled = true;
            tbDocumento.Enabled = true;
            coboxEstadoCivil.Enabled = true;
            rbtnFemenino.Enabled = true;
            rbtnMasculino.Enabled = true;
            cboxFallecido.Enabled = true;
            btnCancelar.Enabled = true;
            Persona personaseleccionada = (Persona)lbPersonas.SelectedItem;
            tbApellido.Text = personaseleccionada.apellido;
            tbNombre.Text = personaseleccionada.nombre;
            coboxTipoDocumento.Text = personaseleccionada.tipoDocumento;
            if (personaseleccionada.sexo == "Femenino")
            {
                rbtnFemenino.Checked = true;
            }
            else if (personaseleccionada.sexo == "Masculino")
            {
                rbtnMasculino.Checked = true;
            }
            cboxFallecido.Checked = personaseleccionada.fallecido;
            string documento = Convert.ToString(personaseleccionada.documento);
            tbDocumento.Text = documento;
            coboxEstadoCivil.Text = personaseleccionada.estadoCivil;
        }

        private void lbPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEditar.Enabled = true;
            btnBorrar.Enabled = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(lbPersonas.SelectedItem != null)
            {
                lbPersonas.Items.Remove(lbPersonas.SelectedItem);
            }
        }
    }
}