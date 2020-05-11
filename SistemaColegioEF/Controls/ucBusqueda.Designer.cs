namespace SistemaColegioEF.Controls
{
    partial class ucBusqueda
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbBusqDni = new System.Windows.Forms.RadioButton();
            this.rbBusqNombre = new System.Windows.Forms.RadioButton();
            this.tbBusqueda = new System.Windows.Forms.TextBox();
            this.btnLimpiarBusq = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbBusqDni
            // 
            this.rbBusqDni.AutoSize = true;
            this.rbBusqDni.Location = new System.Drawing.Point(16, 3);
            this.rbBusqDni.Name = "rbBusqDni";
            this.rbBusqDni.Size = new System.Drawing.Size(63, 17);
            this.rbBusqDni.TabIndex = 0;
            this.rbBusqDni.TabStop = true;
            this.rbBusqDni.Text = "Por DNI";
            this.rbBusqDni.UseVisualStyleBackColor = true;
            // 
            // rbBusqNombre
            // 
            this.rbBusqNombre.AutoSize = true;
            this.rbBusqNombre.Location = new System.Drawing.Point(16, 37);
            this.rbBusqNombre.Name = "rbBusqNombre";
            this.rbBusqNombre.Size = new System.Drawing.Size(81, 17);
            this.rbBusqNombre.TabIndex = 1;
            this.rbBusqNombre.TabStop = true;
            this.rbBusqNombre.Text = "Por Nombre";
            this.rbBusqNombre.UseVisualStyleBackColor = true;
            // 
            // tbBusqueda
            // 
            this.tbBusqueda.Location = new System.Drawing.Point(118, 15);
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Size = new System.Drawing.Size(156, 20);
            this.tbBusqueda.TabIndex = 2;
            this.tbBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBusqueda_KeyPress);
            // 
            // btnLimpiarBusq
            // 
            this.btnLimpiarBusq.Location = new System.Drawing.Point(291, 13);
            this.btnLimpiarBusq.Name = "btnLimpiarBusq";
            this.btnLimpiarBusq.Size = new System.Drawing.Size(114, 23);
            this.btnLimpiarBusq.TabIndex = 3;
            this.btnLimpiarBusq.Text = "Limpiar Busqueda";
            this.btnLimpiarBusq.UseVisualStyleBackColor = true;
            this.btnLimpiarBusq.Click += new System.EventHandler(this.btnLimpiarBusq_Click);
            // 
            // ucBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLimpiarBusq);
            this.Controls.Add(this.tbBusqueda);
            this.Controls.Add(this.rbBusqNombre);
            this.Controls.Add(this.rbBusqDni);
            this.Name = "ucBusqueda";
            this.Size = new System.Drawing.Size(416, 59);
            this.Load += new System.EventHandler(this.ucBusqueda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbBusqDni;
        private System.Windows.Forms.RadioButton rbBusqNombre;
        private System.Windows.Forms.TextBox tbBusqueda;
        private System.Windows.Forms.Button btnLimpiarBusq;
    }
}
