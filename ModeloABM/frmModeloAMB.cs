using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ModeloABM
{
    public partial class frmModeloAMB : Form
    {
        List<Persona> listaPersonas = new List<Persona>();
        bool estaEditando = false;
        SqlConnection miConexion = new SqlConnection("Data Source=LAPTOP-7KUNN01M\\SQLEXPRESS;Initial Catalog=TUPPI;Integrated Security=True");
        SqlCommand miComando = null;
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
            btnBorrar.Enabled = false;
            coboxEstadoCivil.DropDownStyle = ComboBoxStyle.DropDownList;
            coboxTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public frmModeloAMB()
        {
            InitializeComponent();
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
                int index = lbPersonas.SelectedIndex;
                lbPersonas.DataSource = null;
                lbPersonas.DataSource = listaPersonas;
            }
            else
            {
                string apellido = tbApellido.Text;
                string nombre = tbNombre.Text;
                string tipoDoc = coboxTipoDocumento.Text;
                int documento;
                int.TryParse(tbDocumento.Text, out documento);
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
                agregarPersona(apellido, nombre, tipoDoc, documento, estadoCivil, sexo, fallecido);
            }
            clear();
            apagar();
            btnNuevo.Enabled = true;
            btnSalir.Enabled = true;
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
            btnSalir.Enabled = false;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnBorrar.Enabled = false;
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
            coboxEstadoCivil.Enabled = true;
            rbtnFemenino.Enabled = true;
            rbtnMasculino.Enabled = true;
            cboxFallecido.Enabled = true;
            btnCancelar.Enabled = true;
            Persona personaseleccionada = (Persona)lbPersonas.SelectedItem;
            if (personaseleccionada != null)
            {
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
            else
            {
                MessageBox.Show("No hay persona seleccionada ");
                apagar();
                btnNuevo.Enabled = true;
                btnSalir.Enabled = true;
                estaEditando = false;
            }
        }

        private void lbPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEditar.Enabled = true;
            btnBorrar.Enabled = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult siOno = MessageBox.Show("Borrar los datos de la persona seleccionada?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (siOno == DialogResult.Yes)
            {
                if (lbPersonas.SelectedItem != null)
                {
                    Persona personaSeleccionada = (Persona)lbPersonas.SelectedItem;
                    listaPersonas.Remove(personaSeleccionada);
                    btnBorrar.Enabled = false;
                    lbPersonas.DataSource = null;
                    lbPersonas.DataSource = listaPersonas;
                    clear();
                }
            }
        }

        private void frmModeloAMB_Load(object sender, EventArgs e)
        {
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
            cargarCombo(coboxTipoDocumento, "tipo_documento");
            cargarCombo(coboxEstadoCivil, "estado_civil");
            CargarLista();
        }
        private void cargarCombo(ComboBox combo, string nombreTabla)
        {
            miConexion.Open();
            miComando = new SqlCommand();
            miComando.Connection = miConexion;
            miComando.CommandType = CommandType.Text;
            miComando.CommandText = $"Select * from {nombreTabla}";
            DataTable miTabla = new DataTable();
            miTabla.Load(miComando.ExecuteReader());

            miConexion.Close();

            combo.DataSource = miTabla;
            combo.DisplayMember = miTabla.Columns[1].ColumnName;
            combo.ValueMember = miTabla.Columns[0].ColumnName;
        }
        public void agregarPersona(string apellido, string nombre, string tipoDoc, int doc, string estadoCivil, string sexo, bool fallecido)
        {
            Persona persona = new Persona(apellido, nombre, tipoDoc, doc, estadoCivil, sexo, fallecido);
            listaPersonas.Add(persona);
            lbPersonas.DataSource = null;
            lbPersonas.DataSource = listaPersonas;
            //AgregarEnDB(persona);
        }

        private void CargarLista()
        {
            miConexion.Open();
            miComando = new SqlCommand();
            miComando.Connection = miConexion;
            miComando.CommandType = CommandType.Text;
            miComando.CommandText = @"SELECT p.apellido, p.nombres, td.n_tipo_documento AS tipo_documento,
                                    p.documento, ec.n_estado_civil AS estado_civil, 
                                    p.sexo, p.fallecio
                                    FROM personas p
                                    JOIN tipo_documento td ON p.tipo_documento = td.id_tipo_documento
                                    JOIN estado_civil ec ON p.estado_civil = ec.id_estado_civil";
            SqlDataReader reader = miComando.ExecuteReader();

            while (reader.Read()) 
            {
                string apellido = reader["apellido"].ToString();
                string nombre = reader["nombres"].ToString();
                string tipoDoc = reader["tipo_documento"].ToString();
                int documento = Convert.ToInt32(reader["documento"]);
                string estadoCivil = reader["estado_civil"].ToString();
                string sexo = reader["sexo"].ToString();
                if (sexo == "1")
                {
                    sexo = "Femenino";
                }
                else if (sexo == "2") 
                {
                    sexo = "Masculino";
                }
                bool fallecido = Convert.ToBoolean(reader["fallecio"]);
                agregarPersona(apellido, nombre, tipoDoc, documento, estadoCivil, sexo, fallecido);
            }
            miConexion.Close();
        }

        //public void AgregarEnDB(Persona personaSeleccionada)
        //{
        //    //miConexion.Open();
        //    using (SqlConnection conexion = new SqlConnection("TU_CONEXION"))
        //        miComando = new SqlCommand();
        //    miComando.Connection = conexion;
        //    miComando.CommandType = CommandType.Text;
        //    miComando.CommandText = "INSERT INTO personas (apellido, nombre, tipo_documento, documento, estado_civil, sexo, fallecido) " +
        //                            "VALUES (@apellido, @nombre, @tipoDoc, @documento, @estadoCivil, @sexo, @fallecido)";
        //    miComando.Parameters.AddWithValue("@apellido", personaSeleccionada.apellido);
        //    miComando.Parameters.AddWithValue("@nombre", personaSeleccionada.nombre);
        //    miComando.Parameters.AddWithValue("@tipoDoc", personaSeleccionada.tipoDocumento);
        //    miComando.Parameters.AddWithValue("@documento", personaSeleccionada.documento);
        //    miComando.Parameters.AddWithValue("@estadoCivil", personaSeleccionada.estadoCivil);
        //    miComando.Parameters.AddWithValue("@sexo", personaSeleccionada.sexo);
        //    miComando.Parameters.AddWithValue("@fallecido", personaSeleccionada.fallecido);
            
        //    miComando.ExecuteNonQuery();
        //    //miConexion.Close();
        //}
    }
}