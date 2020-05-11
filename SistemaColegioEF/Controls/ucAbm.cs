using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaColegioEF.Funciones;

namespace SistemaColegioEF.Controls
{
    public partial class ucAbm : UserControl
    {
        public ucAbm()
        {
            InitializeComponent();
            pnlAceptCancel.Visible = false;

            btnAgregar.Click += new EventHandler((sender, args) =>
            {
                OnClickAgregar?.Invoke(sender, args);
                pnlAceptCancel.Visible = true;
                deshabilitarGrilla?.Invoke(sender, args);
            });

            btnEliminar.Click += new EventHandler((sender, args) =>
            {
                OnClickEliminar?.Invoke(sender, args);
                if (!Valid)
                {
                    MessageBox.Show("Por favor seleccione algun registro ");
                    deshabilitarCampos?.Invoke(sender, args);
                    habilitarGrilla?.Invoke(sender, args);
                    return;
                }
            });

            btnEditar.Click += new EventHandler((sender, args) =>
            {
                OnClickEditar?.Invoke(sender, args);
                pnlAceptCancel.Visible = Valid ? true : false;
                if (!pnlAceptCancel.Visible)
                {
                    MessageBox.Show("Por favor seleccione algun registro ");
                    deshabilitarCampos?.Invoke(sender, args);
                    habilitarGrilla?.Invoke(sender, args);
                    return;
                }
                habilitarCampos?.Invoke(sender, args);
                deshabilitarGrilla?.Invoke(sender, args);
            });

            btnAceptar.Click += new EventHandler((sender, args) =>
            {
                OnClickAceptar?.Invoke(sender, args);
                if (Valid)
                {
                    pnlAceptCancel.Visible = Valid ? false : true;
                    limpiar(sender, args);
                }
            });

            btnCancelar.Click += new EventHandler((sender, args) =>
            {
                OnClickCancelar?.Invoke(sender, args);
                pnlAceptCancel.Visible = false;
                limpiar(sender, args);
                
            });
        }
        public delegate void ButtonClick(object sender, EventArgs e);
        public event ButtonClick OnClickAgregar;
        public event ButtonClick OnClickEliminar;
        public event ButtonClick OnClickEditar;
        public event ButtonClick OnClickAceptar;
        public event ButtonClick OnClickCancelar;
        public event ButtonClick habilitarCampos;
        public event ButtonClick deshabilitarCampos;
        public event ButtonClick habilitarGrilla;
        public event ButtonClick deshabilitarGrilla;

        public bool Valid { get; set; }
        public ucAbm(bool valid)
        {
            Valid = valid;
        }

        public void limpiar(object sender, EventArgs e)
        {
            habilitarGrilla?.Invoke(sender, e);
            deshabilitarCampos?.Invoke(sender, e);
            Valid = false;
        }

    }
}
