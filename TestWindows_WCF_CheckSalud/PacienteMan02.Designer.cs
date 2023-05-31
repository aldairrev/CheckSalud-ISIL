namespace TestWindows_WCF_CheckSalud
{
    partial class PacienteMan02
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboPaciente = new System.Windows.Forms.ComboBox();
            this.cboOrina = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPsicologia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboEspirometria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboAudicion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboRayosx = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboSangre = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboEkg = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboVista = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cboEnfermedad = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.mskPeso = new System.Windows.Forms.MaskedTextBox();
            this.mskAltura = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtRecomendacion = new System.Windows.Forms.TextBox();
            this.dtFEvaluacion = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cboMedico = new System.Windows.Forms.ComboBox();
            this.cboAuditor = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.mskCosto = new System.Windows.Forms.MaskedTextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paciente:";
            // 
            // cboPaciente
            // 
            this.cboPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaciente.FormattingEnabled = true;
            this.cboPaciente.Location = new System.Drawing.Point(126, 20);
            this.cboPaciente.Name = "cboPaciente";
            this.cboPaciente.Size = new System.Drawing.Size(169, 21);
            this.cboPaciente.TabIndex = 1;
            // 
            // cboOrina
            // 
            this.cboOrina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrina.FormattingEnabled = true;
            this.cboOrina.Items.AddRange(new object[] {
            "--No realizo--",
            "Resultados Positivos",
            "Resultados Negativos"});
            this.cboOrina.Location = new System.Drawing.Point(126, 65);
            this.cboOrina.Name = "cboOrina";
            this.cboOrina.Size = new System.Drawing.Size(257, 21);
            this.cboOrina.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Orina:";
            // 
            // cboPsicologia
            // 
            this.cboPsicologia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPsicologia.FormattingEnabled = true;
            this.cboPsicologia.Items.AddRange(new object[] {
            "--No realizo--",
            "Resultados Positivos",
            "Resultados Negativos"});
            this.cboPsicologia.Location = new System.Drawing.Point(126, 134);
            this.cboPsicologia.Name = "cboPsicologia";
            this.cboPsicologia.Size = new System.Drawing.Size(257, 21);
            this.cboPsicologia.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Psicologia:";
            // 
            // cboEspirometria
            // 
            this.cboEspirometria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEspirometria.FormattingEnabled = true;
            this.cboEspirometria.Items.AddRange(new object[] {
            "--No realizo--",
            "Resultados Positivos",
            "Resultados Negativos"});
            this.cboEspirometria.Location = new System.Drawing.Point(126, 102);
            this.cboEspirometria.Name = "cboEspirometria";
            this.cboEspirometria.Size = new System.Drawing.Size(257, 21);
            this.cboEspirometria.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Espirometria:";
            // 
            // cboAudicion
            // 
            this.cboAudicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAudicion.FormattingEnabled = true;
            this.cboAudicion.Items.AddRange(new object[] {
            "--No realizo--",
            "Resultados Positivos",
            "Resultados Negativos"});
            this.cboAudicion.Location = new System.Drawing.Point(503, 134);
            this.cboAudicion.Name = "cboAudicion";
            this.cboAudicion.Size = new System.Drawing.Size(249, 21);
            this.cboAudicion.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Audicion:";
            // 
            // cboRayosx
            // 
            this.cboRayosx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRayosx.FormattingEnabled = true;
            this.cboRayosx.Items.AddRange(new object[] {
            "--No realizo--",
            "Resultados Positivos",
            "Resultados Negativos"});
            this.cboRayosx.Location = new System.Drawing.Point(503, 102);
            this.cboRayosx.Name = "cboRayosx";
            this.cboRayosx.Size = new System.Drawing.Size(249, 21);
            this.cboRayosx.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(440, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Rayos X:";
            // 
            // cboSangre
            // 
            this.cboSangre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSangre.FormattingEnabled = true;
            this.cboSangre.Items.AddRange(new object[] {
            "--No realizo--",
            "Resultados Positivos",
            "Resultados Negativos"});
            this.cboSangre.Location = new System.Drawing.Point(503, 65);
            this.cboSangre.Name = "cboSangre";
            this.cboSangre.Size = new System.Drawing.Size(249, 21);
            this.cboSangre.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(448, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Sangre:";
            // 
            // cboEkg
            // 
            this.cboEkg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEkg.FormattingEnabled = true;
            this.cboEkg.Items.AddRange(new object[] {
            "--No realizo--",
            "Resultados Positivos",
            "Resultados Negativos"});
            this.cboEkg.Location = new System.Drawing.Point(503, 214);
            this.cboEkg.Name = "cboEkg";
            this.cboEkg.Size = new System.Drawing.Size(249, 21);
            this.cboEkg.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(461, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Ekg:";
            // 
            // cboVista
            // 
            this.cboVista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVista.FormattingEnabled = true;
            this.cboVista.Items.AddRange(new object[] {
            "--No realizo--",
            "Resultados Positivos",
            "Resultados Negativos"});
            this.cboVista.Location = new System.Drawing.Point(503, 174);
            this.cboVista.Name = "cboVista";
            this.cboVista.Size = new System.Drawing.Size(249, 21);
            this.cboVista.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(457, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Vista:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(48, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Enfermedad:";
            // 
            // cboEnfermedad
            // 
            this.cboEnfermedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEnfermedad.FormattingEnabled = true;
            this.cboEnfermedad.Location = new System.Drawing.Point(126, 174);
            this.cboEnfermedad.Name = "cboEnfermedad";
            this.cboEnfermedad.Size = new System.Drawing.Size(257, 21);
            this.cboEnfermedad.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(484, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Peso:";
            // 
            // mskPeso
            // 
            this.mskPeso.Location = new System.Drawing.Point(531, 23);
            this.mskPeso.Mask = "999.9";
            this.mskPeso.Name = "mskPeso";
            this.mskPeso.Size = new System.Drawing.Size(67, 20);
            this.mskPeso.TabIndex = 23;
            // 
            // mskAltura
            // 
            this.mskAltura.Location = new System.Drawing.Point(685, 23);
            this.mskAltura.Mask = "9.99";
            this.mskAltura.Name = "mskAltura";
            this.mskAltura.Size = new System.Drawing.Size(67, 20);
            this.mskAltura.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(638, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Altura:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 258);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Recomendacion:";
            // 
            // txtRecomendacion
            // 
            this.txtRecomendacion.Location = new System.Drawing.Point(126, 255);
            this.txtRecomendacion.Multiline = true;
            this.txtRecomendacion.Name = "txtRecomendacion";
            this.txtRecomendacion.Size = new System.Drawing.Size(626, 55);
            this.txtRecomendacion.TabIndex = 27;
            // 
            // dtFEvaluacion
            // 
            this.dtFEvaluacion.Location = new System.Drawing.Point(126, 214);
            this.dtFEvaluacion.Name = "dtFEvaluacion";
            this.dtFEvaluacion.Size = new System.Drawing.Size(228, 20);
            this.dtFEvaluacion.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "F. de Evalucion:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 338);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(166, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Medico que realizo los examenes:";
            // 
            // cboMedico
            // 
            this.cboMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMedico.FormattingEnabled = true;
            this.cboMedico.Location = new System.Drawing.Point(199, 335);
            this.cboMedico.Name = "cboMedico";
            this.cboMedico.Size = new System.Drawing.Size(179, 21);
            this.cboMedico.TabIndex = 31;
            // 
            // cboAuditor
            // 
            this.cboAuditor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAuditor.FormattingEnabled = true;
            this.cboAuditor.Location = new System.Drawing.Point(573, 333);
            this.cboAuditor.Name = "cboAuditor";
            this.cboAuditor.Size = new System.Drawing.Size(179, 21);
            this.cboAuditor.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(401, 338);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(165, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Medico que realizo la evaluación:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(36, 381);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Costo:";
            // 
            // mskCosto
            // 
            this.mskCosto.Location = new System.Drawing.Point(83, 378);
            this.mskCosto.Mask = "9999.99";
            this.mskCosto.Name = "mskCosto";
            this.mskCosto.Size = new System.Drawing.Size(67, 20);
            this.mskCosto.TabIndex = 35;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(559, 378);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(89, 26);
            this.btnGrabar.TabIndex = 36;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(663, 378);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 26);
            this.btnCancelar.TabIndex = 37;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ResultadoMan02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(775, 414);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.mskCosto);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cboAuditor);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cboMedico);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtFEvaluacion);
            this.Controls.Add(this.txtRecomendacion);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.mskAltura);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.mskPeso);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cboEnfermedad);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cboEkg);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboVista);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboAudicion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboRayosx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboSangre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboPsicologia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboEspirometria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboOrina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboPaciente);
            this.Controls.Add(this.label1);
            this.Name = "ResultadoMan02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestInsert Resultado";
            this.Load += new System.EventHandler(this.ResultadoMan02_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPaciente;
        private System.Windows.Forms.ComboBox cboOrina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPsicologia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboEspirometria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboAudicion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboRayosx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboSangre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboEkg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboVista;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboEnfermedad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox mskPeso;
        private System.Windows.Forms.MaskedTextBox mskAltura;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtRecomendacion;
        private System.Windows.Forms.DateTimePicker dtFEvaluacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboMedico;
        private System.Windows.Forms.ComboBox cboAuditor;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox mskCosto;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCancelar;
    }
}