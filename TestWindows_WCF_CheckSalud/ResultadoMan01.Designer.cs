namespace TestWindows_WCF_CheckSalud
{
    partial class ResultadoMan01
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgResultados = new System.Windows.Forms.DataGridView();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.CodResultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomApePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sangre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ekg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spirometria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.psicologia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rayosx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.audicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recomendaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgResultados
            // 
            this.dtgResultados.AllowUserToAddRows = false;
            this.dtgResultados.AllowUserToDeleteRows = false;
            this.dtgResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgResultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodResultado,
            this.NomApePaciente,
            this.peso,
            this.altura,
            this.sangre,
            this.orina,
            this.ekg,
            this.spirometria,
            this.psicologia,
            this.rayosx,
            this.audicion,
            this.vista,
            this.recomendaciones});
            this.dtgResultados.Location = new System.Drawing.Point(12, 12);
            this.dtgResultados.Name = "dtgResultados";
            this.dtgResultados.ReadOnly = true;
            this.dtgResultados.RowHeadersVisible = false;
            this.dtgResultados.RowHeadersWidth = 62;
            this.dtgResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgResultados.Size = new System.Drawing.Size(852, 361);
            this.dtgResultados.TabIndex = 0;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(589, 432);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(81, 29);
            this.btnInsertar.TabIndex = 1;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(676, 432);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(81, 29);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(783, 432);
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
            this.label1.Location = new System.Drawing.Point(749, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Registros:";
            // 
            // lblRegistros
            // 
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistros.Location = new System.Drawing.Point(809, 392);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(55, 24);
            this.lblRegistros.TabIndex = 5;
            this.lblRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CodResultado
            // 
            this.CodResultado.DataPropertyName = "CodResultado";
            this.CodResultado.HeaderText = "Codigo";
            this.CodResultado.Name = "CodResultado";
            this.CodResultado.ReadOnly = true;
            this.CodResultado.Width = 65;
            // 
            // NomApePaciente
            // 
            this.NomApePaciente.DataPropertyName = "NomApePaciente";
            this.NomApePaciente.HeaderText = "Nombres y Apellidos";
            this.NomApePaciente.Name = "NomApePaciente";
            this.NomApePaciente.ReadOnly = true;
            this.NomApePaciente.Width = 116;
            // 
            // peso
            // 
            this.peso.DataPropertyName = "peso";
            this.peso.HeaderText = "Peso";
            this.peso.Name = "peso";
            this.peso.ReadOnly = true;
            this.peso.Width = 56;
            // 
            // altura
            // 
            this.altura.DataPropertyName = "altura";
            this.altura.HeaderText = "Altura";
            this.altura.Name = "altura";
            this.altura.ReadOnly = true;
            this.altura.Width = 59;
            // 
            // sangre
            // 
            this.sangre.DataPropertyName = "sangre";
            this.sangre.HeaderText = "Sangre";
            this.sangre.Name = "sangre";
            this.sangre.ReadOnly = true;
            this.sangre.Width = 66;
            // 
            // orina
            // 
            this.orina.DataPropertyName = "orina";
            this.orina.HeaderText = "Orina";
            this.orina.Name = "orina";
            this.orina.ReadOnly = true;
            this.orina.Width = 57;
            // 
            // ekg
            // 
            this.ekg.DataPropertyName = "ekg";
            this.ekg.HeaderText = "EKG";
            this.ekg.Name = "ekg";
            this.ekg.ReadOnly = true;
            this.ekg.Width = 54;
            // 
            // spirometria
            // 
            this.spirometria.DataPropertyName = "spirometria";
            this.spirometria.HeaderText = "Spirometria";
            this.spirometria.Name = "spirometria";
            this.spirometria.ReadOnly = true;
            this.spirometria.Width = 84;
            // 
            // psicologia
            // 
            this.psicologia.DataPropertyName = "psicologia";
            this.psicologia.HeaderText = "Psicologia";
            this.psicologia.Name = "psicologia";
            this.psicologia.ReadOnly = true;
            this.psicologia.Width = 80;
            // 
            // rayosx
            // 
            this.rayosx.DataPropertyName = "rayosx";
            this.rayosx.HeaderText = "Rayos X";
            this.rayosx.Name = "rayosx";
            this.rayosx.ReadOnly = true;
            this.rayosx.Width = 67;
            // 
            // audicion
            // 
            this.audicion.DataPropertyName = "audicion";
            this.audicion.HeaderText = "Audicion";
            this.audicion.Name = "audicion";
            this.audicion.ReadOnly = true;
            this.audicion.Width = 73;
            // 
            // vista
            // 
            this.vista.DataPropertyName = "vista";
            this.vista.HeaderText = "Vista";
            this.vista.Name = "vista";
            this.vista.ReadOnly = true;
            this.vista.Width = 55;
            // 
            // recomendaciones
            // 
            this.recomendaciones.DataPropertyName = "recomendaciones";
            this.recomendaciones.HeaderText = "Recomendaciones";
            this.recomendaciones.Name = "recomendaciones";
            this.recomendaciones.ReadOnly = true;
            this.recomendaciones.Width = 121;
            // 
            // ResultadoMan01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 473);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.dtgResultados);
            this.Name = "ResultadoMan01";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn CodResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomApePaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn altura;
        private System.Windows.Forms.DataGridViewTextBoxColumn sangre;
        private System.Windows.Forms.DataGridViewTextBoxColumn orina;
        private System.Windows.Forms.DataGridViewTextBoxColumn ekg;
        private System.Windows.Forms.DataGridViewTextBoxColumn spirometria;
        private System.Windows.Forms.DataGridViewTextBoxColumn psicologia;
        private System.Windows.Forms.DataGridViewTextBoxColumn rayosx;
        private System.Windows.Forms.DataGridViewTextBoxColumn audicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn vista;
        private System.Windows.Forms.DataGridViewTextBoxColumn recomendaciones;
    }
}

