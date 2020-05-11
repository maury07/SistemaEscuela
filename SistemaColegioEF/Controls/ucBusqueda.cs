using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaColegioEF.Controls
{
    public partial class ucBusqueda : UserControl
    {
        public ucBusqueda()
        {
            InitializeComponent();
            tbBusqueda.TextChanged += new EventHandler((sender, args) =>
            {
                textChanged?.Invoke(sender, args);
            });

        }
        public delegate void ListenTextBox(object sender, EventArgs e);
        public event ListenTextBox textChanged;
        

        private void tbBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rbBusqDni.Checked)
            {
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                    return;
                }
            }
            if (rbBusqNombre.Checked)
            {
                if (Char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
        }

        private void btnLimpiarBusq_Click(object sender, EventArgs e)
        {
            tbBusqueda.Clear();
            tbBusqueda.Focus();
        }

        public string getTextBox()
        {
            return tbBusqueda.Text;
        }

        public RadioButton getRadioButton()
        {
            if (rbBusqDni.Checked)
                return rbBusqDni;
            else
                return rbBusqNombre;
        }

        private void ucBusqueda_Load(object sender, EventArgs e)
        {
            rbBusqNombre.Checked = true;
        }
    }
}
