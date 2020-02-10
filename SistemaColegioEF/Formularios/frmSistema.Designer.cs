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
            this.lblTituloSistema = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnNuevoSys = new System.Windows.Forms.Button();
            this.btnEditarSys = new System.Windows.Forms.Button();
            this.btnEliminarSys = new System.Windows.Forms.Button();
            this.btnSalirSys = new System.Windows.Forms.Button();
            this.gbSistema_ABM = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblContraseñaSys = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblPermisoSys = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnGuardarSys = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gbSistema_ABM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.splitContainer1.Panel1.BackgroundImage = global::SistemaColegioEF.Properties.Resources.celeste;
            this.splitContainer1.Panel1.Controls.Add(this.lblTituloSistema);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(721, 448);
            this.splitContainer1.SplitterDistance = 101;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblTituloSistema
            // 
            this.lblTituloSistema.AutoSize = true;
            this.lblTituloSistema.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloSistema.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTituloSistema.Location = new System.Drawing.Point(107, 39);
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
            this.splitContainer2.Panel1.BackgroundImage = global::SistemaColegioEF.Properties.Resources.celeste;
            this.splitContainer2.Panel1.Controls.Add(this.btnSalirSys);
            this.splitContainer2.Panel1.Controls.Add(this.btnEliminarSys);
            this.splitContainer2.Panel1.Controls.Add(this.btnEditarSys);
            this.splitContainer2.Panel1.Controls.Add(this.btnNuevoSys);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackgroundImage = global::SistemaColegioEF.Properties.Resources.celeste;
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer2.Panel2.Controls.Add(this.gbSistema_ABM);
            this.splitContainer2.Size = new System.Drawing.Size(721, 343);
            this.splitContainer2.SplitterDistance = 105;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnNuevoSys
            // 
            this.btnNuevoSys.Location = new System.Drawing.Point(3, 15);
            this.btnNuevoSys.Name = "btnNuevoSys";
            this.btnNuevoSys.Size = new System.Drawing.Size(99, 38);
            this.btnNuevoSys.TabIndex = 0;
            this.btnNuevoSys.Text = "Nuevo";
            this.btnNuevoSys.UseVisualStyleBackColor = true;
            // 
            // btnEditarSys
            // 
            this.btnEditarSys.Location = new System.Drawing.Point(3, 68);
            this.btnEditarSys.Name = "btnEditarSys";
            this.btnEditarSys.Size = new System.Drawing.Size(99, 38);
            this.btnEditarSys.TabIndex = 1;
            this.btnEditarSys.Text = "Editar";
            this.btnEditarSys.UseVisualStyleBackColor = true;
            // 
            // btnEliminarSys
            // 
            this.btnEliminarSys.Location = new System.Drawing.Point(3, 123);
            this.btnEliminarSys.Name = "btnEliminarSys";
            this.btnEliminarSys.Size = new System.Drawing.Size(99, 38);
            this.btnEliminarSys.TabIndex = 2;
            this.btnEliminarSys.Text = "Eliminar";
            this.btnEliminarSys.UseVisualStyleBackColor = true;
            // 
            // btnSalirSys
            // 
            this.btnSalirSys.Location = new System.Drawing.Point(3, 302);
            this.btnSalirSys.Name = "btnSalirSys";
            this.btnSalirSys.Size = new System.Drawing.Size(99, 38);
            this.btnSalirSys.TabIndex = 3;
            this.btnSalirSys.Text = "Salir";
            this.btnSalirSys.UseVisualStyleBackColor = true;
            // 
            // gbSistema_ABM
            // 
            this.gbSistema_ABM.BackColor = System.Drawing.Color.Transparent;
            this.gbSistema_ABM.Controls.Add(this.btnGuardarSys);
            this.gbSistema_ABM.Controls.Add(this.comboBox1);
            this.gbSistema_ABM.Controls.Add(this.lblPermisoSys);
            this.gbSistema_ABM.Controls.Add(this.textBox2);
            this.gbSistema_ABM.Controls.Add(this.textBox1);
            this.gbSistema_ABM.Controls.Add(this.label2);
            this.gbSistema_ABM.Controls.Add(this.lblContraseñaSys);
            this.gbSistema_ABM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSistema_ABM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbSistema_ABM.Location = new System.Drawing.Point(21, 15);
            this.gbSistema_ABM.Name = "gbSistema_ABM";
            this.gbSistema_ABM.Size = new System.Drawing.Size(567, 103);
            this.gbSistema_ABM.TabIndex = 0;
            this.gbSistema_ABM.TabStop = false;
            this.gbSistema_ABM.Text = "Gestion de Usuarios";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(567, 175);
            this.dataGridView1.TabIndex = 1;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 20);
            this.textBox2.TabIndex = 3;
            // 
            // lblPermisoSys
            // 
            this.lblPermisoSys.AutoSize = true;
            this.lblPermisoSys.Location = new System.Drawing.Point(313, 32);
            this.lblPermisoSys.Name = "lblPermisoSys";
            this.lblPermisoSys.Size = new System.Drawing.Size(106, 13);
            this.lblPermisoSys.TabIndex = 4;
            this.lblPermisoSys.Text = "Permiso asignado";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(307, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // btnGuardarSys
            // 
            this.btnGuardarSys.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGuardarSys.Location = new System.Drawing.Point(450, 32);
            this.btnGuardarSys.Name = "btnGuardarSys";
            this.btnGuardarSys.Size = new System.Drawing.Size(101, 50);
            this.btnGuardarSys.TabIndex = 4;
            this.btnGuardarSys.Text = "Guardar";
            this.btnGuardarSys.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SistemaColegioEF.Properties.Resources.equipo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 448);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmSistema";
            this.Text = "frmSistema";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.gbSistema_ABM.ResumeLayout(false);
            this.gbSistema_ABM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblTituloSistema;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnSalirSys;
        private System.Windows.Forms.Button btnEliminarSys;
        private System.Windows.Forms.Button btnEditarSys;
        private System.Windows.Forms.Button btnNuevoSys;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbSistema_ABM;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblPermisoSys;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblContraseñaSys;
        private System.Windows.Forms.Button btnGuardarSys;
    }
}