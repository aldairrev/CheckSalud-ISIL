namespace TestWindows_WCF_CheckSalud
{
    partial class PacienteMan01
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgResultados = new System.Windows.Forms.DataGridView();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.CodPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DniPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirecPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoSangre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FotoPaciente = new System.Windows.Forms.DataGridViewImageColumn();
            this.EmailPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fec_Reg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgResultados
            // 
            this.dtgResultados.AllowUserToAddRows = false;
            this.dtgResultados.AllowUserToDeleteRows = false;
            this.dtgResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgResultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodPaciente,
            this.NomPaciente,
            this.apePaciente,
            this.FechaNacimiento,
            this.DniPaciente,
            this.Sexo,
            this.DirecPaciente,
            this.TipoSangre,
            this.FotoPaciente,
            this.EmailPaciente,
            this.FechaIngreso,
            this.NumTelefono,
            this.Estado,
            this.TipoCliente,
            this.CodEmpresa,
            this.Fec_Reg});
            this.dtgResultados.Location = new System.Drawing.Point(12, 12);
            this.dtgResultados.Name = "dtgResultados";
            this.dtgResultados.ReadOnly = true;
            this.dtgResultados.RowHeadersVisible = false;
            this.dtgResultados.RowHeadersWidth = 62;
            this.dtgResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgResultados.Size = new System.Drawing.Size(852, 380);
            this.dtgResultados.TabIndex = 0;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(589, 447);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(81, 29);
            this.btnInsertar.TabIndex = 1;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(676, 447);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(81, 29);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(783, 447);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(81, 29);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(749, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Registros:";
            // 
            // lblRegistros
            // 
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistros.Location = new System.Drawing.Point(809, 407);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(55, 24);
            this.lblRegistros.TabIndex = 5;
            this.lblRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CodPaciente
            // 
            this.CodPaciente.DataPropertyName = "CodPaciente";
            this.CodPaciente.HeaderText = "Codigo";
            this.CodPaciente.Name = "CodPaciente";
            this.CodPaciente.ReadOnly = true;
            this.CodPaciente.Width = 65;
            // 
            // NomPaciente
            // 
            this.NomPaciente.DataPropertyName = "NomPaciente";
            this.NomPaciente.HeaderText = "Nombres";
            this.NomPaciente.Name = "NomPaciente";
            this.NomPaciente.ReadOnly = true;
            this.NomPaciente.Width = 74;
            // 
            // apePaciente
            // 
            this.apePaciente.DataPropertyName = "ApePaciente";
            this.apePaciente.HeaderText = "Apellidos";
            this.apePaciente.Name = "apePaciente";
            this.apePaciente.ReadOnly = true;
            this.apePaciente.Width = 74;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.DataPropertyName = "FechaNacimiento";
            this.FechaNacimiento.HeaderText = "Fecha de Nacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            this.FechaNacimiento.Width = 122;
            // 
            // DniPaciente
            // 
            this.DniPaciente.DataPropertyName = "DniPaciente";
            this.DniPaciente.HeaderText = "DNI";
            this.DniPaciente.Name = "DniPaciente";
            this.DniPaciente.ReadOnly = true;
            this.DniPaciente.Width = 51;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.Width = 56;
            // 
            // DirecPaciente
            // 
            this.DirecPaciente.DataPropertyName = "DirecPaciente";
            this.DirecPaciente.HeaderText = "Direccion";
            this.DirecPaciente.Name = "DirecPaciente";
            this.DirecPaciente.ReadOnly = true;
            this.DirecPaciente.Width = 77;
            // 
            // TipoSangre
            // 
            this.TipoSangre.DataPropertyName = "TipoSangre";
            this.TipoSangre.HeaderText = "Tipo de Sangre";
            this.TipoSangre.Name = "TipoSangre";
            this.TipoSangre.ReadOnly = true;
            this.TipoSangre.Width = 97;
            // 
            // FotoPaciente
            // 
            this.FotoPaciente.DataPropertyName = "FotoPaciente";
            this.FotoPaciente.HeaderText = "Foto";
            this.FotoPaciente.Name = "FotoPaciente";
            this.FotoPaciente.ReadOnly = true;
            this.FotoPaciente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FotoPaciente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.FotoPaciente.Width = 53;
            // 
            // EmailPaciente
            // 
            this.EmailPaciente.DataPropertyName = "EmailPaciente";
            this.EmailPaciente.HeaderText = "Email";
            this.EmailPaciente.Name = "EmailPaciente";
            this.EmailPaciente.ReadOnly = true;
            this.EmailPaciente.Width = 57;
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.DataPropertyName = "FechaIngreso";
            this.FechaIngreso.HeaderText = "Fecha Ingreso";
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.ReadOnly = true;
            this.FechaIngreso.Width = 92;
            // 
            // NumTelefono
            // 
            this.NumTelefono.DataPropertyName = "NumTelefono";
            this.NumTelefono.HeaderText = "Telefono";
            this.NumTelefono.Name = "NumTelefono";
            this.NumTelefono.ReadOnly = true;
            this.NumTelefono.Width = 74;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 65;
            // 
            // TipoCliente
            // 
            this.TipoCliente.DataPropertyName = "TipoCliente";
            this.TipoCliente.HeaderText = "Tipo Cliente";
            this.TipoCliente.Name = "TipoCliente";
            this.TipoCliente.ReadOnly = true;
            this.TipoCliente.Width = 81;
            // 
            // CodEmpresa
            // 
            this.CodEmpresa.DataPropertyName = "CodEmpresa";
            this.CodEmpresa.HeaderText = "CodEmpresa";
            this.CodEmpresa.Name = "CodEmpresa";
            this.CodEmpresa.ReadOnly = true;
            this.CodEmpresa.Width = 92;
            // 
            // Fec_Reg
            // 
            this.Fec_Reg.DataPropertyName = "Fec_Reg";
            this.Fec_Reg.HeaderText = "Fecha Registrada";
            this.Fec_Reg.Name = "Fec_Reg";
            this.Fec_Reg.ReadOnly = true;
            this.Fec_Reg.Width = 106;
            // 
            // PacienteMan01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(883, 491);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.dtgResultados);
            this.Name = "PacienteMan01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Resultados";
            this.Load += new System.EventHandler(this.ResultadoMan01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgResultados;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn apePaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DniPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirecPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoSangre;
        private System.Windows.Forms.DataGridViewImageColumn FotoPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fec_Reg;
    }
}

