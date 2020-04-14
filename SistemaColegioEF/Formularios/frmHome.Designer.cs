namespace SistemaColegioEF.Formularios
{
    partial class frmHome
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
            this.components = new System.ComponentModel.Container();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPermiso = new System.Windows.Forms.Label();
            this.scContenedorHome = new System.Windows.Forms.SplitContainer();
            this.lblHoraActual = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblTituloUsuario = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnAsistencias = new System.Windows.Forms.Button();
            this.btnMaterias = new System.Windows.Forms.Button();
            this.btnCalificaciones = new System.Windows.Forms.Button();
            this.btnProfesores = new System.Windows.Forms.Button();
            this.btnEstudiantes = new System.Windows.Forms.Button();
            this.btnSistema = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.scContenedorHome)).BeginInit();
            this.scContenedorHome.Panel1.SuspendLayout();
            this.scContenedorHome.Panel2.SuspendLayout();
            this.scContenedorHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.Red;
            this.btnCerrarSesion.Location = new System.Drawing.Point(399, 9);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(85, 23);
            this.btnCerrarSesion.TabIndex = 1;
            this.btnCerrarSesion.Text = "Cerrar sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblUsuario.Location = new System.Drawing.Point(94, 14);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(62, 17);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "nombre";
            // 
            // lblPermiso
            // 
            this.lblPermiso.AutoSize = true;
            this.lblPermiso.Location = new System.Drawing.Point(343, 16);
            this.lblPermiso.Name = "lblPermiso";
            this.lblPermiso.Size = new System.Drawing.Size(43, 13);
            this.lblPermiso.TabIndex = 4;
            this.lblPermiso.Text = "permiso";
            // 
            // scContenedorHome
            // 
            this.scContenedorHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scContenedorHome.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scContenedorHome.IsSplitterFixed = true;
            this.scContenedorHome.Location = new System.Drawing.Point(0, 0);
            this.scContenedorHome.Name = "scContenedorHome";
            // 
            // scContenedorHome.Panel1
            // 
            this.scContenedorHome.Panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.scContenedorHome.Panel1.Controls.Add(this.lblHoraActual);
            this.scContenedorHome.Panel1.Controls.Add(this.monthCalendar1);
            // 
            // scContenedorHome.Panel2
            // 
            this.scContenedorHome.Panel2.BackColor = System.Drawing.Color.SlateBlue;
            this.scContenedorHome.Panel2.Controls.Add(this.lblTituloUsuario);
            this.scContenedorHome.Panel2.Controls.Add(this.btnInfo);
            this.scContenedorHome.Panel2.Controls.Add(this.btnAsistencias);
            this.scContenedorHome.Panel2.Controls.Add(this.btnMaterias);
            this.scContenedorHome.Panel2.Controls.Add(this.btnCalificaciones);
            this.scContenedorHome.Panel2.Controls.Add(this.btnProfesores);
            this.scContenedorHome.Panel2.Controls.Add(this.btnEstudiantes);
            this.scContenedorHome.Panel2.Controls.Add(this.btnSistema);
            this.scContenedorHome.Panel2.Controls.Add(this.btnCerrarSesion);
            this.scContenedorHome.Panel2.Controls.Add(this.lblPermiso);
            this.scContenedorHome.Panel2.Controls.Add(this.lblUsuario);
            this.scContenedorHome.Size = new System.Drawing.Size(781, 396);
            this.scContenedorHome.SplitterDistance = 270;
            this.scContenedorHome.TabIndex = 5;
            this.scContenedorHome.TabStop = false;
            // 
            // lblHoraActual
            // 
            this.lblHoraActual.AutoSize = true;
            this.lblHoraActual.Font = new System.Drawing.Font("Agency FB", 35F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraActual.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHoraActual.Location = new System.Drawing.Point(28, 83);
            this.lblHoraActual.Name = "lblHoraActual";
            this.lblHoraActual.Size = new System.Drawing.Size(209, 57);
            this.lblHoraActual.TabIndex = 5;
            this.lblHoraActual.Text = "Hora actual";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.monthCalendar1.Location = new System.Drawing.Point(9, 219);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            // 
            // lblTituloUsuario
            // 
            this.lblTituloUsuario.AutoSize = true;
            this.lblTituloUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTituloUsuario.Location = new System.Drawing.Point(23, 14);
            this.lblTituloUsuario.Name = "lblTituloUsuario";
            this.lblTituloUsuario.Size = new System.Drawing.Size(69, 17);
            this.lblTituloUsuario.TabIndex = 12;
            this.lblTituloUsuario.Text = "Usuario:";
            // 
            // btnInfo
            // 
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInfo.Image = global::SistemaColegioEF.Properties.Resources.info;
            this.btnInfo.Location = new System.Drawing.Point(455, 351);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(29, 30);
            this.btnInfo.TabIndex = 11;
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // btnAsistencias
            // 
            this.btnAsistencias.Image = global::SistemaColegioEF.Properties.Resources.prueba;
            this.btnAsistencias.Location = new System.Drawing.Point(346, 219);
            this.btnAsistencias.Name = "btnAsistencias";
            this.btnAsistencias.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAsistencias.Size = new System.Drawing.Size(138, 127);
            this.btnAsistencias.TabIndex = 10;
            this.btnAsistencias.Text = "Asistencias";
            this.btnAsistencias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAsistencias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAsistencias.UseVisualStyleBackColor = true;
            // 
            // btnMaterias
            // 
            this.btnMaterias.Image = global::SistemaColegioEF.Properties.Resources.libro;
            this.btnMaterias.Location = new System.Drawing.Point(186, 219);
            this.btnMaterias.Name = "btnMaterias";
            this.btnMaterias.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMaterias.Size = new System.Drawing.Size(138, 127);
            this.btnMaterias.TabIndex = 9;
            this.btnMaterias.Text = "Materias";
            this.btnMaterias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMaterias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMaterias.UseVisualStyleBackColor = true;
            // 
            // btnCalificaciones
            // 
            this.btnCalificaciones.Image = global::SistemaColegioEF.Properties.Resources.calificaciones;
            this.btnCalificaciones.Location = new System.Drawing.Point(26, 219);
            this.btnCalificaciones.Name = "btnCalificaciones";
            this.btnCalificaciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCalificaciones.Size = new System.Drawing.Size(138, 127);
            this.btnCalificaciones.TabIndex = 8;
            this.btnCalificaciones.Text = "Calificaciones";
            this.btnCalificaciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCalificaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCalificaciones.UseVisualStyleBackColor = true;
            // 
            // btnProfesores
            // 
            this.btnProfesores.Image = global::SistemaColegioEF.Properties.Resources.profesor;
            this.btnProfesores.Location = new System.Drawing.Point(346, 83);
            this.btnProfesores.Name = "btnProfesores";
            this.btnProfesores.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnProfesores.Size = new System.Drawing.Size(138, 127);
            this.btnProfesores.TabIndex = 7;
            this.btnProfesores.Text = "Profesores";
            this.btnProfesores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProfesores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProfesores.UseVisualStyleBackColor = true;
            // 
            // btnEstudiantes
            // 
            this.btnEstudiantes.Image = global::SistemaColegioEF.Properties.Resources.estudiante;
            this.btnEstudiantes.Location = new System.Drawing.Point(186, 83);
            this.btnEstudiantes.Name = "btnEstudiantes";
            this.btnEstudiantes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEstudiantes.Size = new System.Drawing.Size(138, 127);
            this.btnEstudiantes.TabIndex = 6;
            this.btnEstudiantes.Text = "Estudiantes";
            this.btnEstudiantes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEstudiantes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEstudiantes.UseVisualStyleBackColor = true;
            this.btnEstudiantes.Click += new System.EventHandler(this.btnEstudiantes_Click);
            // 
            // btnSistema
            // 
            this.btnSistema.Image = global::SistemaColegioEF.Properties.Resources.bloquear;
            this.btnSistema.Location = new System.Drawing.Point(26, 83);
            this.btnSistema.Name = "btnSistema";
            this.btnSistema.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSistema.Size = new System.Drawing.Size(138, 127);
            this.btnSistema.TabIndex = 5;
            this.btnSistema.Text = "Sistema";
            this.btnSistema.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSistema.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSistema.UseVisualStyleBackColor = true;
            this.btnSistema.Click += new System.EventHandler(this.btnSistema_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(781, 396);
            this.Controls.Add(this.scContenedorHome);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(797, 435);
            this.MinimumSize = new System.Drawing.Size(797, 435);
            this.Name = "frmHome";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Escolar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHome_FormClosing);
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.scContenedorHome.Panel1.ResumeLayout(false);
            this.scContenedorHome.Panel1.PerformLayout();
            this.scContenedorHome.Panel2.ResumeLayout(false);
            this.scContenedorHome.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scContenedorHome)).EndInit();
            this.scContenedorHome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCerrarSesion;
        public System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPermiso;
        private System.Windows.Forms.SplitContainer scContenedorHome;
        private System.Windows.Forms.Label lblHoraActual;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSistema;
        private System.Windows.Forms.Button btnAsistencias;
        private System.Windows.Forms.Button btnMaterias;
        private System.Windows.Forms.Button btnCalificaciones;
        private System.Windows.Forms.Button btnProfesores;
        private System.Windows.Forms.Button btnEstudiantes;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Label lblTituloUsuario;
    }
}