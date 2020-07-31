namespace SistemaColegioEF.Formularios
{
    partial class frmProfesores
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlAbm = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbEmailProf = new System.Windows.Forms.TextBox();
            this.tbTelefonoProf = new System.Windows.Forms.TextBox();
            this.tbDireccionProf = new System.Windows.Forms.TextBox();
            this.dtpFechaNacAlu = new System.Windows.Forms.DateTimePicker();
            this.rbSexoProf_F = new System.Windows.Forms.RadioButton();
            this.rbSexoProf_H = new System.Windows.Forms.RadioButton();
            this.tbDniProf = new System.Windows.Forms.TextBox();
            this.tbApellidoProf = new System.Windows.Forms.TextBox();
            this.tbNombreProf = new System.Windows.Forms.TextBox();
            this.lblEmailProf = new System.Windows.Forms.Label();
            this.lblTelefonoProf = new System.Windows.Forms.Label();
            this.lblDireccionProf = new System.Windows.Forms.Label();
            this.lblFechaNacProf = new System.Windows.Forms.Label();
            this.lblSexoAlumno = new System.Windows.Forms.Label();
            this.lblDniProfesor = new System.Windows.Forms.Label();
            this.lblApellidosProf = new System.Windows.Forms.Label();
            this.lblNombresProf = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbEspecialidadProf = new System.Windows.Forms.TextBox();
            this.lblEspecialidadProf = new System.Windows.Forms.Label();
            this.tbNivelProf = new System.Windows.Forms.TextBox();
            this.lblNivelProf = new System.Windows.Forms.Label();
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.dgvProfesores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = global::SistemaColegioEF.Properties.Resources.panel3;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.pnlAbm);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = global::SistemaColegioEF.Properties.Resources.panel5;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel2.Controls.Add(this.gbBusqueda);
            this.splitContainer1.Panel2.Controls.Add(this.dgvProfesores);
            this.splitContainer1.Size = new System.Drawing.Size(927, 510);
            this.splitContainer1.SplitterDistance = 291;
            this.splitContainer1.TabIndex = 0;
            // 
            // pnlAbm
            // 
            this.pnlAbm.BackColor = System.Drawing.Color.Transparent;
            this.pnlAbm.Location = new System.Drawing.Point(23, 423);
            this.pnlAbm.Name = "pnlAbm";
            this.pnlAbm.Size = new System.Drawing.Size(235, 75);
            this.pnlAbm.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tbEmailProf);
            this.groupBox1.Controls.Add(this.tbTelefonoProf);
            this.groupBox1.Controls.Add(this.tbDireccionProf);
            this.groupBox1.Controls.Add(this.dtpFechaNacAlu);
            this.groupBox1.Controls.Add(this.rbSexoProf_F);
            this.groupBox1.Controls.Add(this.rbSexoProf_H);
            this.groupBox1.Controls.Add(this.tbDniProf);
            this.groupBox1.Controls.Add(this.tbApellidoProf);
            this.groupBox1.Controls.Add(this.tbNombreProf);
            this.groupBox1.Controls.Add(this.lblEmailProf);
            this.groupBox1.Controls.Add(this.lblTelefonoProf);
            this.groupBox1.Controls.Add(this.lblDireccionProf);
            this.groupBox1.Controls.Add(this.lblFechaNacProf);
            this.groupBox1.Controls.Add(this.lblSexoAlumno);
            this.groupBox1.Controls.Add(this.lblDniProfesor);
            this.groupBox1.Controls.Add(this.lblApellidosProf);
            this.groupBox1.Controls.Add(this.lblNombresProf);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 398);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion Personal";
            // 
            // tbEmailProf
            // 
            this.tbEmailProf.Location = new System.Drawing.Point(95, 250);
            this.tbEmailProf.Name = "tbEmailProf";
            this.tbEmailProf.Size = new System.Drawing.Size(140, 20);
            this.tbEmailProf.TabIndex = 18;
            // 
            // tbTelefonoProf
            // 
            this.tbTelefonoProf.Location = new System.Drawing.Point(95, 221);
            this.tbTelefonoProf.Name = "tbTelefonoProf";
            this.tbTelefonoProf.Size = new System.Drawing.Size(140, 20);
            this.tbTelefonoProf.TabIndex = 17;
            this.tbTelefonoProf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefonoProf_KeyPress);
            // 
            // tbDireccionProf
            // 
            this.tbDireccionProf.Location = new System.Drawing.Point(95, 186);
            this.tbDireccionProf.Name = "tbDireccionProf";
            this.tbDireccionProf.Size = new System.Drawing.Size(140, 20);
            this.tbDireccionProf.TabIndex = 16;
            // 
            // dtpFechaNacAlu
            // 
            this.dtpFechaNacAlu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacAlu.Location = new System.Drawing.Point(133, 151);
            this.dtpFechaNacAlu.Name = "dtpFechaNacAlu";
            this.dtpFechaNacAlu.Size = new System.Drawing.Size(102, 20);
            this.dtpFechaNacAlu.TabIndex = 15;
            // 
            // rbSexoProf_F
            // 
            this.rbSexoProf_F.AutoSize = true;
            this.rbSexoProf_F.Location = new System.Drawing.Point(173, 123);
            this.rbSexoProf_F.Name = "rbSexoProf_F";
            this.rbSexoProf_F.Size = new System.Drawing.Size(56, 17);
            this.rbSexoProf_F.TabIndex = 14;
            this.rbSexoProf_F.TabStop = true;
            this.rbSexoProf_F.Text = "Mujer";
            this.rbSexoProf_F.UseVisualStyleBackColor = true;
            // 
            // rbSexoProf_H
            // 
            this.rbSexoProf_H.AutoSize = true;
            this.rbSexoProf_H.Location = new System.Drawing.Point(95, 123);
            this.rbSexoProf_H.Name = "rbSexoProf_H";
            this.rbSexoProf_H.Size = new System.Drawing.Size(68, 17);
            this.rbSexoProf_H.TabIndex = 13;
            this.rbSexoProf_H.TabStop = true;
            this.rbSexoProf_H.Text = "Hombre";
            this.rbSexoProf_H.UseVisualStyleBackColor = true;
            // 
            // tbDniProf
            // 
            this.tbDniProf.Location = new System.Drawing.Point(95, 90);
            this.tbDniProf.MaxLength = 10;
            this.tbDniProf.Name = "tbDniProf";
            this.tbDniProf.Size = new System.Drawing.Size(140, 20);
            this.tbDniProf.TabIndex = 12;
            this.tbDniProf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDniProfesor_KeyPress);
            // 
            // tbApellidoProf
            // 
            this.tbApellidoProf.Location = new System.Drawing.Point(95, 58);
            this.tbApellidoProf.Name = "tbApellidoProf";
            this.tbApellidoProf.Size = new System.Drawing.Size(140, 20);
            this.tbApellidoProf.TabIndex = 11;
            // 
            // tbNombreProf
            // 
            this.tbNombreProf.Location = new System.Drawing.Point(95, 26);
            this.tbNombreProf.Name = "tbNombreProf";
            this.tbNombreProf.Size = new System.Drawing.Size(140, 20);
            this.tbNombreProf.TabIndex = 10;
            // 
            // lblEmailProf
            // 
            this.lblEmailProf.AutoSize = true;
            this.lblEmailProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailProf.Location = new System.Drawing.Point(18, 253);
            this.lblEmailProf.Name = "lblEmailProf";
            this.lblEmailProf.Size = new System.Drawing.Size(35, 13);
            this.lblEmailProf.TabIndex = 9;
            this.lblEmailProf.Text = "Email:";
            // 
            // lblTelefonoProf
            // 
            this.lblTelefonoProf.AutoSize = true;
            this.lblTelefonoProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoProf.Location = new System.Drawing.Point(18, 221);
            this.lblTelefonoProf.Name = "lblTelefonoProf";
            this.lblTelefonoProf.Size = new System.Drawing.Size(52, 13);
            this.lblTelefonoProf.TabIndex = 8;
            this.lblTelefonoProf.Text = "Telefono:";
            // 
            // lblDireccionProf
            // 
            this.lblDireccionProf.AutoSize = true;
            this.lblDireccionProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionProf.Location = new System.Drawing.Point(18, 189);
            this.lblDireccionProf.Name = "lblDireccionProf";
            this.lblDireccionProf.Size = new System.Drawing.Size(55, 13);
            this.lblDireccionProf.TabIndex = 7;
            this.lblDireccionProf.Text = "Direccion:";
            // 
            // lblFechaNacProf
            // 
            this.lblFechaNacProf.AutoSize = true;
            this.lblFechaNacProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacProf.Location = new System.Drawing.Point(18, 157);
            this.lblFechaNacProf.Name = "lblFechaNacProf";
            this.lblFechaNacProf.Size = new System.Drawing.Size(109, 13);
            this.lblFechaNacProf.TabIndex = 6;
            this.lblFechaNacProf.Text = "Fecha de nacimiento:";
            // 
            // lblSexoAlumno
            // 
            this.lblSexoAlumno.AutoSize = true;
            this.lblSexoAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexoAlumno.Location = new System.Drawing.Point(18, 125);
            this.lblSexoAlumno.Name = "lblSexoAlumno";
            this.lblSexoAlumno.Size = new System.Drawing.Size(34, 13);
            this.lblSexoAlumno.TabIndex = 5;
            this.lblSexoAlumno.Text = "Sexo:";
            // 
            // lblDniProfesor
            // 
            this.lblDniProfesor.AutoSize = true;
            this.lblDniProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniProfesor.Location = new System.Drawing.Point(18, 93);
            this.lblDniProfesor.Name = "lblDniProfesor";
            this.lblDniProfesor.Size = new System.Drawing.Size(29, 13);
            this.lblDniProfesor.TabIndex = 4;
            this.lblDniProfesor.Text = "DNI:";
            // 
            // lblApellidosProf
            // 
            this.lblApellidosProf.AutoSize = true;
            this.lblApellidosProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidosProf.Location = new System.Drawing.Point(18, 61);
            this.lblApellidosProf.Name = "lblApellidosProf";
            this.lblApellidosProf.Size = new System.Drawing.Size(57, 13);
            this.lblApellidosProf.TabIndex = 3;
            this.lblApellidosProf.Text = "Apellido/s:";
            // 
            // lblNombresProf
            // 
            this.lblNombresProf.AutoSize = true;
            this.lblNombresProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombresProf.Location = new System.Drawing.Point(18, 29);
            this.lblNombresProf.Name = "lblNombresProf";
            this.lblNombresProf.Size = new System.Drawing.Size(57, 13);
            this.lblNombresProf.TabIndex = 2;
            this.lblNombresProf.Text = "Nombre/s:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbEspecialidadProf);
            this.groupBox2.Controls.Add(this.lblEspecialidadProf);
            this.groupBox2.Controls.Add(this.tbNivelProf);
            this.groupBox2.Controls.Add(this.lblNivelProf);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(0, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 103);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registro Académico";
            // 
            // tbEspecialidadProf
            // 
            this.tbEspecialidadProf.Location = new System.Drawing.Point(95, 66);
            this.tbEspecialidadProf.Name = "tbEspecialidadProf";
            this.tbEspecialidadProf.Size = new System.Drawing.Size(140, 20);
            this.tbEspecialidadProf.TabIndex = 20;
            // 
            // lblEspecialidadProf
            // 
            this.lblEspecialidadProf.AutoSize = true;
            this.lblEspecialidadProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidadProf.Location = new System.Drawing.Point(18, 69);
            this.lblEspecialidadProf.Name = "lblEspecialidadProf";
            this.lblEspecialidadProf.Size = new System.Drawing.Size(73, 13);
            this.lblEspecialidadProf.TabIndex = 20;
            this.lblEspecialidadProf.Text = "Especialidad: ";
            // 
            // tbNivelProf
            // 
            this.tbNivelProf.Location = new System.Drawing.Point(95, 33);
            this.tbNivelProf.Name = "tbNivelProf";
            this.tbNivelProf.Size = new System.Drawing.Size(140, 20);
            this.tbNivelProf.TabIndex = 19;
            // 
            // lblNivelProf
            // 
            this.lblNivelProf.AutoSize = true;
            this.lblNivelProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelProf.Location = new System.Drawing.Point(17, 36);
            this.lblNivelProf.Name = "lblNivelProf";
            this.lblNivelProf.Size = new System.Drawing.Size(34, 13);
            this.lblNivelProf.TabIndex = 19;
            this.lblNivelProf.Text = "Nivel:";
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.gbBusqueda.Controls.Add(this.pnlBusqueda);
            this.gbBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBusqueda.Location = new System.Drawing.Point(16, 12);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Size = new System.Drawing.Size(604, 87);
            this.gbBusqueda.TabIndex = 6;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Búsqueda";
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Location = new System.Drawing.Point(107, 15);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(416, 59);
            this.pnlBusqueda.TabIndex = 0;
            // 
            // dgvProfesores
            // 
            this.dgvProfesores.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesores.Location = new System.Drawing.Point(33, 128);
            this.dgvProfesores.Name = "dgvProfesores";
            this.dgvProfesores.Size = new System.Drawing.Size(567, 345);
            this.dgvProfesores.TabIndex = 1;
            this.dgvProfesores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfesores_CellClick);
            // 
            // frmProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 510);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProfesores";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Gestion de Profesores";
            this.Load += new System.EventHandler(this.frmProfesores_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbBusqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbEmailProf;
        private System.Windows.Forms.TextBox tbTelefonoProf;
        private System.Windows.Forms.TextBox tbDireccionProf;
        private System.Windows.Forms.DateTimePicker dtpFechaNacAlu;
        private System.Windows.Forms.RadioButton rbSexoProf_F;
        private System.Windows.Forms.RadioButton rbSexoProf_H;
        private System.Windows.Forms.TextBox tbDniProf;
        private System.Windows.Forms.TextBox tbApellidoProf;
        private System.Windows.Forms.TextBox tbNombreProf;
        private System.Windows.Forms.Label lblEmailProf;
        private System.Windows.Forms.Label lblTelefonoProf;
        private System.Windows.Forms.Label lblDireccionProf;
        private System.Windows.Forms.Label lblFechaNacProf;
        private System.Windows.Forms.Label lblSexoAlumno;
        private System.Windows.Forms.Label lblDniProfesor;
        private System.Windows.Forms.Label lblApellidosProf;
        private System.Windows.Forms.Label lblNombresProf;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbEspecialidadProf;
        private System.Windows.Forms.Label lblEspecialidadProf;
        private System.Windows.Forms.TextBox tbNivelProf;
        private System.Windows.Forms.Label lblNivelProf;
        private System.Windows.Forms.Panel pnlAbm;
        private System.Windows.Forms.DataGridView dgvProfesores;
        private System.Windows.Forms.GroupBox gbBusqueda;
        private System.Windows.Forms.Panel pnlBusqueda;
    }
}