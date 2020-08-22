namespace SistemaColegioEF.Formularios
{
    partial class frmMaterias
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbNombreMateria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.tabMaterias = new System.Windows.Forms.TabControl();
            this.tpGestionMaterias = new System.Windows.Forms.TabPage();
            this.tpInscProf = new System.Windows.Forms.TabPage();
            this.nudAñoProfMateria = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDesinscribirProf = new System.Windows.Forms.Button();
            this.btnInscribir = new System.Windows.Forms.Button();
            this.lblProfesores = new System.Windows.Forms.Label();
            this.lblMaterias = new System.Windows.Forms.Label();
            this.cboProfesores = new System.Windows.Forms.ComboBox();
            this.cboMateria_Prof = new System.Windows.Forms.ComboBox();
            this.dgvProfMateria = new System.Windows.Forms.DataGridView();
            this.tpInscAlumn = new System.Windows.Forms.TabPage();
            this.btnDesinscrAlum = new System.Windows.Forms.Button();
            this.btnInscrAlumn = new System.Windows.Forms.Button();
            this.lblAlumnos = new System.Windows.Forms.Label();
            this.lblMateriasAlumn = new System.Windows.Forms.Label();
            this.cboAlumnos = new System.Windows.Forms.ComboBox();
            this.cboMaterias_Alumn = new System.Windows.Forms.ComboBox();
            this.dgvAlumnoMateria = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.tabMaterias.SuspendLayout();
            this.tpGestionMaterias.SuspendLayout();
            this.tpInscProf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAñoProfMateria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfMateria)).BeginInit();
            this.tpInscAlumn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnoMateria)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.tbNombreMateria);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(42, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestion de Materias";
            // 
            // tbNombreMateria
            // 
            this.tbNombreMateria.Enabled = false;
            this.tbNombreMateria.Location = new System.Drawing.Point(35, 48);
            this.tbNombreMateria.Name = "tbNombreMateria";
            this.tbNombreMateria.Size = new System.Drawing.Size(221, 20);
            this.tbNombreMateria.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la materia";
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.BackColor = System.Drawing.Color.Transparent;
            this.pnlAcciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAcciones.Location = new System.Drawing.Point(68, 172);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(235, 75);
            this.pnlAcciones.TabIndex = 3;
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Location = new System.Drawing.Point(354, 38);
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.Size = new System.Drawing.Size(287, 424);
            this.dgvMaterias.TabIndex = 4;
            this.dgvMaterias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterias_CellClick);
            // 
            // tabMaterias
            // 
            this.tabMaterias.Controls.Add(this.tpGestionMaterias);
            this.tabMaterias.Controls.Add(this.tpInscProf);
            this.tabMaterias.Controls.Add(this.tpInscAlumn);
            this.tabMaterias.Location = new System.Drawing.Point(1, 3);
            this.tabMaterias.Name = "tabMaterias";
            this.tabMaterias.SelectedIndex = 0;
            this.tabMaterias.Size = new System.Drawing.Size(725, 538);
            this.tabMaterias.TabIndex = 5;
            this.tabMaterias.SelectedIndexChanged += new System.EventHandler(this.tabMaterias_SelectedIndexChanged);
            // 
            // tpGestionMaterias
            // 
            this.tpGestionMaterias.BackgroundImage = global::SistemaColegioEF.Properties.Resources.panel6;
            this.tpGestionMaterias.Controls.Add(this.groupBox1);
            this.tpGestionMaterias.Controls.Add(this.dgvMaterias);
            this.tpGestionMaterias.Controls.Add(this.pnlAcciones);
            this.tpGestionMaterias.Location = new System.Drawing.Point(4, 22);
            this.tpGestionMaterias.Name = "tpGestionMaterias";
            this.tpGestionMaterias.Padding = new System.Windows.Forms.Padding(3);
            this.tpGestionMaterias.Size = new System.Drawing.Size(717, 512);
            this.tpGestionMaterias.TabIndex = 0;
            this.tpGestionMaterias.Text = "Gestion";
            this.tpGestionMaterias.UseVisualStyleBackColor = true;
            // 
            // tpInscProf
            // 
            this.tpInscProf.BackgroundImage = global::SistemaColegioEF.Properties.Resources.panel6;
            this.tpInscProf.Controls.Add(this.nudAñoProfMateria);
            this.tpInscProf.Controls.Add(this.label2);
            this.tpInscProf.Controls.Add(this.btnDesinscribirProf);
            this.tpInscProf.Controls.Add(this.btnInscribir);
            this.tpInscProf.Controls.Add(this.lblProfesores);
            this.tpInscProf.Controls.Add(this.lblMaterias);
            this.tpInscProf.Controls.Add(this.cboProfesores);
            this.tpInscProf.Controls.Add(this.cboMateria_Prof);
            this.tpInscProf.Controls.Add(this.dgvProfMateria);
            this.tpInscProf.Location = new System.Drawing.Point(4, 22);
            this.tpInscProf.Name = "tpInscProf";
            this.tpInscProf.Padding = new System.Windows.Forms.Padding(3);
            this.tpInscProf.Size = new System.Drawing.Size(717, 512);
            this.tpInscProf.TabIndex = 1;
            this.tpInscProf.Text = "Inscripcion Prof.";
            this.tpInscProf.UseVisualStyleBackColor = true;
            // 
            // nudAñoProfMateria
            // 
            this.nudAñoProfMateria.Location = new System.Drawing.Point(31, 229);
            this.nudAñoProfMateria.Name = "nudAñoProfMateria";
            this.nudAñoProfMateria.Size = new System.Drawing.Size(229, 20);
            this.nudAñoProfMateria.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Año / Grado:";
            // 
            // btnDesinscribirProf
            // 
            this.btnDesinscribirProf.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDesinscribirProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesinscribirProf.ForeColor = System.Drawing.Color.Red;
            this.btnDesinscribirProf.Location = new System.Drawing.Point(71, 431);
            this.btnDesinscribirProf.Name = "btnDesinscribirProf";
            this.btnDesinscribirProf.Size = new System.Drawing.Size(133, 42);
            this.btnDesinscribirProf.TabIndex = 7;
            this.btnDesinscribirProf.Text = "Desinscribir";
            this.btnDesinscribirProf.UseVisualStyleBackColor = false;
            this.btnDesinscribirProf.Click += new System.EventHandler(this.btnDesinscribirProf_Click);
            // 
            // btnInscribir
            // 
            this.btnInscribir.BackColor = System.Drawing.Color.Teal;
            this.btnInscribir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscribir.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnInscribir.Location = new System.Drawing.Point(71, 274);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.Size = new System.Drawing.Size(133, 42);
            this.btnInscribir.TabIndex = 6;
            this.btnInscribir.Text = "Inscribir";
            this.btnInscribir.UseVisualStyleBackColor = false;
            this.btnInscribir.Click += new System.EventHandler(this.btnInscribir_Click);
            // 
            // lblProfesores
            // 
            this.lblProfesores.AutoSize = true;
            this.lblProfesores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesores.ForeColor = System.Drawing.Color.White;
            this.lblProfesores.Location = new System.Drawing.Point(28, 120);
            this.lblProfesores.Name = "lblProfesores";
            this.lblProfesores.Size = new System.Drawing.Size(92, 17);
            this.lblProfesores.TabIndex = 5;
            this.lblProfesores.Text = "Profesores:";
            // 
            // lblMaterias
            // 
            this.lblMaterias.AutoSize = true;
            this.lblMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterias.ForeColor = System.Drawing.Color.White;
            this.lblMaterias.Location = new System.Drawing.Point(28, 46);
            this.lblMaterias.Name = "lblMaterias";
            this.lblMaterias.Size = new System.Drawing.Size(75, 17);
            this.lblMaterias.TabIndex = 4;
            this.lblMaterias.Text = "Materias:";
            // 
            // cboProfesores
            // 
            this.cboProfesores.FormattingEnabled = true;
            this.cboProfesores.Location = new System.Drawing.Point(31, 158);
            this.cboProfesores.Name = "cboProfesores";
            this.cboProfesores.Size = new System.Drawing.Size(229, 21);
            this.cboProfesores.TabIndex = 3;
            // 
            // cboMateria_Prof
            // 
            this.cboMateria_Prof.FormattingEnabled = true;
            this.cboMateria_Prof.Location = new System.Drawing.Point(31, 77);
            this.cboMateria_Prof.Name = "cboMateria_Prof";
            this.cboMateria_Prof.Size = new System.Drawing.Size(229, 21);
            this.cboMateria_Prof.TabIndex = 2;
            // 
            // dgvProfMateria
            // 
            this.dgvProfMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfMateria.Location = new System.Drawing.Point(294, 46);
            this.dgvProfMateria.Name = "dgvProfMateria";
            this.dgvProfMateria.Size = new System.Drawing.Size(403, 427);
            this.dgvProfMateria.TabIndex = 0;
            // 
            // tpInscAlumn
            // 
            this.tpInscAlumn.BackgroundImage = global::SistemaColegioEF.Properties.Resources.panel6;
            this.tpInscAlumn.Controls.Add(this.btnDesinscrAlum);
            this.tpInscAlumn.Controls.Add(this.btnInscrAlumn);
            this.tpInscAlumn.Controls.Add(this.lblAlumnos);
            this.tpInscAlumn.Controls.Add(this.lblMateriasAlumn);
            this.tpInscAlumn.Controls.Add(this.cboAlumnos);
            this.tpInscAlumn.Controls.Add(this.cboMaterias_Alumn);
            this.tpInscAlumn.Controls.Add(this.dgvAlumnoMateria);
            this.tpInscAlumn.Location = new System.Drawing.Point(4, 22);
            this.tpInscAlumn.Name = "tpInscAlumn";
            this.tpInscAlumn.Size = new System.Drawing.Size(717, 512);
            this.tpInscAlumn.TabIndex = 2;
            this.tpInscAlumn.Text = "Inscripcion Alumnos";
            this.tpInscAlumn.UseVisualStyleBackColor = true;
            // 
            // btnDesinscrAlum
            // 
            this.btnDesinscrAlum.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDesinscrAlum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesinscrAlum.ForeColor = System.Drawing.Color.Red;
            this.btnDesinscrAlum.Location = new System.Drawing.Point(67, 428);
            this.btnDesinscrAlum.Name = "btnDesinscrAlum";
            this.btnDesinscrAlum.Size = new System.Drawing.Size(133, 42);
            this.btnDesinscrAlum.TabIndex = 14;
            this.btnDesinscrAlum.Text = "Desinscribir";
            this.btnDesinscrAlum.UseVisualStyleBackColor = false;
            // 
            // btnInscrAlumn
            // 
            this.btnInscrAlumn.BackColor = System.Drawing.Color.Teal;
            this.btnInscrAlumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscrAlumn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnInscrAlumn.Location = new System.Drawing.Point(67, 199);
            this.btnInscrAlumn.Name = "btnInscrAlumn";
            this.btnInscrAlumn.Size = new System.Drawing.Size(133, 42);
            this.btnInscrAlumn.TabIndex = 13;
            this.btnInscrAlumn.Text = "Inscribir";
            this.btnInscrAlumn.UseVisualStyleBackColor = false;
            // 
            // lblAlumnos
            // 
            this.lblAlumnos.AutoSize = true;
            this.lblAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumnos.ForeColor = System.Drawing.Color.White;
            this.lblAlumnos.Location = new System.Drawing.Point(24, 117);
            this.lblAlumnos.Name = "lblAlumnos";
            this.lblAlumnos.Size = new System.Drawing.Size(74, 17);
            this.lblAlumnos.TabIndex = 12;
            this.lblAlumnos.Text = "Alumnos:";
            // 
            // lblMateriasAlumn
            // 
            this.lblMateriasAlumn.AutoSize = true;
            this.lblMateriasAlumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateriasAlumn.ForeColor = System.Drawing.Color.White;
            this.lblMateriasAlumn.Location = new System.Drawing.Point(24, 43);
            this.lblMateriasAlumn.Name = "lblMateriasAlumn";
            this.lblMateriasAlumn.Size = new System.Drawing.Size(75, 17);
            this.lblMateriasAlumn.TabIndex = 11;
            this.lblMateriasAlumn.Text = "Materias:";
            // 
            // cboAlumnos
            // 
            this.cboAlumnos.FormattingEnabled = true;
            this.cboAlumnos.Location = new System.Drawing.Point(27, 155);
            this.cboAlumnos.Name = "cboAlumnos";
            this.cboAlumnos.Size = new System.Drawing.Size(229, 21);
            this.cboAlumnos.TabIndex = 10;
            // 
            // cboMaterias_Alumn
            // 
            this.cboMaterias_Alumn.FormattingEnabled = true;
            this.cboMaterias_Alumn.Location = new System.Drawing.Point(27, 74);
            this.cboMaterias_Alumn.Name = "cboMaterias_Alumn";
            this.cboMaterias_Alumn.Size = new System.Drawing.Size(229, 21);
            this.cboMaterias_Alumn.TabIndex = 9;
            // 
            // dgvAlumnoMateria
            // 
            this.dgvAlumnoMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnoMateria.Location = new System.Drawing.Point(290, 43);
            this.dgvAlumnoMateria.Name = "dgvAlumnoMateria";
            this.dgvAlumnoMateria.Size = new System.Drawing.Size(403, 427);
            this.dgvAlumnoMateria.TabIndex = 8;
            // 
            // frmMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaColegioEF.Properties.Resources.panel6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(730, 543);
            this.Controls.Add(this.tabMaterias);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMaterias";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Materias";
            this.Load += new System.EventHandler(this.frmMaterias_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.tabMaterias.ResumeLayout(false);
            this.tpGestionMaterias.ResumeLayout(false);
            this.tpInscProf.ResumeLayout(false);
            this.tpInscProf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAñoProfMateria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfMateria)).EndInit();
            this.tpInscAlumn.ResumeLayout(false);
            this.tpInscAlumn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnoMateria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbNombreMateria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.TabControl tabMaterias;
        private System.Windows.Forms.TabPage tpGestionMaterias;
        private System.Windows.Forms.TabPage tpInscProf;
        private System.Windows.Forms.TabPage tpInscAlumn;
        private System.Windows.Forms.Button btnDesinscribirProf;
        private System.Windows.Forms.Button btnInscribir;
        private System.Windows.Forms.Label lblProfesores;
        private System.Windows.Forms.Label lblMaterias;
        private System.Windows.Forms.ComboBox cboProfesores;
        private System.Windows.Forms.ComboBox cboMateria_Prof;
        private System.Windows.Forms.DataGridView dgvProfMateria;
        private System.Windows.Forms.Button btnDesinscrAlum;
        private System.Windows.Forms.Button btnInscrAlumn;
        private System.Windows.Forms.Label lblAlumnos;
        private System.Windows.Forms.Label lblMateriasAlumn;
        private System.Windows.Forms.ComboBox cboAlumnos;
        private System.Windows.Forms.ComboBox cboMaterias_Alumn;
        private System.Windows.Forms.DataGridView dgvAlumnoMateria;
        private System.Windows.Forms.NumericUpDown nudAñoProfMateria;
        private System.Windows.Forms.Label label2;
    }
}