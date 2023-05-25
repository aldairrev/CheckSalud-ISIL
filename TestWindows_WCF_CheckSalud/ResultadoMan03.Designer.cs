namespace TestWindows_WCF_CheckSalud
{
    partial class ResultadoMan03
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
            this.label2 = new System.Windows.Forms.Label();
            this.cboPaciente = new System.Windows.Forms.ComboBox();
            this.mskAltura = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.mskPeso = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboEnfermedad = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboPsicologia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboEspirometria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboOrina = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboEkg = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboVista = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboAudicion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboRayosx = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboSangre = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRecomendacion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.mskcodResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de Resultado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Paciente:";
            // 
            // cboPaciente
            // 
            this.cboPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaciente.FormattingEnabled = true;
            this.cboPaciente.Location = new System.Drawing.Point(110, 72);
            this.cboPaciente.Name = "cboPaciente";
            this.cboPaciente.Size = new System.Drawing.Size(257, 21);
            this.cboPaciente.TabIndex = 3;
            // 
            // mskAltura
            // 
            this.mskAltura.Location = new System.Drawing.Point(266, 352);
            this.mskAltura.Mask = "9.99";
            this.mskAltura.Name = "mskAltura";
            this.mskAltura.Size = new System.Drawing.Size(67, 20);
            this.mskAltura.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(219, 357);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Altura:";
            // 
            // mskPeso
            // 
            this.mskPeso.Location = new System.Drawing.Point(112, 352);
            this.mskPeso.Mask = "999.9";
            this.mskPeso.Name = "mskPeso";
            this.mskPeso.Size = new System.Drawing.Size(67, 20);
            this.mskPeso.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(65, 357);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Peso:";
            // 
            // cboEnfermedad
            // 
            this.cboEnfermedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEnfermedad.FormattingEnabled = true;
            this.cboEnfermedad.Location = new System.Drawing.Point(110, 221);
            this.cboEnfermedad.Name = "cboEnfermedad";
            this.cboEnfermedad.Size = new System.Drawing.Size(257, 21);
            this.cboEnfermedad.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 229);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Enfermedad:";
            // 
            // cboPsicologia
            // 
            this.cboPsicologia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPsicologia.FormattingEnabled = true;
            this.cboPsicologia.Items.AddRange(new object[] {
            "--No realizo--",
            "Resultados Positivos",
            "Resultados Negativos"});
            this.cboPsicologia.Location = new System.Drawing.Point(110, 181);
            this.cboPsicologia.Name = "cboPsicologia";
            this.cboPsicologia.Size = new System.Drawing.Size(257, 21);
            this.cboPsicologia.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 34;
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
            this.cboEspirometria.Location = new System.Drawing.Point(110, 149);
            this.cboEspirometria.Name = "cboEspirometria";
            this.cboEspirometria.Size = new System.Drawing.Size(257, 21);
            this.cboEspirometria.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Espirometria:";
            // 
            // cboOrina
            // 
            this.cboOrina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrina.FormattingEnabled = true;
            this.cboOrina.Items.AddRange(new object[] {
            "--No realizo--",
            "Resultados Positivos",
            "Resultados Negativos"});
            this.cboOrina.Location = new System.Drawing.Point(110, 112);
            this.cboOrina.Name = "cboOrina";
            this.cboOrina.Size = new System.Drawing.Size(257, 21);
            this.cboOrina.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Orina:";
            // 
            // cboEkg
            // 
            this.cboEkg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEkg.FormattingEnabled = true;
            this.cboEkg.Items.AddRange(new object[] {
            "--No realizo--",
            "Resultados Positivos",
            "Resultados Negativos"});
            this.cboEkg.Location = new System.Drawing.Point(487, 221);
            this.cboEkg.Name = "cboEkg";
            this.cboEkg.Size = new System.Drawing.Size(249, 21);
            this.cboEkg.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(445, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 46;
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
            this.cboVista.Location = new System.Drawing.Point(487, 181);
            this.cboVista.Name = "cboVista";
            this.cboVista.Size = new System.Drawing.Size(249, 21);
            this.cboVista.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(441, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Vista:";
            // 
            // cboAudicion
            // 
            this.cboAudicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAudicion.FormattingEnabled = true;
            this.cboAudicion.Items.AddRange(new object[] {
            "--No realizo--",
            "Resultados Positivos",
            "Resultados Negativos"});
            this.cboAudicion.Location = new System.Drawing.Point(487, 141);
            this.cboAudicion.Name = "cboAudicion";
            this.cboAudicion.Size = new System.Drawing.Size(249, 21);
            this.cboAudicion.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(424, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Audicion:";
            // 
            // cboRayosx
            // 
            this.cboRayosx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRayosx.FormattingEnabled = true;
            this.cboRayosx.Items.AddRange(new object[] {
            "--No realizo--",
            "Resultados Positivos",
            "Resultados Negativos"});
            this.cboRayosx.Location = new System.Drawing.Point(487, 109);
            this.cboRayosx.Name = "cboRayosx";
            this.cboRayosx.Size = new System.Drawing.Size(249, 21);
            this.cboRayosx.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(424, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Rayos X:";
            // 
            // cboSangre
            // 
            this.cboSangre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSangre.FormattingEnabled = true;
            this.cboSangre.Items.AddRange(new object[] {
            "--No realizo--",
            "Resultados Positivos",
            "Resultados Negativos"});
            this.cboSangre.Location = new System.Drawing.Point(487, 72);
            this.cboSangre.Name = "cboSangre";
            this.cboSangre.Size = new System.Drawing.Size(249, 21);
            this.cboSangre.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(432, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Sangre:";
            // 
            // txtRecomendacion
            // 
            this.txtRecomendacion.Location = new System.Drawing.Point(110, 270);
            this.txtRecomendacion.Multiline = true;
            this.txtRecomendacion.Name = "txtRecomendacion";
            this.txtRecomendacion.Size = new System.Drawing.Size(626, 55);
            this.txtRecomendacion.TabIndex = 49;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 273);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 13);
            this.label14.TabIndex = 48;
            this.label14.Text = "Recomendacion:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(647, 352);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 26);
            this.btnCancelar.TabIndex = 51;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(543, 352);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(89, 26);
            this.btnGrabar.TabIndex = 50;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // mskcodResultado
            // 
            this.mskcodResultado.BackColor = System.Drawing.Color.Silver;
            this.mskcodResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskcodResultado.Location = new System.Drawing.Point(159, 25);
            this.mskcodResultado.Name = "mskcodResultado";
            this.mskcodResultado.Size = new System.Drawing.Size(100, 23);
            this.mskcodResultado.TabIndex = 52;
            this.mskcodResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResultadoMan03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(764, 401);
            this.Controls.Add(this.mskcodResultado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtRecomendacion);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cboEkg);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboVista);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboAudicion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboRayosx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboSangre);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboEnfermedad);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cboPsicologia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboEspirometria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboOrina);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mskAltura);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.mskPeso);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cboPaciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ResultadoMan03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestActualizar Resultado";
            this.Load += new System.EventHandler(this.ResultadoMan03_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPaciente;
        private System.Windows.Forms.MaskedTextBox mskAltura;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox mskPeso;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboEnfermedad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboPsicologia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboEspirometria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboOrina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboEkg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboVista;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboAudicion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboRayosx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboSangre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRecomendacion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Label mskcodResultado;
    }
}