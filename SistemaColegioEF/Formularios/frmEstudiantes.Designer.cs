﻿namespace SistemaColegioEF.Formularios
{
    partial class frmEstudiantes
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
            this.tbEmailAlu = new System.Windows.Forms.TextBox();
            this.tbTelefonoAlu = new System.Windows.Forms.TextBox();
            this.tbDireccionAlu = new System.Windows.Forms.TextBox();
            this.dtpFechaNacAlu = new System.Windows.Forms.DateTimePicker();
            this.rbSexoAlu_F = new System.Windows.Forms.RadioButton();
            this.rbSexoAlu_H = new System.Windows.Forms.RadioButton();
            this.tbDniAlumno = new System.Windows.Forms.TextBox();
            this.tbApellidoAlu = new System.Windows.Forms.TextBox();
            this.tbNombreAlu = new System.Windows.Forms.TextBox();
            this.lblEmailAlu = new System.Windows.Forms.Label();
            this.lblTelefonoAlu = new System.Windows.Forms.Label();
            this.lblDireccionAlu = new System.Windows.Forms.Label();
            this.lblFechaNacAlumno = new System.Windows.Forms.Label();
            this.lblSexoAlumno = new System.Windows.Forms.Label();
            this.lblDniAlumno = new System.Windows.Forms.Label();
            this.lblApellidosAlu = new System.Windows.Forms.Label();
            this.lblNombresAlu = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbNroLegajoAlu = new System.Windows.Forms.TextBox();
            this.lblNroLegajoAlu = new System.Windows.Forms.Label();
            this.tbAñoLectivoAlu = new System.Windows.Forms.TextBox();
            this.lblAñoLectivo = new System.Windows.Forms.Label();
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.btnSalirAlu = new System.Windows.Forms.Button();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.ucAbm1 = new SistemaColegioEF.Controls.ucAbm();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
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
            this.splitContainer1.Panel1.BackgroundImage = global::SistemaColegioEF.Properties.Resources.panel1;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.pnlAbm);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = global::SistemaColegioEF.Properties.Resources.panel2;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel2.Controls.Add(this.gbBusqueda);
            this.splitContainer1.Panel2.Controls.Add(this.btnSalirAlu);
            this.splitContainer1.Panel2.Controls.Add(this.dgvAlumnos);
            this.splitContainer1.Size = new System.Drawing.Size(927, 510);
            this.splitContainer1.SplitterDistance = 291;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // pnlAbm
            // 
            this.pnlAbm.BackColor = System.Drawing.Color.Transparent;
            this.pnlAbm.Location = new System.Drawing.Point(23, 423);
            this.pnlAbm.Name = "pnlAbm";
            this.pnlAbm.Size = new System.Drawing.Size(235, 75);
            this.pnlAbm.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tbEmailAlu);
            this.groupBox1.Controls.Add(this.tbTelefonoAlu);
            this.groupBox1.Controls.Add(this.tbDireccionAlu);
            this.groupBox1.Controls.Add(this.dtpFechaNacAlu);
            this.groupBox1.Controls.Add(this.rbSexoAlu_F);
            this.groupBox1.Controls.Add(this.rbSexoAlu_H);
            this.groupBox1.Controls.Add(this.tbDniAlumno);
            this.groupBox1.Controls.Add(this.tbApellidoAlu);
            this.groupBox1.Controls.Add(this.tbNombreAlu);
            this.groupBox1.Controls.Add(this.lblEmailAlu);
            this.groupBox1.Controls.Add(this.lblTelefonoAlu);
            this.groupBox1.Controls.Add(this.lblDireccionAlu);
            this.groupBox1.Controls.Add(this.lblFechaNacAlumno);
            this.groupBox1.Controls.Add(this.lblSexoAlumno);
            this.groupBox1.Controls.Add(this.lblDniAlumno);
            this.groupBox1.Controls.Add(this.lblApellidosAlu);
            this.groupBox1.Controls.Add(this.lblNombresAlu);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 398);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion Personal";
            // 
            // tbEmailAlu
            // 
            this.tbEmailAlu.Location = new System.Drawing.Point(95, 250);
            this.tbEmailAlu.Name = "tbEmailAlu";
            this.tbEmailAlu.Size = new System.Drawing.Size(140, 20);
            this.tbEmailAlu.TabIndex = 18;
            // 
            // tbTelefonoAlu
            // 
            this.tbTelefonoAlu.Location = new System.Drawing.Point(95, 221);
            this.tbTelefonoAlu.Name = "tbTelefonoAlu";
            this.tbTelefonoAlu.Size = new System.Drawing.Size(140, 20);
            this.tbTelefonoAlu.TabIndex = 17;
            this.tbTelefonoAlu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefonoAlu_KeyPress);
            // 
            // tbDireccionAlu
            // 
            this.tbDireccionAlu.Location = new System.Drawing.Point(95, 186);
            this.tbDireccionAlu.Name = "tbDireccionAlu";
            this.tbDireccionAlu.Size = new System.Drawing.Size(140, 20);
            this.tbDireccionAlu.TabIndex = 16;
            // 
            // dtpFechaNacAlu
            // 
            this.dtpFechaNacAlu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacAlu.Location = new System.Drawing.Point(133, 151);
            this.dtpFechaNacAlu.Name = "dtpFechaNacAlu";
            this.dtpFechaNacAlu.Size = new System.Drawing.Size(102, 20);
            this.dtpFechaNacAlu.TabIndex = 15;
            // 
            // rbSexoAlu_F
            // 
            this.rbSexoAlu_F.AutoSize = true;
            this.rbSexoAlu_F.Location = new System.Drawing.Point(173, 123);
            this.rbSexoAlu_F.Name = "rbSexoAlu_F";
            this.rbSexoAlu_F.Size = new System.Drawing.Size(56, 17);
            this.rbSexoAlu_F.TabIndex = 14;
            this.rbSexoAlu_F.TabStop = true;
            this.rbSexoAlu_F.Text = "Mujer";
            this.rbSexoAlu_F.UseVisualStyleBackColor = true;
            // 
            // rbSexoAlu_H
            // 
            this.rbSexoAlu_H.AutoSize = true;
            this.rbSexoAlu_H.Location = new System.Drawing.Point(95, 123);
            this.rbSexoAlu_H.Name = "rbSexoAlu_H";
            this.rbSexoAlu_H.Size = new System.Drawing.Size(68, 17);
            this.rbSexoAlu_H.TabIndex = 13;
            this.rbSexoAlu_H.TabStop = true;
            this.rbSexoAlu_H.Text = "Hombre";
            this.rbSexoAlu_H.UseVisualStyleBackColor = true;
            // 
            // tbDniAlumno
            // 
            this.tbDniAlumno.Location = new System.Drawing.Point(95, 90);
            this.tbDniAlumno.MaxLength = 10;
            this.tbDniAlumno.Name = "tbDniAlumno";
            this.tbDniAlumno.Size = new System.Drawing.Size(140, 20);
            this.tbDniAlumno.TabIndex = 12;
            this.tbDniAlumno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDniAlumno_KeyPress);
            // 
            // tbApellidoAlu
            // 
            this.tbApellidoAlu.Location = new System.Drawing.Point(95, 58);
            this.tbApellidoAlu.Name = "tbApellidoAlu";
            this.tbApellidoAlu.Size = new System.Drawing.Size(140, 20);
            this.tbApellidoAlu.TabIndex = 11;
            // 
            // tbNombreAlu
            // 
            this.tbNombreAlu.Location = new System.Drawing.Point(95, 26);
            this.tbNombreAlu.Name = "tbNombreAlu";
            this.tbNombreAlu.Size = new System.Drawing.Size(140, 20);
            this.tbNombreAlu.TabIndex = 10;
            // 
            // lblEmailAlu
            // 
            this.lblEmailAlu.AutoSize = true;
            this.lblEmailAlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAlu.Location = new System.Drawing.Point(18, 253);
            this.lblEmailAlu.Name = "lblEmailAlu";
            this.lblEmailAlu.Size = new System.Drawing.Size(35, 13);
            this.lblEmailAlu.TabIndex = 9;
            this.lblEmailAlu.Text = "Email:";
            // 
            // lblTelefonoAlu
            // 
            this.lblTelefonoAlu.AutoSize = true;
            this.lblTelefonoAlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoAlu.Location = new System.Drawing.Point(18, 221);
            this.lblTelefonoAlu.Name = "lblTelefonoAlu";
            this.lblTelefonoAlu.Size = new System.Drawing.Size(52, 13);
            this.lblTelefonoAlu.TabIndex = 8;
            this.lblTelefonoAlu.Text = "Telefono:";
            // 
            // lblDireccionAlu
            // 
            this.lblDireccionAlu.AutoSize = true;
            this.lblDireccionAlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionAlu.Location = new System.Drawing.Point(18, 189);
            this.lblDireccionAlu.Name = "lblDireccionAlu";
            this.lblDireccionAlu.Size = new System.Drawing.Size(55, 13);
            this.lblDireccionAlu.TabIndex = 7;
            this.lblDireccionAlu.Text = "Direccion:";
            // 
            // lblFechaNacAlumno
            // 
            this.lblFechaNacAlumno.AutoSize = true;
            this.lblFechaNacAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacAlumno.Location = new System.Drawing.Point(18, 157);
            this.lblFechaNacAlumno.Name = "lblFechaNacAlumno";
            this.lblFechaNacAlumno.Size = new System.Drawing.Size(109, 13);
            this.lblFechaNacAlumno.TabIndex = 6;
            this.lblFechaNacAlumno.Text = "Fecha de nacimiento:";
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
            // lblDniAlumno
            // 
            this.lblDniAlumno.AutoSize = true;
            this.lblDniAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniAlumno.Location = new System.Drawing.Point(18, 93);
            this.lblDniAlumno.Name = "lblDniAlumno";
            this.lblDniAlumno.Size = new System.Drawing.Size(29, 13);
            this.lblDniAlumno.TabIndex = 4;
            this.lblDniAlumno.Text = "DNI:";
            // 
            // lblApellidosAlu
            // 
            this.lblApellidosAlu.AutoSize = true;
            this.lblApellidosAlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidosAlu.Location = new System.Drawing.Point(18, 61);
            this.lblApellidosAlu.Name = "lblApellidosAlu";
            this.lblApellidosAlu.Size = new System.Drawing.Size(57, 13);
            this.lblApellidosAlu.TabIndex = 3;
            this.lblApellidosAlu.Text = "Apellido/s:";
            // 
            // lblNombresAlu
            // 
            this.lblNombresAlu.AutoSize = true;
            this.lblNombresAlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombresAlu.Location = new System.Drawing.Point(18, 29);
            this.lblNombresAlu.Name = "lblNombresAlu";
            this.lblNombresAlu.Size = new System.Drawing.Size(57, 13);
            this.lblNombresAlu.TabIndex = 2;
            this.lblNombresAlu.Text = "Nombre/s:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbNroLegajoAlu);
            this.groupBox2.Controls.Add(this.lblNroLegajoAlu);
            this.groupBox2.Controls.Add(this.tbAñoLectivoAlu);
            this.groupBox2.Controls.Add(this.lblAñoLectivo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(0, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 103);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registro Académico";
            // 
            // tbNroLegajoAlu
            // 
            this.tbNroLegajoAlu.Location = new System.Drawing.Point(95, 66);
            this.tbNroLegajoAlu.Name = "tbNroLegajoAlu";
            this.tbNroLegajoAlu.Size = new System.Drawing.Size(140, 20);
            this.tbNroLegajoAlu.TabIndex = 20;
            this.tbNroLegajoAlu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNroLegajoAlu_KeyPress);
            // 
            // lblNroLegajoAlu
            // 
            this.lblNroLegajoAlu.AutoSize = true;
            this.lblNroLegajoAlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroLegajoAlu.Location = new System.Drawing.Point(18, 69);
            this.lblNroLegajoAlu.Name = "lblNroLegajoAlu";
            this.lblNroLegajoAlu.Size = new System.Drawing.Size(72, 13);
            this.lblNroLegajoAlu.TabIndex = 20;
            this.lblNroLegajoAlu.Text = "N° de Legajo:";
            // 
            // tbAñoLectivoAlu
            // 
            this.tbAñoLectivoAlu.Location = new System.Drawing.Point(95, 33);
            this.tbAñoLectivoAlu.Name = "tbAñoLectivoAlu";
            this.tbAñoLectivoAlu.Size = new System.Drawing.Size(140, 20);
            this.tbAñoLectivoAlu.TabIndex = 19;
            this.tbAñoLectivoAlu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAñoLectivoAlu_KeyPress);
            // 
            // lblAñoLectivo
            // 
            this.lblAñoLectivo.AutoSize = true;
            this.lblAñoLectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAñoLectivo.Location = new System.Drawing.Point(17, 36);
            this.lblAñoLectivo.Name = "lblAñoLectivo";
            this.lblAñoLectivo.Size = new System.Drawing.Size(67, 13);
            this.lblAñoLectivo.TabIndex = 19;
            this.lblAñoLectivo.Text = "Año Lectivo:";
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.gbBusqueda.Controls.Add(this.pnlBusqueda);
            this.gbBusqueda.Location = new System.Drawing.Point(16, 12);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Size = new System.Drawing.Size(604, 87);
            this.gbBusqueda.TabIndex = 5;
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
            // btnSalirAlu
            // 
            this.btnSalirAlu.Location = new System.Drawing.Point(545, 475);
            this.btnSalirAlu.Name = "btnSalirAlu";
            this.btnSalirAlu.Size = new System.Drawing.Size(75, 23);
            this.btnSalirAlu.TabIndex = 4;
            this.btnSalirAlu.Text = "Salir";
            this.btnSalirAlu.UseVisualStyleBackColor = true;
            this.btnSalirAlu.Click += new System.EventHandler(this.btnSalirAlu_Click);
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(16, 105);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.Size = new System.Drawing.Size(604, 364);
            this.dgvAlumnos.TabIndex = 0;
            this.dgvAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumnos_CellClick);
            // 
            // ucAbm1
            // 
            this.ucAbm1.BackColor = System.Drawing.Color.Gold;
            this.ucAbm1.Location = new System.Drawing.Point(28, 3);
            this.ucAbm1.Name = "ucAbm1";
            this.ucAbm1.Size = new System.Drawing.Size(235, 75);
            this.ucAbm1.TabIndex = 0;
            this.ucAbm1.Valid = false;
            // 
            // frmEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 510);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEstudiantes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Estudiantes";
            this.Load += new System.EventHandler(this.frmEstudiantes_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbBusqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSexoAlu_F;
        private System.Windows.Forms.RadioButton rbSexoAlu_H;
        private System.Windows.Forms.TextBox tbDniAlumno;
        private System.Windows.Forms.TextBox tbApellidoAlu;
        private System.Windows.Forms.TextBox tbNombreAlu;
        private System.Windows.Forms.Label lblEmailAlu;
        private System.Windows.Forms.Label lblTelefonoAlu;
        private System.Windows.Forms.Label lblDireccionAlu;
        private System.Windows.Forms.Label lblFechaNacAlumno;
        private System.Windows.Forms.Label lblSexoAlumno;
        private System.Windows.Forms.Label lblDniAlumno;
        private System.Windows.Forms.Label lblApellidosAlu;
        private System.Windows.Forms.Label lblNombresAlu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpFechaNacAlu;
        private System.Windows.Forms.TextBox tbDireccionAlu;
        private System.Windows.Forms.TextBox tbTelefonoAlu;
        private System.Windows.Forms.TextBox tbEmailAlu;
        private System.Windows.Forms.TextBox tbNroLegajoAlu;
        private System.Windows.Forms.Label lblNroLegajoAlu;
        private System.Windows.Forms.TextBox tbAñoLectivoAlu;
        private System.Windows.Forms.Label lblAñoLectivo;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Button btnSalirAlu;
        private System.Windows.Forms.Panel pnlAbm;
        private Controls.ucAbm ucAbm1;
        private System.Windows.Forms.GroupBox gbBusqueda;
        private System.Windows.Forms.Panel pnlBusqueda;
    }
}