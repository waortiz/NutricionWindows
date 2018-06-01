namespace Nutricion
{
    partial class ListadoPacientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvListadoPacientes = new System.Windows.Forms.DataGridView();
            this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimerNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SegundoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimerApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SegundoApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListadoPacientes
            // 
            this.dgvListadoPacientes.AllowUserToAddRows = false;
            this.dgvListadoPacientes.AllowUserToDeleteRows = false;
            this.dgvListadoPacientes.AllowUserToOrderColumns = true;
            this.dgvListadoPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroDocumento,
            this.PrimerNombre,
            this.SegundoNombre,
            this.PrimerApellido,
            this.SegundoApellido});
            this.dgvListadoPacientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListadoPacientes.Location = new System.Drawing.Point(0, 0);
            this.dgvListadoPacientes.Name = "dgvListadoPacientes";
            this.dgvListadoPacientes.ReadOnly = true;
            this.dgvListadoPacientes.Size = new System.Drawing.Size(1184, 570);
            this.dgvListadoPacientes.TabIndex = 0;
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.DataPropertyName = "NumeroDocumento";
            this.NumeroDocumento.FillWeight = 200F;
            this.NumeroDocumento.Frozen = true;
            this.NumeroDocumento.HeaderText = "Número de Documento";
            this.NumeroDocumento.Name = "NumeroDocumento";
            this.NumeroDocumento.ReadOnly = true;
            this.NumeroDocumento.Width = 200;
            // 
            // PrimerNombre
            // 
            this.PrimerNombre.DataPropertyName = "PrimerNombre";
            this.PrimerNombre.Frozen = true;
            this.PrimerNombre.HeaderText = "Primer Nombre";
            this.PrimerNombre.Name = "PrimerNombre";
            this.PrimerNombre.ReadOnly = true;
            this.PrimerNombre.Width = 200;
            // 
            // SegundoNombre
            // 
            this.SegundoNombre.DataPropertyName = "SegundoNombre";
            this.SegundoNombre.Frozen = true;
            this.SegundoNombre.HeaderText = "Segundo Nombre";
            this.SegundoNombre.Name = "SegundoNombre";
            this.SegundoNombre.ReadOnly = true;
            this.SegundoNombre.Width = 200;
            // 
            // PrimerApellido
            // 
            this.PrimerApellido.DataPropertyName = "PrimerApellido";
            this.PrimerApellido.Frozen = true;
            this.PrimerApellido.HeaderText = "Primer Apellido";
            this.PrimerApellido.Name = "PrimerApellido";
            this.PrimerApellido.ReadOnly = true;
            this.PrimerApellido.Width = 200;
            // 
            // SegundoApellido
            // 
            this.SegundoApellido.DataPropertyName = "SegundoApellido";
            this.SegundoApellido.Frozen = true;
            this.SegundoApellido.HeaderText = "Segundo Apellido";
            this.SegundoApellido.Name = "SegundoApellido";
            this.SegundoApellido.ReadOnly = true;
            this.SegundoApellido.Width = 200;
            // 
            // ListadoPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 570);
            this.Controls.Add(this.dgvListadoPacientes);
            this.Name = "ListadoPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadoPacientes";
            this.Load += new System.EventHandler(this.ListadoPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoPacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimerNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn SegundoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimerApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn SegundoApellido;
    }
}