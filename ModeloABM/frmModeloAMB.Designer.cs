using System.Windows.Forms;

namespace ModeloABM
{
    partial class frmModeloAMB
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbPersonas = new System.Windows.Forms.ListBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.tableDatos = new System.Windows.Forms.TableLayoutPanel();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblFallecido = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.coboxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.coboxEstadoCivil = new System.Windows.Forms.ComboBox();
            this.tbDocumento = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rbtnFemenino = new System.Windows.Forms.RadioButton();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.cboxFallecido = new System.Windows.Forms.CheckBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tableBotones = new System.Windows.Forms.TableLayoutPanel();
            this.tableDatos.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPersonas
            // 
            this.lbPersonas.FormattingEnabled = true;
            this.lbPersonas.ItemHeight = 16;
            this.lbPersonas.Location = new System.Drawing.Point(545, 27);
            this.lbPersonas.Name = "lbPersonas";
            this.lbPersonas.Size = new System.Drawing.Size(221, 356);
            this.lbPersonas.TabIndex = 7;
            this.lbPersonas.SelectedIndexChanged += new System.EventHandler(this.lbPersonas_SelectedIndexChanged);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNuevo.Location = new System.Drawing.Point(21, 6);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.Location = new System.Drawing.Point(613, 6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Location = new System.Drawing.Point(491, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGrabar.Location = new System.Drawing.Point(375, 6);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 3;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBorrar.Location = new System.Drawing.Point(257, 6);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.Location = new System.Drawing.Point(139, 6);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // tableDatos
            // 
            this.tableDatos.ColumnCount = 2;
            this.tableDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableDatos.Controls.Add(this.lblApellido, 0, 0);
            this.tableDatos.Controls.Add(this.lblNombre, 0, 1);
            this.tableDatos.Controls.Add(this.lblTipoDoc, 0, 2);
            this.tableDatos.Controls.Add(this.lblDocumento, 0, 3);
            this.tableDatos.Controls.Add(this.lblEstadoCivil, 0, 4);
            this.tableDatos.Controls.Add(this.lblSexo, 0, 5);
            this.tableDatos.Controls.Add(this.lblFallecido, 0, 6);
            this.tableDatos.Controls.Add(this.tbApellido, 1, 0);
            this.tableDatos.Controls.Add(this.coboxTipoDocumento, 1, 2);
            this.tableDatos.Controls.Add(this.coboxEstadoCivil, 1, 4);
            this.tableDatos.Controls.Add(this.tbDocumento, 1, 3);
            this.tableDatos.Controls.Add(this.tableLayoutPanel1, 1, 5);
            this.tableDatos.Controls.Add(this.cboxFallecido, 1, 6);
            this.tableDatos.Controls.Add(this.tbNombre, 1, 1);
            this.tableDatos.Location = new System.Drawing.Point(32, 27);
            this.tableDatos.Name = "tableDatos";
            this.tableDatos.RowCount = 7;
            this.tableDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.29F));
            this.tableDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.29F));
            this.tableDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.29F));
            this.tableDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.29F));
            this.tableDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.29F));
            this.tableDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.29214F));
            this.tableDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.48315F));
            this.tableDatos.Size = new System.Drawing.Size(493, 356);
            this.tableDatos.TabIndex = 0;
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(186, 17);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(57, 16);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(187, 67);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(136, 117);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(107, 16);
            this.lblTipoDoc.TabIndex = 4;
            this.lblTipoDoc.Text = "Tipo Documento";
            // 
            // lblDocumento
            // 
            this.lblDocumento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(167, 167);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(76, 16);
            this.lblDocumento.TabIndex = 6;
            this.lblDocumento.Text = "Documento";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(165, 217);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(78, 16);
            this.lblEstadoCivil.TabIndex = 8;
            this.lblEstadoCivil.Text = "Estado Civil";
            // 
            // lblSexo
            // 
            this.lblSexo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(205, 270);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(38, 16);
            this.lblSexo.TabIndex = 10;
            this.lblSexo.Text = "Sexo";
            // 
            // lblFallecido
            // 
            this.lblFallecido.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFallecido.AutoSize = true;
            this.lblFallecido.Location = new System.Drawing.Point(180, 323);
            this.lblFallecido.Name = "lblFallecido";
            this.lblFallecido.Size = new System.Drawing.Size(63, 16);
            this.lblFallecido.TabIndex = 12;
            this.lblFallecido.Text = "Fallecido";
            // 
            // tbApellido
            // 
            this.tbApellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbApellido.Location = new System.Drawing.Point(249, 14);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(200, 22);
            this.tbApellido.TabIndex = 2;
            // 
            // coboxTipoDocumento
            // 
            this.coboxTipoDocumento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.coboxTipoDocumento.FormattingEnabled = true;
            this.coboxTipoDocumento.Location = new System.Drawing.Point(249, 113);
            this.coboxTipoDocumento.Name = "coboxTipoDocumento";
            this.coboxTipoDocumento.Size = new System.Drawing.Size(200, 24);
            this.coboxTipoDocumento.TabIndex = 5;
            // 
            // coboxEstadoCivil
            // 
            this.coboxEstadoCivil.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.coboxEstadoCivil.FormattingEnabled = true;
            this.coboxEstadoCivil.Items.AddRange(new object[] {
            "Soltero/a",
            "Casado/a"});
            this.coboxEstadoCivil.Location = new System.Drawing.Point(249, 213);
            this.coboxEstadoCivil.Name = "coboxEstadoCivil";
            this.coboxEstadoCivil.Size = new System.Drawing.Size(200, 24);
            this.coboxEstadoCivil.TabIndex = 9;
            // 
            // tbDocumento
            // 
            this.tbDocumento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbDocumento.Location = new System.Drawing.Point(249, 164);
            this.tbDocumento.Name = "tbDocumento";
            this.tbDocumento.Size = new System.Drawing.Size(200, 22);
            this.tbDocumento.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29F));
            this.tableLayoutPanel1.Controls.Add(this.rbtnFemenino, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rbtnMasculino, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(249, 253);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 51);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // rbtnFemenino
            // 
            this.rbtnFemenino.AutoSize = true;
            this.rbtnFemenino.Location = new System.Drawing.Point(3, 3);
            this.rbtnFemenino.Name = "rbtnFemenino";
            this.rbtnFemenino.Size = new System.Drawing.Size(88, 19);
            this.rbtnFemenino.TabIndex = 0;
            this.rbtnFemenino.TabStop = true;
            this.rbtnFemenino.Text = "Femenino";
            this.rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(3, 28);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(89, 20);
            this.rbtnMasculino.TabIndex = 1;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // cboxFallecido
            // 
            this.cboxFallecido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboxFallecido.AutoSize = true;
            this.cboxFallecido.Location = new System.Drawing.Point(249, 323);
            this.cboxFallecido.Name = "cboxFallecido";
            this.cboxFallecido.Size = new System.Drawing.Size(18, 17);
            this.cboxFallecido.TabIndex = 13;
            this.cboxFallecido.UseVisualStyleBackColor = true;
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbNombre.Location = new System.Drawing.Point(249, 64);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(200, 22);
            this.tbNombre.TabIndex = 2;
            // 
            // tableBotones
            // 
            this.tableBotones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableBotones.ColumnCount = 6;
            this.tableBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableBotones.Controls.Add(this.btnNuevo, 0, 0);
            this.tableBotones.Controls.Add(this.btnSalir, 5, 0);
            this.tableBotones.Controls.Add(this.btnCancelar, 4, 0);
            this.tableBotones.Controls.Add(this.btnGrabar, 3, 0);
            this.tableBotones.Controls.Add(this.btnBorrar, 2, 0);
            this.tableBotones.Controls.Add(this.btnEditar, 1, 0);
            this.tableBotones.Location = new System.Drawing.Point(32, 403);
            this.tableBotones.Name = "tableBotones";
            this.tableBotones.RowCount = 1;
            this.tableBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableBotones.Size = new System.Drawing.Size(712, 35);
            this.tableBotones.TabIndex = 2;
            // 
            // frmModeloAMB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableDatos);
            this.Controls.Add(this.lbPersonas);
            this.Controls.Add(this.tableBotones);
            this.Name = "frmModeloAMB";
            this.RightToLeftLayout = true;
            this.Text = "A B M Personas";
            this.Load += new System.EventHandler(this.frmModeloAMB_Load);
            this.tableDatos.ResumeLayout(false);
            this.tableDatos.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lbPersonas;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private TableLayoutPanel tableDatos;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblTipoDoc;
        private Label lblDocumento;
        private Label lblEstadoCivil;
        private Label lblSexo;
        private Label lblFallecido;
        private TextBox tbApellido;
        private TextBox tbNombre;
        private ComboBox coboxTipoDocumento;
        private ComboBox coboxEstadoCivil;
        private TextBox tbDocumento;
        private TableLayoutPanel tableLayoutPanel1;
        private RadioButton rbtnFemenino;
        private RadioButton rbtnMasculino;
        private CheckBox cboxFallecido;
        private TableLayoutPanel tableBotones;
    }
}

