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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpGestionMaterias = new System.Windows.Forms.TabPage();
            this.tpInscProf = new System.Windows.Forms.TabPage();
            this.tpInscAlumn = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpGestionMaterias.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(44, 146);
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
            this.pnlAcciones.Location = new System.Drawing.Point(70, 280);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpGestionMaterias);
            this.tabControl1.Controls.Add(this.tpInscProf);
            this.tabControl1.Controls.Add(this.tpInscAlumn);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(725, 538);
            this.tabControl1.TabIndex = 5;
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
            this.tpInscProf.Location = new System.Drawing.Point(4, 22);
            this.tpInscProf.Name = "tpInscProf";
            this.tpInscProf.Padding = new System.Windows.Forms.Padding(3);
            this.tpInscProf.Size = new System.Drawing.Size(717, 512);
            this.tpInscProf.TabIndex = 1;
            this.tpInscProf.Text = "Inscripcion Prof.";
            this.tpInscProf.UseVisualStyleBackColor = true;
            // 
            // tpInscAlumn
            // 
            this.tpInscAlumn.BackgroundImage = global::SistemaColegioEF.Properties.Resources.panel6;
            this.tpInscAlumn.Location = new System.Drawing.Point(4, 22);
            this.tpInscAlumn.Name = "tpInscAlumn";
            this.tpInscAlumn.Size = new System.Drawing.Size(717, 512);
            this.tpInscAlumn.TabIndex = 2;
            this.tpInscAlumn.Text = "Inscripcion Alumnos";
            this.tpInscAlumn.UseVisualStyleBackColor = true;
            // 
            // frmMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaColegioEF.Properties.Resources.panel6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(730, 543);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMaterias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMaterias";
            this.Load += new System.EventHandler(this.frmMaterias_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpGestionMaterias.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbNombreMateria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpGestionMaterias;
        private System.Windows.Forms.TabPage tpInscProf;
        private System.Windows.Forms.TabPage tpInscAlumn;
    }
}