namespace SistemaColegioEF.Formularios
{
    partial class frmAsistencias
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
            this.tcAsistencias = new System.Windows.Forms.TabControl();
            this.tpAlumnosAsist = new System.Windows.Forms.TabPage();
            this.btnNoasistioAlumno = new System.Windows.Forms.Button();
            this.btnAsistioAlumno = new System.Windows.Forms.Button();
            this.dtpFechaAlumnAsist = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboAlumnoAsist = new System.Windows.Forms.ComboBox();
            this.cboAñoAlumnoAsist = new System.Windows.Forms.ComboBox();
            this.dgvAsistAlumn = new System.Windows.Forms.DataGridView();
            this.tpProfAsist = new System.Windows.Forms.TabPage();
            this.dgvAsistProf = new System.Windows.Forms.DataGridView();
            this.btnProfNoAsistio = new System.Windows.Forms.Button();
            this.btnProfAsistio = new System.Windows.Forms.Button();
            this.dtpFechaProfAsist = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboProfAsist = new System.Windows.Forms.ComboBox();
            this.tpBusqAsist = new System.Windows.Forms.TabPage();
            this.dgvAsistBusq = new System.Windows.Forms.DataGridView();
            this.gbBusquedaNotas = new System.Windows.Forms.GroupBox();
            this.cboProfAsistBusqueda = new System.Windows.Forms.ComboBox();
            this.lblFechaBusqAsist = new System.Windows.Forms.Label();
            this.dtpFechaBusqAsist = new System.Windows.Forms.DateTimePicker();
            this.lblCursoBusq = new System.Windows.Forms.Label();
            this.btnBuscarAsist = new System.Windows.Forms.Button();
            this.cboAñoBusqAsist = new System.Windows.Forms.ComboBox();
            this.rbBusqAlumnoAsist = new System.Windows.Forms.RadioButton();
            this.rbBusqProfAsist = new System.Windows.Forms.RadioButton();
            this.btnFiltrarAsistAlumn = new System.Windows.Forms.Button();
            this.btnListarAsistAlumn = new System.Windows.Forms.Button();
            this.btnFiltrarFechaProfAsist = new System.Windows.Forms.Button();
            this.btnListarAsistProf = new System.Windows.Forms.Button();
            this.tcAsistencias.SuspendLayout();
            this.tpAlumnosAsist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistAlumn)).BeginInit();
            this.tpProfAsist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistProf)).BeginInit();
            this.tpBusqAsist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistBusq)).BeginInit();
            this.gbBusquedaNotas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAsistencias
            // 
            this.tcAsistencias.Controls.Add(this.tpAlumnosAsist);
            this.tcAsistencias.Controls.Add(this.tpProfAsist);
            this.tcAsistencias.Controls.Add(this.tpBusqAsist);
            this.tcAsistencias.Location = new System.Drawing.Point(2, 3);
            this.tcAsistencias.Name = "tcAsistencias";
            this.tcAsistencias.SelectedIndex = 0;
            this.tcAsistencias.Size = new System.Drawing.Size(871, 489);
            this.tcAsistencias.TabIndex = 0;
            this.tcAsistencias.SelectedIndexChanged += new System.EventHandler(this.tcAsistencias_SelectedIndexChanged);
            // 
            // tpAlumnosAsist
            // 
            this.tpAlumnosAsist.BackgroundImage = global::SistemaColegioEF.Properties.Resources.panel7;
            this.tpAlumnosAsist.Controls.Add(this.btnListarAsistAlumn);
            this.tpAlumnosAsist.Controls.Add(this.btnFiltrarAsistAlumn);
            this.tpAlumnosAsist.Controls.Add(this.btnNoasistioAlumno);
            this.tpAlumnosAsist.Controls.Add(this.btnAsistioAlumno);
            this.tpAlumnosAsist.Controls.Add(this.dtpFechaAlumnAsist);
            this.tpAlumnosAsist.Controls.Add(this.label1);
            this.tpAlumnosAsist.Controls.Add(this.label7);
            this.tpAlumnosAsist.Controls.Add(this.label8);
            this.tpAlumnosAsist.Controls.Add(this.cboAlumnoAsist);
            this.tpAlumnosAsist.Controls.Add(this.cboAñoAlumnoAsist);
            this.tpAlumnosAsist.Controls.Add(this.dgvAsistAlumn);
            this.tpAlumnosAsist.Location = new System.Drawing.Point(4, 22);
            this.tpAlumnosAsist.Name = "tpAlumnosAsist";
            this.tpAlumnosAsist.Padding = new System.Windows.Forms.Padding(3);
            this.tpAlumnosAsist.Size = new System.Drawing.Size(863, 463);
            this.tpAlumnosAsist.TabIndex = 0;
            this.tpAlumnosAsist.Text = "Alumnos";
            this.tpAlumnosAsist.UseVisualStyleBackColor = true;
            // 
            // btnNoasistioAlumno
            // 
            this.btnNoasistioAlumno.BackColor = System.Drawing.Color.MistyRose;
            this.btnNoasistioAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoasistioAlumno.ForeColor = System.Drawing.Color.Red;
            this.btnNoasistioAlumno.Location = new System.Drawing.Point(109, 397);
            this.btnNoasistioAlumno.Name = "btnNoasistioAlumno";
            this.btnNoasistioAlumno.Size = new System.Drawing.Size(156, 36);
            this.btnNoasistioAlumno.TabIndex = 34;
            this.btnNoasistioAlumno.Text = "No Asistió";
            this.btnNoasistioAlumno.UseVisualStyleBackColor = false;
            this.btnNoasistioAlumno.Click += new System.EventHandler(this.btnNoasistioAlumno_Click);
            // 
            // btnAsistioAlumno
            // 
            this.btnAsistioAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistioAlumno.Location = new System.Drawing.Point(109, 355);
            this.btnAsistioAlumno.Name = "btnAsistioAlumno";
            this.btnAsistioAlumno.Size = new System.Drawing.Size(156, 36);
            this.btnAsistioAlumno.TabIndex = 33;
            this.btnAsistioAlumno.Text = "Asistió";
            this.btnAsistioAlumno.UseVisualStyleBackColor = true;
            this.btnAsistioAlumno.Click += new System.EventHandler(this.btnAsistioAlumno_Click);
            // 
            // dtpFechaAlumnAsist
            // 
            this.dtpFechaAlumnAsist.Location = new System.Drawing.Point(109, 187);
            this.dtpFechaAlumnAsist.Name = "dtpFechaAlumnAsist";
            this.dtpFechaAlumnAsist.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaAlumnAsist.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(31, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Fecha:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(31, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Alumno:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(31, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Curso:";
            // 
            // cboAlumnoAsist
            // 
            this.cboAlumnoAsist.Enabled = false;
            this.cboAlumnoAsist.FormattingEnabled = true;
            this.cboAlumnoAsist.Location = new System.Drawing.Point(109, 125);
            this.cboAlumnoAsist.Name = "cboAlumnoAsist";
            this.cboAlumnoAsist.Size = new System.Drawing.Size(200, 21);
            this.cboAlumnoAsist.TabIndex = 27;
            // 
            // cboAñoAlumnoAsist
            // 
            this.cboAñoAlumnoAsist.FormattingEnabled = true;
            this.cboAñoAlumnoAsist.Location = new System.Drawing.Point(109, 63);
            this.cboAñoAlumnoAsist.Name = "cboAñoAlumnoAsist";
            this.cboAñoAlumnoAsist.Size = new System.Drawing.Size(200, 21);
            this.cboAñoAlumnoAsist.TabIndex = 26;
            this.cboAñoAlumnoAsist.SelectionChangeCommitted += new System.EventHandler(this.cboAñoAlumnoAsist_SelectionChangeCommitted);
            // 
            // dgvAsistAlumn
            // 
            this.dgvAsistAlumn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistAlumn.Location = new System.Drawing.Point(361, 6);
            this.dgvAsistAlumn.Name = "dgvAsistAlumn";
            this.dgvAsistAlumn.Size = new System.Drawing.Size(497, 425);
            this.dgvAsistAlumn.TabIndex = 0;
            // 
            // tpProfAsist
            // 
            this.tpProfAsist.BackgroundImage = global::SistemaColegioEF.Properties.Resources.panel7;
            this.tpProfAsist.Controls.Add(this.btnListarAsistProf);
            this.tpProfAsist.Controls.Add(this.btnFiltrarFechaProfAsist);
            this.tpProfAsist.Controls.Add(this.dgvAsistProf);
            this.tpProfAsist.Controls.Add(this.btnProfNoAsistio);
            this.tpProfAsist.Controls.Add(this.btnProfAsistio);
            this.tpProfAsist.Controls.Add(this.dtpFechaProfAsist);
            this.tpProfAsist.Controls.Add(this.label2);
            this.tpProfAsist.Controls.Add(this.label3);
            this.tpProfAsist.Controls.Add(this.cboProfAsist);
            this.tpProfAsist.Location = new System.Drawing.Point(4, 22);
            this.tpProfAsist.Name = "tpProfAsist";
            this.tpProfAsist.Padding = new System.Windows.Forms.Padding(3);
            this.tpProfAsist.Size = new System.Drawing.Size(863, 463);
            this.tpProfAsist.TabIndex = 1;
            this.tpProfAsist.Text = "Profesores";
            this.tpProfAsist.UseVisualStyleBackColor = true;
            // 
            // dgvAsistProf
            // 
            this.dgvAsistProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistProf.Location = new System.Drawing.Point(363, 9);
            this.dgvAsistProf.Name = "dgvAsistProf";
            this.dgvAsistProf.Size = new System.Drawing.Size(494, 417);
            this.dgvAsistProf.TabIndex = 43;
            // 
            // btnProfNoAsistio
            // 
            this.btnProfNoAsistio.BackColor = System.Drawing.Color.MistyRose;
            this.btnProfNoAsistio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfNoAsistio.ForeColor = System.Drawing.Color.Red;
            this.btnProfNoAsistio.Location = new System.Drawing.Point(110, 390);
            this.btnProfNoAsistio.Name = "btnProfNoAsistio";
            this.btnProfNoAsistio.Size = new System.Drawing.Size(156, 36);
            this.btnProfNoAsistio.TabIndex = 42;
            this.btnProfNoAsistio.Text = "No Asistió";
            this.btnProfNoAsistio.UseVisualStyleBackColor = false;
            this.btnProfNoAsistio.Click += new System.EventHandler(this.btnProfNoAsistio_Click);
            // 
            // btnProfAsistio
            // 
            this.btnProfAsistio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfAsistio.Location = new System.Drawing.Point(110, 348);
            this.btnProfAsistio.Name = "btnProfAsistio";
            this.btnProfAsistio.Size = new System.Drawing.Size(156, 36);
            this.btnProfAsistio.TabIndex = 41;
            this.btnProfAsistio.Text = "Asistió";
            this.btnProfAsistio.UseVisualStyleBackColor = true;
            this.btnProfAsistio.Click += new System.EventHandler(this.btnProfAsistio_Click);
            // 
            // dtpFechaProfAsist
            // 
            this.dtpFechaProfAsist.Location = new System.Drawing.Point(110, 147);
            this.dtpFechaProfAsist.Name = "dtpFechaProfAsist";
            this.dtpFechaProfAsist.Size = new System.Drawing.Size(211, 20);
            this.dtpFechaProfAsist.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(32, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(32, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Profesor:";
            // 
            // cboProfAsist
            // 
            this.cboProfAsist.FormattingEnabled = true;
            this.cboProfAsist.Location = new System.Drawing.Point(110, 85);
            this.cboProfAsist.Name = "cboProfAsist";
            this.cboProfAsist.Size = new System.Drawing.Size(211, 21);
            this.cboProfAsist.TabIndex = 36;
            // 
            // tpBusqAsist
            // 
            this.tpBusqAsist.BackgroundImage = global::SistemaColegioEF.Properties.Resources.panel7;
            this.tpBusqAsist.Controls.Add(this.dgvAsistBusq);
            this.tpBusqAsist.Controls.Add(this.gbBusquedaNotas);
            this.tpBusqAsist.Location = new System.Drawing.Point(4, 22);
            this.tpBusqAsist.Name = "tpBusqAsist";
            this.tpBusqAsist.Padding = new System.Windows.Forms.Padding(3);
            this.tpBusqAsist.Size = new System.Drawing.Size(863, 463);
            this.tpBusqAsist.TabIndex = 2;
            this.tpBusqAsist.Text = "Busqueda";
            this.tpBusqAsist.UseVisualStyleBackColor = true;
            // 
            // dgvAsistBusq
            // 
            this.dgvAsistBusq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistBusq.Location = new System.Drawing.Point(357, 7);
            this.dgvAsistBusq.Name = "dgvAsistBusq";
            this.dgvAsistBusq.Size = new System.Drawing.Size(503, 451);
            this.dgvAsistBusq.TabIndex = 44;
            // 
            // gbBusquedaNotas
            // 
            this.gbBusquedaNotas.Controls.Add(this.cboProfAsistBusqueda);
            this.gbBusquedaNotas.Controls.Add(this.lblFechaBusqAsist);
            this.gbBusquedaNotas.Controls.Add(this.dtpFechaBusqAsist);
            this.gbBusquedaNotas.Controls.Add(this.lblCursoBusq);
            this.gbBusquedaNotas.Controls.Add(this.btnBuscarAsist);
            this.gbBusquedaNotas.Controls.Add(this.cboAñoBusqAsist);
            this.gbBusquedaNotas.Controls.Add(this.rbBusqAlumnoAsist);
            this.gbBusquedaNotas.Controls.Add(this.rbBusqProfAsist);
            this.gbBusquedaNotas.Location = new System.Drawing.Point(21, 23);
            this.gbBusquedaNotas.Name = "gbBusquedaNotas";
            this.gbBusquedaNotas.Size = new System.Drawing.Size(308, 406);
            this.gbBusquedaNotas.TabIndex = 1;
            this.gbBusquedaNotas.TabStop = false;
            this.gbBusquedaNotas.Text = "Buscar por";
            // 
            // cboProfAsistBusqueda
            // 
            this.cboProfAsistBusqueda.FormattingEnabled = true;
            this.cboProfAsistBusqueda.Location = new System.Drawing.Point(50, 69);
            this.cboProfAsistBusqueda.Name = "cboProfAsistBusqueda";
            this.cboProfAsistBusqueda.Size = new System.Drawing.Size(239, 21);
            this.cboProfAsistBusqueda.TabIndex = 28;
            // 
            // lblFechaBusqAsist
            // 
            this.lblFechaBusqAsist.AutoSize = true;
            this.lblFechaBusqAsist.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaBusqAsist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaBusqAsist.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFechaBusqAsist.Location = new System.Drawing.Point(35, 253);
            this.lblFechaBusqAsist.Name = "lblFechaBusqAsist";
            this.lblFechaBusqAsist.Size = new System.Drawing.Size(57, 17);
            this.lblFechaBusqAsist.TabIndex = 27;
            this.lblFechaBusqAsist.Text = "Fecha:";
            // 
            // dtpFechaBusqAsist
            // 
            this.dtpFechaBusqAsist.Location = new System.Drawing.Point(96, 253);
            this.dtpFechaBusqAsist.Name = "dtpFechaBusqAsist";
            this.dtpFechaBusqAsist.Size = new System.Drawing.Size(193, 20);
            this.dtpFechaBusqAsist.TabIndex = 26;
            // 
            // lblCursoBusq
            // 
            this.lblCursoBusq.AutoSize = true;
            this.lblCursoBusq.BackColor = System.Drawing.Color.Transparent;
            this.lblCursoBusq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCursoBusq.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCursoBusq.Location = new System.Drawing.Point(35, 157);
            this.lblCursoBusq.Name = "lblCursoBusq";
            this.lblCursoBusq.Size = new System.Drawing.Size(55, 17);
            this.lblCursoBusq.TabIndex = 24;
            this.lblCursoBusq.Text = "Curso:";
            // 
            // btnBuscarAsist
            // 
            this.btnBuscarAsist.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnBuscarAsist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAsist.Location = new System.Drawing.Point(68, 340);
            this.btnBuscarAsist.Name = "btnBuscarAsist";
            this.btnBuscarAsist.Size = new System.Drawing.Size(153, 30);
            this.btnBuscarAsist.TabIndex = 8;
            this.btnBuscarAsist.Text = "Filtrar";
            this.btnBuscarAsist.UseVisualStyleBackColor = false;
            this.btnBuscarAsist.Click += new System.EventHandler(this.btnBuscarAsist_Click);
            // 
            // cboAñoBusqAsist
            // 
            this.cboAñoBusqAsist.Enabled = false;
            this.cboAñoBusqAsist.FormattingEnabled = true;
            this.cboAñoBusqAsist.Location = new System.Drawing.Point(96, 157);
            this.cboAñoBusqAsist.Name = "cboAñoBusqAsist";
            this.cboAñoBusqAsist.Size = new System.Drawing.Size(193, 21);
            this.cboAñoBusqAsist.TabIndex = 3;
            // 
            // rbBusqAlumnoAsist
            // 
            this.rbBusqAlumnoAsist.AutoSize = true;
            this.rbBusqAlumnoAsist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBusqAlumnoAsist.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbBusqAlumnoAsist.Location = new System.Drawing.Point(38, 115);
            this.rbBusqAlumnoAsist.Name = "rbBusqAlumnoAsist";
            this.rbBusqAlumnoAsist.Size = new System.Drawing.Size(92, 21);
            this.rbBusqAlumnoAsist.TabIndex = 1;
            this.rbBusqAlumnoAsist.TabStop = true;
            this.rbBusqAlumnoAsist.Text = "Alumnos:";
            this.rbBusqAlumnoAsist.UseVisualStyleBackColor = true;
            // 
            // rbBusqProfAsist
            // 
            this.rbBusqProfAsist.AutoSize = true;
            this.rbBusqProfAsist.Checked = true;
            this.rbBusqProfAsist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBusqProfAsist.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbBusqProfAsist.Location = new System.Drawing.Point(38, 30);
            this.rbBusqProfAsist.Name = "rbBusqProfAsist";
            this.rbBusqProfAsist.Size = new System.Drawing.Size(110, 21);
            this.rbBusqProfAsist.TabIndex = 0;
            this.rbBusqProfAsist.TabStop = true;
            this.rbBusqProfAsist.Text = "Profesores:";
            this.rbBusqProfAsist.UseVisualStyleBackColor = true;
            this.rbBusqProfAsist.CheckedChanged += new System.EventHandler(this.rbBusqProfAsist_CheckedChanged);
            // 
            // btnFiltrarAsistAlumn
            // 
            this.btnFiltrarAsistAlumn.Location = new System.Drawing.Point(109, 213);
            this.btnFiltrarAsistAlumn.Name = "btnFiltrarAsistAlumn";
            this.btnFiltrarAsistAlumn.Size = new System.Drawing.Size(200, 23);
            this.btnFiltrarAsistAlumn.TabIndex = 35;
            this.btnFiltrarAsistAlumn.Text = "Filtrar por Fecha";
            this.btnFiltrarAsistAlumn.UseVisualStyleBackColor = true;
            this.btnFiltrarAsistAlumn.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnListarAsistAlumn
            // 
            this.btnListarAsistAlumn.Location = new System.Drawing.Point(536, 435);
            this.btnListarAsistAlumn.Name = "btnListarAsistAlumn";
            this.btnListarAsistAlumn.Size = new System.Drawing.Size(145, 23);
            this.btnListarAsistAlumn.TabIndex = 36;
            this.btnListarAsistAlumn.Text = "Listar todo";
            this.btnListarAsistAlumn.UseVisualStyleBackColor = true;
            this.btnListarAsistAlumn.Click += new System.EventHandler(this.btnListarAsistAlumn_Click);
            // 
            // btnFiltrarFechaProfAsist
            // 
            this.btnFiltrarFechaProfAsist.Location = new System.Drawing.Point(110, 173);
            this.btnFiltrarFechaProfAsist.Name = "btnFiltrarFechaProfAsist";
            this.btnFiltrarFechaProfAsist.Size = new System.Drawing.Size(211, 23);
            this.btnFiltrarFechaProfAsist.TabIndex = 44;
            this.btnFiltrarFechaProfAsist.Text = "Filtrar por Fecha";
            this.btnFiltrarFechaProfAsist.UseVisualStyleBackColor = true;
            this.btnFiltrarFechaProfAsist.Click += new System.EventHandler(this.btnFiltrarFechaProfAsist_Click);
            // 
            // btnListarAsistProf
            // 
            this.btnListarAsistProf.Location = new System.Drawing.Point(542, 432);
            this.btnListarAsistProf.Name = "btnListarAsistProf";
            this.btnListarAsistProf.Size = new System.Drawing.Size(145, 23);
            this.btnListarAsistProf.TabIndex = 45;
            this.btnListarAsistProf.Text = "Listar todo";
            this.btnListarAsistProf.UseVisualStyleBackColor = true;
            this.btnListarAsistProf.Click += new System.EventHandler(this.btnListarAsistProf_Click);
            // 
            // frmAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaColegioEF.Properties.Resources.panel7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 495);
            this.Controls.Add(this.tcAsistencias);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAsistencias";
            this.ShowIcon = false;
            this.Text = "Asistencias";
            this.Load += new System.EventHandler(this.frmAsistencias_Load);
            this.tcAsistencias.ResumeLayout(false);
            this.tpAlumnosAsist.ResumeLayout(false);
            this.tpAlumnosAsist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistAlumn)).EndInit();
            this.tpProfAsist.ResumeLayout(false);
            this.tpProfAsist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistProf)).EndInit();
            this.tpBusqAsist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistBusq)).EndInit();
            this.gbBusquedaNotas.ResumeLayout(false);
            this.gbBusquedaNotas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAsistencias;
        private System.Windows.Forms.TabPage tpAlumnosAsist;
        private System.Windows.Forms.DataGridView dgvAsistAlumn;
        private System.Windows.Forms.TabPage tpProfAsist;
        private System.Windows.Forms.TabPage tpBusqAsist;
        private System.Windows.Forms.Button btnNoasistioAlumno;
        private System.Windows.Forms.Button btnAsistioAlumno;
        private System.Windows.Forms.DateTimePicker dtpFechaAlumnAsist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboAlumnoAsist;
        private System.Windows.Forms.ComboBox cboAñoAlumnoAsist;
        private System.Windows.Forms.DataGridView dgvAsistProf;
        private System.Windows.Forms.Button btnProfNoAsistio;
        private System.Windows.Forms.Button btnProfAsistio;
        private System.Windows.Forms.DateTimePicker dtpFechaProfAsist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboProfAsist;
        private System.Windows.Forms.DataGridView dgvAsistBusq;
        private System.Windows.Forms.GroupBox gbBusquedaNotas;
        private System.Windows.Forms.ComboBox cboProfAsistBusqueda;
        private System.Windows.Forms.Label lblFechaBusqAsist;
        private System.Windows.Forms.DateTimePicker dtpFechaBusqAsist;
        private System.Windows.Forms.Label lblCursoBusq;
        private System.Windows.Forms.Button btnBuscarAsist;
        private System.Windows.Forms.ComboBox cboAñoBusqAsist;
        private System.Windows.Forms.RadioButton rbBusqAlumnoAsist;
        private System.Windows.Forms.RadioButton rbBusqProfAsist;
        private System.Windows.Forms.Button btnFiltrarAsistAlumn;
        private System.Windows.Forms.Button btnListarAsistAlumn;
        private System.Windows.Forms.Button btnListarAsistProf;
        private System.Windows.Forms.Button btnFiltrarFechaProfAsist;
    }
}