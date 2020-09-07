namespace SistemaColegioEF.Formularios
{
    partial class frmCalificaciones
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
            this.tabNotas = new System.Windows.Forms.TabControl();
            this.tpGestionNotas = new System.Windows.Forms.TabPage();
            this.btnAgregarNota = new System.Windows.Forms.Button();
            this.dtpFechaCalificacion = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cboTrimestres = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNota = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMaterias = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboAlumnos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboProfesores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboAños = new System.Windows.Forms.ComboBox();
            this.lblAñoCalif = new System.Windows.Forms.Label();
            this.dgvCalificaciones = new System.Windows.Forms.DataGridView();
            this.tpBusqNotas = new System.Windows.Forms.TabPage();
            this.dgvCalifBusqueda = new System.Windows.Forms.DataGridView();
            this.gbBusquedaNotas = new System.Windows.Forms.GroupBox();
            this.lblAñoLectivoBusq = new System.Windows.Forms.Label();
            this.dtpFechaCalifBusq = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBusqNotas = new System.Windows.Forms.Button();
            this.cboMateriaBusq = new System.Windows.Forms.ComboBox();
            this.cboAñoBusqNota = new System.Windows.Forms.ComboBox();
            this.tbDniBusqNotas = new System.Windows.Forms.TextBox();
            this.rbBusqxAñoMat = new System.Windows.Forms.RadioButton();
            this.rbBusqCalifxDni = new System.Windows.Forms.RadioButton();
            this.btnCerrarNota = new System.Windows.Forms.Button();
            this.tabNotas.SuspendLayout();
            this.tpGestionNotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificaciones)).BeginInit();
            this.tpBusqNotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalifBusqueda)).BeginInit();
            this.gbBusquedaNotas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabNotas
            // 
            this.tabNotas.Controls.Add(this.tpGestionNotas);
            this.tabNotas.Controls.Add(this.tpBusqNotas);
            this.tabNotas.Location = new System.Drawing.Point(3, 4);
            this.tabNotas.Name = "tabNotas";
            this.tabNotas.SelectedIndex = 0;
            this.tabNotas.Size = new System.Drawing.Size(1130, 476);
            this.tabNotas.TabIndex = 0;
            this.tabNotas.SelectedIndexChanged += new System.EventHandler(this.tabNotas_SelectedIndexChanged);
            // 
            // tpGestionNotas
            // 
            this.tpGestionNotas.BackgroundImage = global::SistemaColegioEF.Properties.Resources.rosacolor;
            this.tpGestionNotas.Controls.Add(this.btnCerrarNota);
            this.tpGestionNotas.Controls.Add(this.btnAgregarNota);
            this.tpGestionNotas.Controls.Add(this.dtpFechaCalificacion);
            this.tpGestionNotas.Controls.Add(this.label6);
            this.tpGestionNotas.Controls.Add(this.cboTrimestres);
            this.tpGestionNotas.Controls.Add(this.label5);
            this.tpGestionNotas.Controls.Add(this.tbNota);
            this.tpGestionNotas.Controls.Add(this.label4);
            this.tpGestionNotas.Controls.Add(this.cboMaterias);
            this.tpGestionNotas.Controls.Add(this.label3);
            this.tpGestionNotas.Controls.Add(this.cboAlumnos);
            this.tpGestionNotas.Controls.Add(this.label2);
            this.tpGestionNotas.Controls.Add(this.cboProfesores);
            this.tpGestionNotas.Controls.Add(this.label1);
            this.tpGestionNotas.Controls.Add(this.cboAños);
            this.tpGestionNotas.Controls.Add(this.lblAñoCalif);
            this.tpGestionNotas.Controls.Add(this.dgvCalificaciones);
            this.tpGestionNotas.Location = new System.Drawing.Point(4, 22);
            this.tpGestionNotas.Name = "tpGestionNotas";
            this.tpGestionNotas.Padding = new System.Windows.Forms.Padding(3);
            this.tpGestionNotas.Size = new System.Drawing.Size(1122, 450);
            this.tpGestionNotas.TabIndex = 0;
            this.tpGestionNotas.Text = "Gestion de Notas";
            this.tpGestionNotas.UseVisualStyleBackColor = true;
            // 
            // btnAgregarNota
            // 
            this.btnAgregarNota.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnAgregarNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarNota.Location = new System.Drawing.Point(109, 333);
            this.btnAgregarNota.Name = "btnAgregarNota";
            this.btnAgregarNota.Size = new System.Drawing.Size(117, 33);
            this.btnAgregarNota.TabIndex = 31;
            this.btnAgregarNota.Text = "Agregar";
            this.btnAgregarNota.UseVisualStyleBackColor = false;
            this.btnAgregarNota.Click += new System.EventHandler(this.btnAgregarNota_Click);
            // 
            // dtpFechaCalificacion
            // 
            this.dtpFechaCalificacion.Location = new System.Drawing.Point(89, 239);
            this.dtpFechaCalificacion.Name = "dtpFechaCalificacion";
            this.dtpFechaCalificacion.Size = new System.Drawing.Size(250, 20);
            this.dtpFechaCalificacion.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(21, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Fecha:";
            // 
            // cboTrimestres
            // 
            this.cboTrimestres.FormattingEnabled = true;
            this.cboTrimestres.Location = new System.Drawing.Point(232, 197);
            this.cboTrimestres.Name = "cboTrimestres";
            this.cboTrimestres.Size = new System.Drawing.Size(107, 21);
            this.cboTrimestres.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(144, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Trimestre:";
            // 
            // tbNota
            // 
            this.tbNota.Location = new System.Drawing.Point(89, 198);
            this.tbNota.Name = "tbNota";
            this.tbNota.Size = new System.Drawing.Size(54, 20);
            this.tbNota.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(31, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Nota:";
            // 
            // cboMaterias
            // 
            this.cboMaterias.Enabled = false;
            this.cboMaterias.FormattingEnabled = true;
            this.cboMaterias.Location = new System.Drawing.Point(89, 151);
            this.cboMaterias.Name = "cboMaterias";
            this.cboMaterias.Size = new System.Drawing.Size(250, 21);
            this.cboMaterias.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(13, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Materia:";
            // 
            // cboAlumnos
            // 
            this.cboAlumnos.Enabled = false;
            this.cboAlumnos.FormattingEnabled = true;
            this.cboAlumnos.Location = new System.Drawing.Point(89, 104);
            this.cboAlumnos.Name = "cboAlumnos";
            this.cboAlumnos.Size = new System.Drawing.Size(250, 21);
            this.cboAlumnos.TabIndex = 22;
            this.cboAlumnos.SelectionChangeCommitted += new System.EventHandler(this.cboAlumnos_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(13, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Alumno:";
            // 
            // cboProfesores
            // 
            this.cboProfesores.FormattingEnabled = true;
            this.cboProfesores.Location = new System.Drawing.Point(89, 10);
            this.cboProfesores.Name = "cboProfesores";
            this.cboProfesores.Size = new System.Drawing.Size(250, 21);
            this.cboProfesores.TabIndex = 20;
            this.cboProfesores.SelectionChangeCommitted += new System.EventHandler(this.cboProfesores_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Profesor:";
            // 
            // cboAños
            // 
            this.cboAños.Enabled = false;
            this.cboAños.FormattingEnabled = true;
            this.cboAños.Location = new System.Drawing.Point(89, 58);
            this.cboAños.Name = "cboAños";
            this.cboAños.Size = new System.Drawing.Size(250, 21);
            this.cboAños.TabIndex = 18;
            this.cboAños.SelectionChangeCommitted += new System.EventHandler(this.cboAños_SelectionChangeCommitted);
            // 
            // lblAñoCalif
            // 
            this.lblAñoCalif.AutoSize = true;
            this.lblAñoCalif.BackColor = System.Drawing.Color.Transparent;
            this.lblAñoCalif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAñoCalif.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAñoCalif.Location = new System.Drawing.Point(37, 59);
            this.lblAñoCalif.Name = "lblAñoCalif";
            this.lblAñoCalif.Size = new System.Drawing.Size(41, 17);
            this.lblAñoCalif.TabIndex = 17;
            this.lblAñoCalif.Text = "Año:";
            // 
            // dgvCalificaciones
            // 
            this.dgvCalificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalificaciones.Location = new System.Drawing.Point(364, 10);
            this.dgvCalificaciones.Name = "dgvCalificaciones";
            this.dgvCalificaciones.Size = new System.Drawing.Size(751, 432);
            this.dgvCalificaciones.TabIndex = 16;
            // 
            // tpBusqNotas
            // 
            this.tpBusqNotas.BackgroundImage = global::SistemaColegioEF.Properties.Resources.rosacolor;
            this.tpBusqNotas.Controls.Add(this.dgvCalifBusqueda);
            this.tpBusqNotas.Controls.Add(this.gbBusquedaNotas);
            this.tpBusqNotas.Location = new System.Drawing.Point(4, 22);
            this.tpBusqNotas.Name = "tpBusqNotas";
            this.tpBusqNotas.Padding = new System.Windows.Forms.Padding(3);
            this.tpBusqNotas.Size = new System.Drawing.Size(1122, 452);
            this.tpBusqNotas.TabIndex = 1;
            this.tpBusqNotas.Text = "Busqueda";
            this.tpBusqNotas.UseVisualStyleBackColor = true;
            // 
            // dgvCalifBusqueda
            // 
            this.dgvCalifBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalifBusqueda.Location = new System.Drawing.Point(362, 21);
            this.dgvCalifBusqueda.Name = "dgvCalifBusqueda";
            this.dgvCalifBusqueda.ReadOnly = true;
            this.dgvCalifBusqueda.Size = new System.Drawing.Size(742, 406);
            this.dgvCalifBusqueda.TabIndex = 1;
            // 
            // gbBusquedaNotas
            // 
            this.gbBusquedaNotas.Controls.Add(this.lblAñoLectivoBusq);
            this.gbBusquedaNotas.Controls.Add(this.dtpFechaCalifBusq);
            this.gbBusquedaNotas.Controls.Add(this.label7);
            this.gbBusquedaNotas.Controls.Add(this.label8);
            this.gbBusquedaNotas.Controls.Add(this.btnBusqNotas);
            this.gbBusquedaNotas.Controls.Add(this.cboMateriaBusq);
            this.gbBusquedaNotas.Controls.Add(this.cboAñoBusqNota);
            this.gbBusquedaNotas.Controls.Add(this.tbDniBusqNotas);
            this.gbBusquedaNotas.Controls.Add(this.rbBusqxAñoMat);
            this.gbBusquedaNotas.Controls.Add(this.rbBusqCalifxDni);
            this.gbBusquedaNotas.Location = new System.Drawing.Point(17, 21);
            this.gbBusquedaNotas.Name = "gbBusquedaNotas";
            this.gbBusquedaNotas.Size = new System.Drawing.Size(308, 406);
            this.gbBusquedaNotas.TabIndex = 0;
            this.gbBusquedaNotas.TabStop = false;
            this.gbBusquedaNotas.Text = "Buscar por";
            // 
            // lblAñoLectivoBusq
            // 
            this.lblAñoLectivoBusq.AutoSize = true;
            this.lblAñoLectivoBusq.BackColor = System.Drawing.Color.Transparent;
            this.lblAñoLectivoBusq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAñoLectivoBusq.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAñoLectivoBusq.Location = new System.Drawing.Point(46, 295);
            this.lblAñoLectivoBusq.Name = "lblAñoLectivoBusq";
            this.lblAñoLectivoBusq.Size = new System.Drawing.Size(98, 17);
            this.lblAñoLectivoBusq.TabIndex = 27;
            this.lblAñoLectivoBusq.Text = "Año Lectivo:";
            // 
            // dtpFechaCalifBusq
            // 
            this.dtpFechaCalifBusq.Location = new System.Drawing.Point(150, 295);
            this.dtpFechaCalifBusq.Name = "dtpFechaCalifBusq";
            this.dtpFechaCalifBusq.Size = new System.Drawing.Size(97, 20);
            this.dtpFechaCalifBusq.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(35, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Materia:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(35, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Curso:";
            // 
            // btnBusqNotas
            // 
            this.btnBusqNotas.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnBusqNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusqNotas.Location = new System.Drawing.Point(78, 355);
            this.btnBusqNotas.Name = "btnBusqNotas";
            this.btnBusqNotas.Size = new System.Drawing.Size(153, 30);
            this.btnBusqNotas.TabIndex = 8;
            this.btnBusqNotas.Text = "Buscar";
            this.btnBusqNotas.UseVisualStyleBackColor = false;
            this.btnBusqNotas.Click += new System.EventHandler(this.btnBusqNotas_Click);
            // 
            // cboMateriaBusq
            // 
            this.cboMateriaBusq.Enabled = false;
            this.cboMateriaBusq.FormattingEnabled = true;
            this.cboMateriaBusq.Location = new System.Drawing.Point(113, 202);
            this.cboMateriaBusq.Name = "cboMateriaBusq";
            this.cboMateriaBusq.Size = new System.Drawing.Size(157, 21);
            this.cboMateriaBusq.TabIndex = 4;
            // 
            // cboAñoBusqNota
            // 
            this.cboAñoBusqNota.Enabled = false;
            this.cboAñoBusqNota.FormattingEnabled = true;
            this.cboAñoBusqNota.Location = new System.Drawing.Point(113, 157);
            this.cboAñoBusqNota.Name = "cboAñoBusqNota";
            this.cboAñoBusqNota.Size = new System.Drawing.Size(157, 21);
            this.cboAñoBusqNota.TabIndex = 3;
            // 
            // tbDniBusqNotas
            // 
            this.tbDniBusqNotas.Location = new System.Drawing.Point(38, 69);
            this.tbDniBusqNotas.Name = "tbDniBusqNotas";
            this.tbDniBusqNotas.Size = new System.Drawing.Size(232, 20);
            this.tbDniBusqNotas.TabIndex = 2;
            // 
            // rbBusqxAñoMat
            // 
            this.rbBusqxAñoMat.AutoSize = true;
            this.rbBusqxAñoMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBusqxAñoMat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbBusqxAñoMat.Location = new System.Drawing.Point(38, 115);
            this.rbBusqxAñoMat.Name = "rbBusqxAñoMat";
            this.rbBusqxAñoMat.Size = new System.Drawing.Size(143, 21);
            this.rbBusqxAñoMat.TabIndex = 1;
            this.rbBusqxAñoMat.TabStop = true;
            this.rbBusqxAñoMat.Text = "Por Año/Materia";
            this.rbBusqxAñoMat.UseVisualStyleBackColor = true;
            // 
            // rbBusqCalifxDni
            // 
            this.rbBusqCalifxDni.AutoSize = true;
            this.rbBusqCalifxDni.Checked = true;
            this.rbBusqCalifxDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBusqCalifxDni.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbBusqCalifxDni.Location = new System.Drawing.Point(38, 30);
            this.rbBusqCalifxDni.Name = "rbBusqCalifxDni";
            this.rbBusqCalifxDni.Size = new System.Drawing.Size(80, 21);
            this.rbBusqCalifxDni.TabIndex = 0;
            this.rbBusqCalifxDni.TabStop = true;
            this.rbBusqCalifxDni.Text = "Por Dni";
            this.rbBusqCalifxDni.UseVisualStyleBackColor = true;
            this.rbBusqCalifxDni.CheckedChanged += new System.EventHandler(this.rbBusqCalifxDni_CheckedChanged);
            // 
            // btnCerrarNota
            // 
            this.btnCerrarNota.BackColor = System.Drawing.Color.LightGreen;
            this.btnCerrarNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarNota.Location = new System.Drawing.Point(89, 419);
            this.btnCerrarNota.Name = "btnCerrarNota";
            this.btnCerrarNota.Size = new System.Drawing.Size(160, 23);
            this.btnCerrarNota.TabIndex = 32;
            this.btnCerrarNota.Text = "Cerrar Nota";
            this.btnCerrarNota.UseVisualStyleBackColor = false;
            this.btnCerrarNota.Click += new System.EventHandler(this.btnCerrarNota_Click);
            // 
            // frmCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaColegioEF.Properties.Resources.rosacolor;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1136, 483);
            this.Controls.Add(this.tabNotas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalificaciones";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calificaciones";
            this.Load += new System.EventHandler(this.frmCalificaciones_Load);
            this.tabNotas.ResumeLayout(false);
            this.tpGestionNotas.ResumeLayout(false);
            this.tpGestionNotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificaciones)).EndInit();
            this.tpBusqNotas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalifBusqueda)).EndInit();
            this.gbBusquedaNotas.ResumeLayout(false);
            this.gbBusquedaNotas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabNotas;
        private System.Windows.Forms.TabPage tpGestionNotas;
        private System.Windows.Forms.Button btnAgregarNota;
        private System.Windows.Forms.DateTimePicker dtpFechaCalificacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboTrimestres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboMaterias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboAlumnos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboProfesores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboAños;
        private System.Windows.Forms.Label lblAñoCalif;
        private System.Windows.Forms.DataGridView dgvCalificaciones;
        private System.Windows.Forms.TabPage tpBusqNotas;
        private System.Windows.Forms.DataGridView dgvCalifBusqueda;
        private System.Windows.Forms.GroupBox gbBusquedaNotas;
        private System.Windows.Forms.Button btnBusqNotas;
        private System.Windows.Forms.ComboBox cboMateriaBusq;
        private System.Windows.Forms.ComboBox cboAñoBusqNota;
        private System.Windows.Forms.TextBox tbDniBusqNotas;
        private System.Windows.Forms.RadioButton rbBusqxAñoMat;
        private System.Windows.Forms.RadioButton rbBusqCalifxDni;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFechaCalifBusq;
        private System.Windows.Forms.Label lblAñoLectivoBusq;
        private System.Windows.Forms.Button btnCerrarNota;
    }
}