namespace SistemaColegioEF.Formularios
{
    partial class frmSistema
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTituloSistema = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnSalirSys = new System.Windows.Forms.Button();
            this.btnEliminarSys = new System.Windows.Forms.Button();
            this.btnNuevoSys = new System.Windows.Forms.Button();
            this.btnListarUsuariosSys = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbBusquedaUsuarioNombre = new System.Windows.Forms.TextBox();
            this.gbListaUsuarios = new System.Windows.Forms.GroupBox();
            this.dgvUsuariosSys = new System.Windows.Forms.DataGridView();
            this.gbSistema_ABM = new System.Windows.Forms.GroupBox();
            this.btnCancelarSys = new System.Windows.Forms.Button();
            this.btnGuardarSys = new System.Windows.Forms.Button();
            this.cbPermisosSys = new System.Windows.Forms.ComboBox();
            this.lblPermisoSys = new System.Windows.Forms.Label();
            this.tbContraseñaSys = new System.Windows.Forms.TextBox();
            this.tbUsuarioSys = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblContraseñaSys = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbListaUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosSys)).BeginInit();
            this.gbSistema_ABM.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.BackgroundImage = global::SistemaColegioEF.Properties.Resources.celeste;
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.lblTituloSistema);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(721, 448);
            this.splitContainer1.SplitterDistance = 99;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SistemaColegioEF.Properties.Resources.equipo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblTituloSistema
            // 
            this.lblTituloSistema.AutoSize = true;
            this.lblTituloSistema.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloSistema.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTituloSistema.Location = new System.Drawing.Point(122, 35);
            this.lblTituloSistema.Name = "lblTituloSistema";
            this.lblTituloSistema.Size = new System.Drawing.Size(275, 31);
            this.lblTituloSistema.TabIndex = 1;
            this.lblTituloSistema.Text = "Gestión del Sistema";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer2.Panel1.BackgroundImage = global::SistemaColegioEF.Properties.Resources.celeste;
            this.splitContainer2.Panel1.Controls.Add(this.btnSalirSys);
            this.splitContainer2.Panel1.Controls.Add(this.btnEliminarSys);
            this.splitContainer2.Panel1.Controls.Add(this.btnNuevoSys);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer2.Panel2.BackgroundImage = global::SistemaColegioEF.Properties.Resources.celeste;
            this.splitContainer2.Panel2.Controls.Add(this.btnListarUsuariosSys);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Panel2.Controls.Add(this.gbListaUsuarios);
            this.splitContainer2.Panel2.Controls.Add(this.gbSistema_ABM);
            this.splitContainer2.Size = new System.Drawing.Size(721, 345);
            this.splitContainer2.SplitterDistance = 82;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnSalirSys
            // 
            this.btnSalirSys.BackColor = System.Drawing.Color.Transparent;
            this.btnSalirSys.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirSys.ForeColor = System.Drawing.Color.Red;
            this.btnSalirSys.Image = global::SistemaColegioEF.Properties.Resources.exit;
            this.btnSalirSys.Location = new System.Drawing.Point(12, 279);
            this.btnSalirSys.Name = "btnSalirSys";
            this.btnSalirSys.Size = new System.Drawing.Size(50, 55);
            this.btnSalirSys.TabIndex = 3;
            this.btnSalirSys.UseVisualStyleBackColor = false;
            this.btnSalirSys.Click += new System.EventHandler(this.btnSalirSys_Click);
            // 
            // btnEliminarSys
            // 
            this.btnEliminarSys.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEliminarSys.Enabled = false;
            this.btnEliminarSys.Image = global::SistemaColegioEF.Properties.Resources.user_delete;
            this.btnEliminarSys.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminarSys.Location = new System.Drawing.Point(10, 89);
            this.btnEliminarSys.Name = "btnEliminarSys";
            this.btnEliminarSys.Size = new System.Drawing.Size(59, 73);
            this.btnEliminarSys.TabIndex = 2;
            this.btnEliminarSys.Text = "Eliminar";
            this.btnEliminarSys.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminarSys.UseVisualStyleBackColor = false;
            this.btnEliminarSys.Click += new System.EventHandler(this.btnEliminarSys_Click);
            // 
            // btnNuevoSys
            // 
            this.btnNuevoSys.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNuevoSys.Image = global::SistemaColegioEF.Properties.Resources.user_add;
            this.btnNuevoSys.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnNuevoSys.Location = new System.Drawing.Point(10, 12);
            this.btnNuevoSys.Name = "btnNuevoSys";
            this.btnNuevoSys.Size = new System.Drawing.Size(59, 71);
            this.btnNuevoSys.TabIndex = 0;
            this.btnNuevoSys.Text = "Nuevo";
            this.btnNuevoSys.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevoSys.UseVisualStyleBackColor = false;
            this.btnNuevoSys.Click += new System.EventHandler(this.btnNuevoSys_Click);
            // 
            // btnListarUsuariosSys
            // 
            this.btnListarUsuariosSys.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnListarUsuariosSys.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnListarUsuariosSys.Location = new System.Drawing.Point(429, 291);
            this.btnListarUsuariosSys.Name = "btnListarUsuariosSys";
            this.btnListarUsuariosSys.Size = new System.Drawing.Size(159, 30);
            this.btnListarUsuariosSys.TabIndex = 6;
            this.btnListarUsuariosSys.Text = "Listar todos los usuarios";
            this.btnListarUsuariosSys.UseVisualStyleBackColor = false;
            this.btnListarUsuariosSys.Click += new System.EventHandler(this.btnListarUsuariosSys_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.tbBusquedaUsuarioNombre);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(21, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 55);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar usuario por nombre";
            // 
            // tbBusquedaUsuarioNombre
            // 
            this.tbBusquedaUsuarioNombre.Location = new System.Drawing.Point(32, 19);
            this.tbBusquedaUsuarioNombre.Name = "tbBusquedaUsuarioNombre";
            this.tbBusquedaUsuarioNombre.Size = new System.Drawing.Size(195, 20);
            this.tbBusquedaUsuarioNombre.TabIndex = 6;
            this.tbBusquedaUsuarioNombre.TextChanged += new System.EventHandler(this.tbBusquedaUsuarioNombre_TextChanged);
            // 
            // gbListaUsuarios
            // 
            this.gbListaUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.gbListaUsuarios.Controls.Add(this.dgvUsuariosSys);
            this.gbListaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListaUsuarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbListaUsuarios.Location = new System.Drawing.Point(21, 124);
            this.gbListaUsuarios.Name = "gbListaUsuarios";
            this.gbListaUsuarios.Size = new System.Drawing.Size(567, 148);
            this.gbListaUsuarios.TabIndex = 6;
            this.gbListaUsuarios.TabStop = false;
            this.gbListaUsuarios.Text = "Lista de Usuarios";
            // 
            // dgvUsuariosSys
            // 
            this.dgvUsuariosSys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuariosSys.Location = new System.Drawing.Point(17, 19);
            this.dgvUsuariosSys.Name = "dgvUsuariosSys";
            this.dgvUsuariosSys.ReadOnly = true;
            this.dgvUsuariosSys.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuariosSys.Size = new System.Drawing.Size(518, 114);
            this.dgvUsuariosSys.TabIndex = 1;
            this.dgvUsuariosSys.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuariosSys_CellClick);
            // 
            // gbSistema_ABM
            // 
            this.gbSistema_ABM.BackColor = System.Drawing.Color.Transparent;
            this.gbSistema_ABM.Controls.Add(this.btnCancelarSys);
            this.gbSistema_ABM.Controls.Add(this.btnGuardarSys);
            this.gbSistema_ABM.Controls.Add(this.cbPermisosSys);
            this.gbSistema_ABM.Controls.Add(this.lblPermisoSys);
            this.gbSistema_ABM.Controls.Add(this.tbContraseñaSys);
            this.gbSistema_ABM.Controls.Add(this.tbUsuarioSys);
            this.gbSistema_ABM.Controls.Add(this.label2);
            this.gbSistema_ABM.Controls.Add(this.lblContraseñaSys);
            this.gbSistema_ABM.Enabled = false;
            this.gbSistema_ABM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSistema_ABM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbSistema_ABM.Location = new System.Drawing.Point(21, 15);
            this.gbSistema_ABM.Name = "gbSistema_ABM";
            this.gbSistema_ABM.Size = new System.Drawing.Size(567, 103);
            this.gbSistema_ABM.TabIndex = 0;
            this.gbSistema_ABM.TabStop = false;
            this.gbSistema_ABM.Text = "Gestion de Usuarios";
            // 
            // btnCancelarSys
            // 
            this.btnCancelarSys.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelarSys.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelarSys.Location = new System.Drawing.Point(450, 72);
            this.btnCancelarSys.Name = "btnCancelarSys";
            this.btnCancelarSys.Size = new System.Drawing.Size(101, 21);
            this.btnCancelarSys.TabIndex = 6;
            this.btnCancelarSys.Text = "Cancelar";
            this.btnCancelarSys.UseVisualStyleBackColor = false;
            this.btnCancelarSys.Click += new System.EventHandler(this.btnCancelarSys_Click);
            // 
            // btnGuardarSys
            // 
            this.btnGuardarSys.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardarSys.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGuardarSys.Location = new System.Drawing.Point(450, 20);
            this.btnGuardarSys.Name = "btnGuardarSys";
            this.btnGuardarSys.Size = new System.Drawing.Size(101, 50);
            this.btnGuardarSys.TabIndex = 4;
            this.btnGuardarSys.Text = "Guardar";
            this.btnGuardarSys.UseVisualStyleBackColor = false;
            this.btnGuardarSys.Click += new System.EventHandler(this.btnGuardarSys_Click);
            // 
            // cbPermisosSys
            // 
            this.cbPermisosSys.FormattingEnabled = true;
            this.cbPermisosSys.Location = new System.Drawing.Point(294, 49);
            this.cbPermisosSys.Name = "cbPermisosSys";
            this.cbPermisosSys.Size = new System.Drawing.Size(121, 21);
            this.cbPermisosSys.TabIndex = 5;
            // 
            // lblPermisoSys
            // 
            this.lblPermisoSys.AutoSize = true;
            this.lblPermisoSys.Location = new System.Drawing.Point(300, 28);
            this.lblPermisoSys.Name = "lblPermisoSys";
            this.lblPermisoSys.Size = new System.Drawing.Size(106, 13);
            this.lblPermisoSys.TabIndex = 4;
            this.lblPermisoSys.Text = "Permiso asignado";
            // 
            // tbContraseñaSys
            // 
            this.tbContraseñaSys.Location = new System.Drawing.Point(120, 63);
            this.tbContraseñaSys.Name = "tbContraseñaSys";
            this.tbContraseñaSys.Size = new System.Drawing.Size(147, 20);
            this.tbContraseñaSys.TabIndex = 3;
            // 
            // tbUsuarioSys
            // 
            this.tbUsuarioSys.Location = new System.Drawing.Point(120, 25);
            this.tbUsuarioSys.Name = "tbUsuarioSys";
            this.tbUsuarioSys.Size = new System.Drawing.Size(147, 20);
            this.tbUsuarioSys.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // lblContraseñaSys
            // 
            this.lblContraseñaSys.AutoSize = true;
            this.lblContraseñaSys.Location = new System.Drawing.Point(43, 28);
            this.lblContraseñaSys.Name = "lblContraseñaSys";
            this.lblContraseñaSys.Size = new System.Drawing.Size(50, 13);
            this.lblContraseñaSys.TabIndex = 0;
            this.lblContraseñaSys.Text = "Usuario";
            // 
            // frmSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 448);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSistema";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmSistema_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbListaUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosSys)).EndInit();
            this.gbSistema_ABM.ResumeLayout(false);
            this.gbSistema_ABM.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblTituloSistema;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnSalirSys;
        private System.Windows.Forms.Button btnEliminarSys;
        private System.Windows.Forms.Button btnNuevoSys;
        private System.Windows.Forms.DataGridView dgvUsuariosSys;
        private System.Windows.Forms.GroupBox gbSistema_ABM;
        private System.Windows.Forms.ComboBox cbPermisosSys;
        private System.Windows.Forms.Label lblPermisoSys;
        private System.Windows.Forms.TextBox tbContraseñaSys;
        private System.Windows.Forms.TextBox tbUsuarioSys;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblContraseñaSys;
        private System.Windows.Forms.Button btnGuardarSys;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbListaUsuarios;
        private System.Windows.Forms.Button btnListarUsuariosSys;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbBusquedaUsuarioNombre;
        private System.Windows.Forms.Button btnCancelarSys;
    }
}