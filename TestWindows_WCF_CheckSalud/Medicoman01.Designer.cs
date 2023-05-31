using System.Windows.Forms;

namespace TestWindows_WCF_CheckSalud

{
    partial class Medicoman01
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
            this.dtgDatos = new System.Windows.Forms.DataGridView();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.codMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellNomMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniMedic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direcMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fec_ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numColegiatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Ubigeo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usu_Registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fec_Reg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDatos
            // 
            this.dtgDatos.AllowUserToAddRows = false;
            this.dtgDatos.AllowUserToDeleteRows = false;
            this.dtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codMedico,
            this.apellNomMedico,
            this.dniMedic,
            this.emailMedico,
            this.direcMedico,
            this.fechaNacimiento,
            this.fec_ingreso,
            this.Login_Usuario,
            this.numColegiatura,
            this.Id_Ubigeo,
            this.estado,
            this.Usu_Registro,
            this.Fec_Reg});
            this.dtgDatos.Location = new System.Drawing.Point(0, 12);
            this.dtgDatos.Name = "dtgDatos";
            this.dtgDatos.ReadOnly = true;
            this.dtgDatos.RowHeadersVisible = false;
            this.dtgDatos.RowHeadersWidth = 51;
            this.dtgDatos.RowTemplate.Height = 25;
            this.dtgDatos.Size = new System.Drawing.Size(1117, 443);
            this.dtgDatos.TabIndex = 2;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(895, 469);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(58, 16);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Registro";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(794, 506);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 25);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(898, 506);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(86, 25);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(1002, 506);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(86, 25);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblRegistro
            // 
            this.lblRegistro.BackColor = System.Drawing.SystemColors.Control;
            this.lblRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistro.Location = new System.Drawing.Point(959, 468);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(114, 24);
            this.lblRegistro.TabIndex = 9;
            // 
            // codMedico
            // 
            this.codMedico.DataPropertyName = "codMedico";
            this.codMedico.HeaderText = "Codigo";
            this.codMedico.MinimumWidth = 6;
            this.codMedico.Name = "codMedico";
            this.codMedico.ReadOnly = true;
            this.codMedico.Width = 125;
            // 
            // apellNomMedico
            // 
            this.apellNomMedico.DataPropertyName = "apellNomMedico";
            this.apellNomMedico.HeaderText = "Nombre y apellido";
            this.apellNomMedico.MinimumWidth = 6;
            this.apellNomMedico.Name = "apellNomMedico";
            this.apellNomMedico.ReadOnly = true;
            this.apellNomMedico.Width = 125;
            // 
            // dniMedic
            // 
            this.dniMedic.DataPropertyName = "dniMedic";
            this.dniMedic.HeaderText = "DNI";
            this.dniMedic.MinimumWidth = 6;
            this.dniMedic.Name = "dniMedic";
            this.dniMedic.ReadOnly = true;
            this.dniMedic.Width = 125;
            // 
            // emailMedico
            // 
            this.emailMedico.DataPropertyName = "emailMedico";
            this.emailMedico.HeaderText = "Email";
            this.emailMedico.MinimumWidth = 6;
            this.emailMedico.Name = "emailMedico";
            this.emailMedico.ReadOnly = true;
            this.emailMedico.Width = 125;
            // 
            // direcMedico
            // 
            this.direcMedico.DataPropertyName = "direcMedico";
            this.direcMedico.HeaderText = "Direccion";
            this.direcMedico.MinimumWidth = 6;
            this.direcMedico.Name = "direcMedico";
            this.direcMedico.ReadOnly = true;
            this.direcMedico.Width = 125;
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.DataPropertyName = "fechaNacimiento";
            this.fechaNacimiento.HeaderText = "F. de nacimiento";
            this.fechaNacimiento.MinimumWidth = 6;
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.ReadOnly = true;
            this.fechaNacimiento.Width = 125;
            // 
            // fec_ingreso
            // 
            this.fec_ingreso.DataPropertyName = "fec_ingreso";
            this.fec_ingreso.HeaderText = "F. de ingreso";
            this.fec_ingreso.MinimumWidth = 6;
            this.fec_ingreso.Name = "fec_ingreso";
            this.fec_ingreso.ReadOnly = true;
            this.fec_ingreso.Width = 125;
            // 
            // Login_Usuario
            // 
            this.Login_Usuario.DataPropertyName = "Login_Usuario";
            this.Login_Usuario.HeaderText = "Usuario";
            this.Login_Usuario.MinimumWidth = 6;
            this.Login_Usuario.Name = "Login_Usuario";
            this.Login_Usuario.ReadOnly = true;
            this.Login_Usuario.Width = 125;
            // 
            // numColegiatura
            // 
            this.numColegiatura.DataPropertyName = "numColegiatura";
            this.numColegiatura.HeaderText = "Colegiatura";
            this.numColegiatura.MinimumWidth = 6;
            this.numColegiatura.Name = "numColegiatura";
            this.numColegiatura.ReadOnly = true;
            this.numColegiatura.Width = 125;
            // 
            // Id_Ubigeo
            // 
            this.Id_Ubigeo.DataPropertyName = "Id_Ubigeo";
            this.Id_Ubigeo.HeaderText = "Ubigeo";
            this.Id_Ubigeo.MinimumWidth = 6;
            this.Id_Ubigeo.Name = "Id_Ubigeo";
            this.Id_Ubigeo.ReadOnly = true;
            this.Id_Ubigeo.Width = 125;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 125;
            // 
            // Usu_Registro
            // 
            this.Usu_Registro.DataPropertyName = "Usu_Registro";
            this.Usu_Registro.HeaderText = "Usu. registro";
            this.Usu_Registro.MinimumWidth = 6;
            this.Usu_Registro.Name = "Usu_Registro";
            this.Usu_Registro.ReadOnly = true;
            this.Usu_Registro.Width = 125;
            // 
            // Fec_Reg
            // 
            this.Fec_Reg.DataPropertyName = "Fec_Reg";
            this.Fec_Reg.HeaderText = "F. de registro";
            this.Fec_Reg.MinimumWidth = 6;
            this.Fec_Reg.Name = "Fec_Reg";
            this.Fec_Reg.ReadOnly = true;
            this.Fec_Reg.Width = 125;
            // 
            // Medicoman01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1130, 535);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.dtgDatos);
            this.Name = "Medicoman01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Medicos";
            this.Load += new System.EventHandler(this.Medicoman01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dtgDatos;
        private Label lbl2;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnCerrar;
        private Label lblRegistro;
        private DataGridViewTextBoxColumn codMedico;
        private DataGridViewTextBoxColumn apellNomMedico;
        private DataGridViewTextBoxColumn dniMedic;
        private DataGridViewTextBoxColumn emailMedico;
        private DataGridViewTextBoxColumn direcMedico;
        private DataGridViewTextBoxColumn fechaNacimiento;
        private DataGridViewTextBoxColumn fec_ingreso;
        private DataGridViewTextBoxColumn Login_Usuario;
        private DataGridViewTextBoxColumn numColegiatura;
        private DataGridViewTextBoxColumn Id_Ubigeo;
        private DataGridViewTextBoxColumn estado;
        private DataGridViewTextBoxColumn Usu_Registro;
        private DataGridViewTextBoxColumn Fec_Reg;
    }
}